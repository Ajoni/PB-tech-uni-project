using ProjektOkienka;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProjektOkienka
{
    public class Archive
    {
        private string PathToFile;

        public string GetPath()
        {
            return PathToFile;
        }

        public void SetPath(string ToSet)
        {
            PathToFile = ToSet;
        }

        private List<Payment> Payments = new List<Payment>();

        public Archive(string Path)
        {
            PathToFile = Path; LoadPayments();
        }

        public Archive()
        {
            PathToFile = "DB.txt"; LoadPayments();
        }

        private void LoadPayments()
        {
            StreamReader file = new StreamReader(PathToFile);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] Words = line.Split(';');
                Payments.Add(new Payment(Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6]));
            }
            file.Close();
        }

        public void Write(Payment ToWrite)
        {
            File.AppendAllText(PathToFile, ToWrite.ToString() + Environment.NewLine);
            Payments.Add(ToWrite);
        }

        public string Find(string MatchAll, string MatchAny)
        {
            string[] MandatoryWords = MatchAll.Split();
            string[] OptionalWords = MatchAny.Split();
            string Matches = "";
            foreach (Payment p in Payments)
            {
                bool Match = true;
                if ( (!MatchAll.Equals(";")) )
                {
                    foreach (string s in MandatoryWords)
                    {
                        if (!(p.ToString().Contains(s))) { Match = false; break; }
                    } 
                }
                if (MatchAll.Equals(";")) Match = false;
                if (!Match && !(MatchAny.Equals(";")))
                {
                    foreach (string s in OptionalWords)
                    {
                        if ((p.ToString().Contains(s))) { Match = true; break; }
                    }
                }

                if (Match) Matches += $"{p.ToString()}\n";
            }
            return Matches;
        }
    }
}