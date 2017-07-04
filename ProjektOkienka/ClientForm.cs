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
    }
}
