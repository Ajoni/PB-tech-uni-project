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
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                LoggedClient.RequestAuthorization(card, amount, RecievierNamePay.Text, RecievierCardPay.Text, TitlePay.Text);
                card.Pay(amount);
            }
            catch (RequestRejectedException ex)
            {
                ErrorLabel.Text = $"Bank {ex.BankName} has rejected Your request";
            }
            catch(InvalidValueException ex)
            {
                ErrorLabel.Text = $"{ex.val} is not a valid input";
            }
            catch(FormatException ex)
            {
                ErrorLabel.Text = $"{ex.ToString()} is not a valid input";
            }
        }
    }
}
