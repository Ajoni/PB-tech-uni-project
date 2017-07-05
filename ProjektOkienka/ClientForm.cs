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
                dataGridView1.Rows.Add(pc.GetNr(), pc.CheckFunds(), pc.GetBank());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LoggedClient.RemoveCard(RemoveCardBox.Text);
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
    }
}
