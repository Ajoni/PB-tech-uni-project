namespace ProjektOkienka
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intFundsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rmvbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RecievierNamePay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.intPay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RecievierCardPay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TitlePay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.floatPay = new System.Windows.Forms.TextBox();
            this.floatFundsBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(979, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Payment Cards";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Funds,
            this.Bank});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(467, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(896, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // intFundsBox
            // 
            this.intFundsBox.Location = new System.Drawing.Point(6, 38);
            this.intFundsBox.Name = "intFundsBox";
            this.intFundsBox.Size = new System.Drawing.Size(82, 22);
            this.intFundsBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Funds";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(479, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Managment";
            // 
            // Nr
            // 
            this.Nr.HeaderText = "Nr";
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Width = 130;
            // 
            // Funds
            // 
            this.Funds.HeaderText = "Funds";
            this.Funds.Name = "Funds";
            this.Funds.ReadOnly = true;
            // 
            // Bank
            // 
            this.Bank.HeaderText = "Bank";
            this.Bank.Name = "Bank";
            this.Bank.ReadOnly = true;
            // 
            // Rmvbtn
            // 
            this.Rmvbtn.Location = new System.Drawing.Point(25, 48);
            this.Rmvbtn.Name = "Rmvbtn";
            this.Rmvbtn.Size = new System.Drawing.Size(75, 23);
            this.Rmvbtn.TabIndex = 5;
            this.Rmvbtn.Text = "Remove";
            this.Rmvbtn.UseVisualStyleBackColor = true;
            this.Rmvbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.floatFundsBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.intFundsBox);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 109);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manage Funds";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "ATM";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Credit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 79);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Debit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(204, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 109);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request Card";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.floatPay);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.TitlePay);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.RecievierCardPay);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.intPay);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.RecievierNamePay);
            this.groupBox5.Location = new System.Drawing.Point(479, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(490, 226);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Recivers Name";
            // 
            // RecievierNamePay
            // 
            this.RecievierNamePay.Location = new System.Drawing.Point(3, 134);
            this.RecievierNamePay.Name = "RecievierNamePay";
            this.RecievierNamePay.Size = new System.Drawing.Size(172, 22);
            this.RecievierNamePay.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter Amount";
            // 
            // intPay
            // 
            this.intPay.Location = new System.Drawing.Point(3, 89);
            this.intPay.Name = "intPay";
            this.intPay.Size = new System.Drawing.Size(94, 22);
            this.intPay.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Enter Recivers Card Nr";
            // 
            // RecievierCardPay
            // 
            this.RecievierCardPay.Location = new System.Drawing.Point(3, 180);
            this.RecievierCardPay.Name = "RecievierCardPay";
            this.RecievierCardPay.Size = new System.Drawing.Size(172, 22);
            this.RecievierCardPay.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Title";
            // 
            // TitlePay
            // 
            this.TitlePay.Location = new System.Drawing.Point(3, 43);
            this.TitlePay.Name = "TitlePay";
            this.TitlePay.Size = new System.Drawing.Size(468, 22);
            this.TitlePay.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = ",";
            // 
            // floatPay
            // 
            this.floatPay.Location = new System.Drawing.Point(110, 89);
            this.floatPay.Name = "floatPay";
            this.floatPay.Size = new System.Drawing.Size(94, 22);
            this.floatPay.TabIndex = 14;
            // 
            // floatFundsBox
            // 
            this.floatFundsBox.Location = new System.Drawing.Point(98, 38);
            this.floatFundsBox.Name = "floatFundsBox";
            this.floatFundsBox.Size = new System.Drawing.Size(94, 22);
            this.floatFundsBox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = ",";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rmvbtn);
            this.groupBox2.Location = new System.Drawing.Point(335, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 107);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Card";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "Make a payment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intFundsBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox floatPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TitlePay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RecievierCardPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox intPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RecievierNamePay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Rmvbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.TextBox floatFundsBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
    }
}