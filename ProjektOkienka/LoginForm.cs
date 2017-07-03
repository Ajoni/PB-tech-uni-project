using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektOkienka;

namespace ProjektOkienka
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isLogged(textBox1.Text, textBox2.Text) == 1)
            {
                var form = new ClientForm();
                form.Show(this);
            }
            //else textBox1.Text = "DDDDDDDDsdasdasd";
            if (isLogged(textBox1.Text, textBox2.Text) == 2)
            {
                var form = new BankForm();
                form.Show(this);
            }
            else textBox1.Text = "asdasdasd";
            if(textBox1.Text== PaymentCardServiceCenter.GetBanks()[0].Name && textBox2.Text== PaymentCardServiceCenter.GetBanks()[0].Password) textBox1.Text = "tak";
            textBox3.Text = PaymentCardServiceCenter.GetBanks()[0].Name;
            textBox4.Text = PaymentCardServiceCenter.GetBanks()[0].Password;
        }

        private int isLogged(string login, string password)
        {
            foreach (Client c in PaymentCardServiceCenter.GetClients())
            {
                if (c.GetKRS() == login && c.GetPassword() == password)
                {
                    return 1;
                }
            }
            foreach (Bank b in PaymentCardServiceCenter.GetBanks())
            {
                if (b.Name == login && b.Password == password)
                {
                    return 2;
                }
            }
            if (login == "admin" && password == "admin")
            {
                return 3;
            }
            return 0;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

    }
}
