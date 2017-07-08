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
            

        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);

            }
        }
    }
}
