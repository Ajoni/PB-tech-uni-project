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
            switch (isLogged(textBox1.Text, textBox2.Text))
            {
                case 1:
                {
                    var form = new ClientForm();
                        this.Hide();
                        form.Show(this);
                        break;
                }

                case 2:
                {
                    var form = new BankForm();
                    this.Hide();
                    form.Show(this);
                        break;
                }
                default:
                    {
                        var form = new BadLoginPopUpForm();
                        form.Show(this);
                        break;
                    }
            }
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
