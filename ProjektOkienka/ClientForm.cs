using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOkienka
{
    public partial class ClientForm : Form
    {
        Client LoggedClient;
        LoginForm LogForm;
        List<Payment> ClientsPayments = new List<Payment>();
        static bool userClose = true;
        public ClientForm(string name, LoginForm SetLogForm)
        {
            InitializeComponent();
            label1.Text = $"Logged in as {name}";
            LoggedClient = PaymentCardServiceCenter.FindClient(name);
            LogForm = SetLogForm;
            foreach(PaymentCard pc in LoggedClient.GetCards())
            {
                dataGridView1.Rows.Add(pc.GetNr(), pc.CheckFunds(), pc.GetBank(),pc.CardType());
            }
            foreach(Payment p in PaymentCardServiceCenter.DB.Payments)
            {
                if (p.FromKRS == LoggedClient.GetKRS())
                {
                    ClientsPayments.Add(p);
                    dataGridView2.Rows.Add(p.Title, p.FromKRS, p.Amount, p.ToKRS, p.ToCard, p.Date);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userClose = false;
            this.Close();
            LogForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoggedClient.RemoveCard(dataGridView1.CurrentRow.Cells["Nr"].Value.ToString());
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentCard card = LoggedClient.FindCard(dataGridView1.CurrentRow.Cells["Nr"].Value.ToString());
            card.AddFunds(Convert.ToDouble($"{intFundsBox.Text},{floatFundsBox.Text}"));
            dataGridView1.CurrentRow.Cells["Funds"].Value = card.CheckFunds();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymentCard card = LoggedClient.FindCard(dataGridView1.CurrentRow.Cells["Nr"].Value.ToString());
            card.Pay(Convert.ToDouble($"{intFundsBox.Text},{floatFundsBox.Text}"));
            dataGridView1.CurrentRow.Cells["Funds"].Value = card.CheckFunds();

        }

        private void Debitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentCard card = PaymentCardServiceCenter.FindBank(BankNameBox.Text).AuthorizeCard(LoggedClient.GetName(), 1);
                dataGridView1.Rows.Add(card.GetNr(), card.CheckFunds(), card.GetBank(), card.CardType());
                LoggedClient.AddCard(card);
            }
            catch (RequestRejectedException ex)
            {
                ErrorLabel.Text = $"Bank {ex.BankName} has rejected Your request";
            }
            catch (BanknotFoundException ex)
            {
                ErrorLabel.Text = $"Bank {ex.bank} not found";
            }
        }

        private void Creditbtn_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentCard card = PaymentCardServiceCenter.FindBank(BankNameBox.Text).AuthorizeCard(LoggedClient.GetName(), 2);
                dataGridView1.Rows.Add(card.GetNr(), card.CheckFunds(), card.GetBank(), card.CardType());
                LoggedClient.AddCard(card);
            }
            catch (RequestRejectedException ex)
            {
                ErrorLabel.Text = $"Bank {ex.BankName} has rejected Your request";
            }
            catch (BanknotFoundException ex)
            {
                ErrorLabel.Text = $"Bank {ex.bank} not found";
            }
        }

        private void ATMbtn_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentCard card = PaymentCardServiceCenter.FindBank(BankNameBox.Text).AuthorizeCard(LoggedClient.GetName(), 3);
                dataGridView1.Rows.Add(card.GetNr(), card.CheckFunds(), card.GetBank(), card.CardType());
                LoggedClient.AddCard(card);
            }
            catch (RequestRejectedException ex)
            {
                ErrorLabel.Text = $"Bank {ex.BankName} has rejected Your request";
            }
            catch(BanknotFoundException ex)
            {
                ErrorLabel.Text = $"Bank {ex.bank} not found";
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentCard card = LoggedClient.FindCard(dataGridView1.CurrentRow.Cells["Nr"].Value.ToString());
                double amount = Convert.ToDouble($"{intPay.Text},{floatPay.Text}");
                Payment pay = new Payment(LoggedClient.GetKRS(),card.GetNr(), amount.ToString(), RecievierNamePay.Text, RecievierCardPay.Text, TitlePay.Text, DateTime.Now.ToString());
                LoggedClient.RequestAuthorization(pay,card);
                card.Pay(amount);
                dataGridView1.CurrentRow.Cells["Funds"].Value = card.CheckFunds();
                dataGridView2.Rows.Add(pay.Title, pay.FromKRS, pay.Amount, pay.ToKRS, pay.ToCard,pay.Date);
                //PaymentCardServiceCenter.DB.Write(pay);
            }
            catch (FormatException)
            {
                ErrorLabel.Text = " Not a valid input"; 
            }
            catch(InvalidValueException)
            {
                ErrorLabel.Text = "Enter a positive value.";
            }
            catch (RequestRejectedException ex)
            {
                ErrorLabel.Text = $"Bank {ex.BankName} has rejected Your request";
            }
            catch(ClientNotFoundException ex)
            {
                ErrorLabel.Text = $"{ex.KRS} not found";
            }
            catch(CardNotFoundException ex)
            {
                ErrorLabel.Text = $"{ex.nr} not found";
            }
        }
        private void Filter_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach(Payment p in ClientsPayments)
            {
                if (!p.Title.Contains(FilterTitle.Text)) continue;
                if (!p.FromCard.Contains(FilterFCard.Text)) continue;
                if (!p.Amount.Contains(FilterAmount.Text)) continue;
                if (!p.ToKRS.Contains(FilterRec.Text)) continue;
                if (!p.ToCard.Contains(FilterTCard.Text)) continue;
                if (!p.Date.Contains(FilterDate.Text)) continue;
                dataGridView2.Rows.Add(p.Title, p.FromCard, p.Amount, p.ToKRS, p.ToKRS, p.Date);
            }
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userClose)
            {
                Application.Exit();
            }
        }

    }
}
