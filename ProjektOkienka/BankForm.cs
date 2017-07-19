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
    public partial class BankForm : Form
    {
        LoginForm LogForm;
        Bank LoggedBank;
        public BankForm(string name, LoginForm LogForm)
        {
            InitializeComponent();
            this.LogForm = LogForm;
            LoggedBank = PaymentCardServiceCenter.FindBank(name);
            foreach(Client c in LoggedBank.GetClients())
            {
                dataGridView1.Rows.Add(c.GetName(), c.GetKRS(), c.GetType());
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.LogForm.Show();
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            Shop newShop = new Shop(CliKRSAdd.Text, CliPassBox.Text,CliNameAdd.Text);
            LoggedBank.AddClient(newShop);
            dataGridView1.Rows.Add(newShop.GetName(), newShop.GetKRS(), newShop.GetType());

        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoggedBank.RemoveClient(dataGridView1.CurrentCell.Value.ToString());
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                ErrorBox.Text = "";
            }
            catch (ClientNotFoundException)
            {

                ErrorBox.Text = "Client not found. Please select KRS from table";
            }
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            TransFirm newShop = new TransFirm(CliKRSAdd.Text, CliPassBox.Text, CliNameAdd.Text);
            LoggedBank.AddClient(newShop);
            dataGridView1.Rows.Add(newShop.GetName(), newShop.GetKRS(), newShop.GetType());
        }

        private void ServBtn_Click(object sender, EventArgs e)
        {
            ServiceEstablishment newShop = new ServiceEstablishment(CliKRSAdd.Text, CliPassBox.Text, CliNameAdd.Text);
            LoggedBank.AddClient(newShop);
            dataGridView1.Rows.Add(newShop.GetName(), newShop.GetKRS(), newShop.GetType());
        }
    }
}
