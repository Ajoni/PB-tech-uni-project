using ProjektOkienka;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjektOkienka
{
    public static class PaymentCardServiceCenter
    {
        private static List<Bank> Banks = new List<Bank>();
        private static List<Client> Clients = new List<Client>();
        public static List<Payment> Payments = new List<Payment>();
        private static string PathToBankData = "data.txt";
        private static string PathToClientData = "Cdata.txt";
        public static Archive DB { get; set; }

        static PaymentCardServiceCenter()
        {
            DB = new Archive();
            LoadBankData();
            LoadClientData();
            //LoadPayments();
        }

        public static string DataPath { get; set; }

        static public bool AuthorizePayment(Payment PaymentRequested, PaymentCard CardUsed)
        {
            Bank tmp = null;
            tmp = FindBank(CardUsed.GetBank());
            if (tmp.Authorize())
            {
                CardUsed.Pay(Convert.ToDouble(PaymentRequested.Amount));
                FindClient(PaymentRequested.ToKRS).FindCard(PaymentRequested.ToCard).AddFunds(Convert.ToDouble(PaymentRequested.Amount));
                DB.Write(PaymentRequested);
                Payments.Add(PaymentRequested);
                return true;
            }
            return false;
        }

        public static void LoadBankData()
        {
            StreamReader file = new StreamReader(PathToBankData);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] Words = line.Split(' ');
                string BankName = "",BankPass="";
                int i = 0;
                while (Words[i] != ";")
                {
                    BankName += Words[i]; BankName += " ";//adds space if there should be one, if not its deleted when exiting loop
                    i++;
                }
                i++; BankName = BankName.Remove(BankName.ToString().Length - 1);//skiping seperator and deleteing excessive space, bank read

                while (Words[i] != ";")
                {
                    BankPass += Words[i];// BankName += " ";//adds space if there should be one, if not its deleted when exiting loop
                    i++;
                }
                i++;// BankPass = BankPass.Remove(BankPass.ToString().Length - 1);//skiping seperator and deleteing excessive space, bank read

                Bank tmpBank = new Bank(BankName,BankPass);
                Client tmpClient = null;
                PaymentCard PCard = null;

                int Clientsnum = Convert.ToInt32(Words[i]); i++;
                while (Clientsnum > 0)
                {
                    Clientsnum--;
                    while (Words[i] != ";")
                    {
                        string KRS = Words[i]; i++;
                        string Password = "";
                        while (Words[i] != "}")
                        {
                            Password += Words[i]; i++;
                        }
                        i++;
                        string Name = "";
                        while (Words[i] != "}")
                        { Name += Words[i]; i++; Name += " "; }
                        i++; Name = Name.Remove(Name.ToString().Length - 1); //skiping seperator and deleteing excessive space
                        string ClientType = Words[i]; i++;
                        if (ClientType == "Trans") { TransFirm tmp = new TransFirm(KRS, Password, Name); tmpClient = tmp; }
                        if (ClientType == "Shop") { Shop tmp = new Shop(KRS, Password, Name); tmpClient = tmp; }
                        if (ClientType == "Serv") { ServiceEstablishment tmp = new ServiceEstablishment(KRS, Password, Name); tmpClient = tmp; }
                    }
                    i++; //skiping seperator, client read
                    tmpBank.AddClient(tmpClient);

                    int CardsNum = Convert.ToInt32(Words[i]); i++;
                    while (CardsNum > 0)
                    {
                        CardsNum--;
                        while (Words[i] != "|" && i < Words.Count())
                        {
                            double CardFunds = Convert.ToDouble(Words[i]); i++;
                            string CardNr = Words[i]; i++;
                            string CardBankName = "";
                            while (Words[i] != "}")
                            { CardBankName += Words[i]; i++; CardBankName += " "; }
                            i++; CardBankName = CardBankName.Remove(CardBankName.ToString().Length - 1); //skiping seperator and deleteing excessive space
                            string CardOwner = "";
                            while (Words[i] != "}")
                            { CardOwner += Words[i]; i++; CardOwner += " "; }
                            i++; CardOwner = CardOwner.Remove(CardOwner.ToString().Length - 1); //skiping seperator and deleteing excessive space
                            string CardType = Words[i]; i++;
                            if (CardType == "ATM") { ATMCard tmpATM = new ATMCard(CardNr, CardFunds, CardBankName, CardOwner); PCard = tmpATM; }
                            if (CardType == "Debit") { DebitCard tmpDebit = new DebitCard(CardNr, CardFunds, CardBankName, CardOwner); PCard = tmpDebit; }
                            if (CardType == "Credit") { CreditCard tmpCredit = new CreditCard(CardNr, CardFunds, CardBankName, CardOwner); PCard = tmpCredit; }
                            tmpClient.AddCard(PCard);
                            tmpBank.AddCard(PCard);
                        }
                        i++; //skiping seperator, cards read
                    }
                    i++;
                }
                PaymentCardServiceCenter.AddBank(tmpBank);
            }
            file.Close();
        }

        public static void LoadClientData()
        {
            StreamReader file = new StreamReader(PathToClientData);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] Words = line.Split(' ');
                int i = 0;

                Client tmpClient = null;
                PaymentCard PCard = null;

                while (i < Words.Count())
                {
                    while (Words[i] != ";")
                    {
                        string KRS = Words[i]; i++;
                        string Password = "";
                        while (Words[i] != "}")
                        {
                            Password += Words[i]; i++;
                        }
                        i++;
                        string Name = "";
                        while (Words[i] != "}")
                        { Name += Words[i]; i++; Name += " "; }
                        i++; Name = Name.Remove(Name.ToString().Length - 1); //skiping seperator and deleteing excessive space
                        string ClientType = Words[i]; i++;
                        if (ClientType == "Trans") { TransFirm tmp = new TransFirm(KRS, Password, Name); tmpClient = tmp; }
                        if (ClientType == "Shop") { Shop tmp = new Shop(KRS, Password, Name); tmpClient = tmp; }
                        if (ClientType == "Serv") { ServiceEstablishment tmp = new ServiceEstablishment(KRS, Password, Name); tmpClient = tmp; }
                    }
                    i++; //skiping seperator, client read
                    PaymentCardServiceCenter.AddClient(tmpClient);

                    int CardsNum = Convert.ToInt32(Words[i]); i++;
                    while (CardsNum > 0)
                    {
                        CardsNum--;
                        while (Words[i] != "|" && i < Words.Count())
                        {
                            double CardFunds = Convert.ToDouble(Words[i]); i++;
                            string CardNr = Words[i]; i++;
                            string CardBankName = "";
                            while (Words[i] != "}")
                            { CardBankName += Words[i]; i++; CardBankName += " "; }
                            i++; CardBankName = CardBankName.Remove(CardBankName.ToString().Length - 1); //skiping seperator and deleteing excessive space
                            string CardOwner = "";
                            while (Words[i] != "}")
                            { CardOwner += Words[i]; i++; CardOwner += " "; }
                            i++; CardOwner = CardOwner.Remove(CardOwner.ToString().Length - 1); //skiping seperator and deleteing excessive space
                            string CardType = Words[i]; i++;
                            if (CardType == "ATM") { ATMCard tmpATM = new ATMCard(CardNr, CardFunds, CardBankName, CardOwner); PCard = tmpATM; }
                            if (CardType == "Debit") { DebitCard tmpDebit = new DebitCard(CardNr, CardFunds, CardBankName, CardOwner); PCard = tmpDebit; }
                            if (CardType == "Credit") { CreditCard tmpCredit = new CreditCard(CardNr, CardFunds, CardBankName, CardOwner); PCard = tmpCredit; }
                            tmpClient.AddCard(PCard);
                        }
                        i++; //skiping seperator, cards read
                    }
                    i++;
                }
            }
            file.Close();
        }

        public static void LoadPayments()
        {
            StreamReader file = new StreamReader(DB.GetPath());
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] Words = line.Split(';');
                Payments.Add(new Payment(Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6]));
            }
            file.Close();
        }

        public static void AddBank(string Name, string Pass)
        {
            Banks.Add(new Bank(Name,Pass));
        }

        public static void AddBank(Bank ToAdd)
        {
            Banks.Add(ToAdd);
            //System.Console.WriteLine(ToAdd.ToString());
        }

        public static void RemoveBank(string Name)
        {
            Banks.Remove(FindBank(Name));
        }

        public static List<Bank> GetBanks()
        {
            return Banks;
        }

        public static string GetDataPath()
        {
            return DataPath;
        }

        public static List<Payment> GetPayments()
        {
            return Payments;
        }

        public static Bank FindBank(string Name)
        {
            foreach (Bank b in Banks)
            {
                if (b.Name == Name)
                    return b;
            }
            throw new BanknotFoundException(Name);
        }

        public static List<Client> GetClients()
        {
            return Clients;
        }

        public static void AddClient(string KRS, string Password, string Name)
        {
            Clients.Add(new Client(KRS, Password, Name));
        }

        public static void AddClient(Client ToAdd)
        {
            Clients.Add(ToAdd);
        }

        public static void RemoveClient(string Name)
        {
            Clients.Remove(FindClient(Name));
        }

        public static Client FindClient(string FindKRS)
        {
            foreach (Client c in Clients)
            {
                if (c.GetKRS() == FindKRS)
                    return c;
            }
            throw new ClientNotFoundException(FindKRS);
        }

        public static void UpdateDataFiles()
        {
            File.WriteAllText(PathToBankData, "");

            foreach (Bank B in Banks)
                File.AppendAllText(PathToBankData, B.ToString().Remove(B.ToString().Length - 1) + Environment.NewLine);
            File.WriteAllText(PathToClientData, "");
            foreach (Client C in Clients)
                File.AppendAllText(PathToClientData, C.ToString().Remove(C.ToString().Length - 1) + Environment.NewLine);
        }
    }
}