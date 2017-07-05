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
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveCardBox = new System.Windows.Forms.TextBox();
            this.FundsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ManageFundsBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientCardPay = new System.Windows.Forms.TextBox();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(896, -1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Card Nr";
            // 
            // RemoveCardBox
            // 
            this.RemoveCardBox.Location = new System.Drawing.Point(6, 44);
            this.RemoveCardBox.Name = "RemoveCardBox";
            this.RemoveCardBox.Size = new System.Drawing.Size(172, 22);
            this.RemoveCardBox.TabIndex = 2;
            // 
            // FundsBox
            // 
            this.FundsBox.Location = new System.Drawing.Point(6, 94);
            this.FundsBox.Name = "FundsBox";
            this.FundsBox.Size = new System.Drawing.Size(100, 22);
            this.FundsBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Funds";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(479, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 218);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.RemoveCardBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 126);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Card Nr";
            // 
            // ManageFundsBox
            // 
            this.ManageFundsBox.Location = new System.Drawing.Point(6, 44);
            this.ManageFundsBox.Name = "ManageFundsBox";
            this.ManageFundsBox.Size = new System.Drawing.Size(172, 22);
            this.ManageFundsBox.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ManageFundsBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.FundsBox);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(195, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 126);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manage Funds";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
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
            this.button6.Location = new System.Drawing.Point(189, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Credit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(344, 21);
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
            this.groupBox4.Location = new System.Drawing.Point(6, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 59);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request Card";
            // 
            // groupBox5
            // 
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
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.ClientCardPay);
            this.groupBox5.Location = new System.Drawing.Point(479, 230);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(490, 165);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Enter Card Nr";
            // 
            // ClientCardPay
            // 
            this.ClientCardPay.Location = new System.Drawing.Point(12, 81);
            this.ClientCardPay.Name = "ClientCardPay";
            this.ClientCardPay.Size = new System.Drawing.Size(172, 22);
            this.ClientCardPay.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Recivers Name";
            // 
            // RecievierNamePay
            // 
            this.RecievierNamePay.Location = new System.Drawing.Point(9, 135);
            this.RecievierNamePay.Name = "RecievierNamePay";
            this.RecievierNamePay.Size = new System.Drawing.Size(172, 22);
            this.RecievierNamePay.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter Amount";
            // 
            // intPay
            // 
            this.intPay.Location = new System.Drawing.Point(189, 81);
            this.intPay.Name = "intPay";
            this.intPay.Size = new System.Drawing.Size(94, 22);
            this.intPay.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Enter Recivers Card Nr";
            // 
            // RecievierCardPay
            // 
            this.RecievierCardPay.Location = new System.Drawing.Point(187, 135);
            this.RecievierCardPay.Name = "RecievierCardPay";
            this.RecievierCardPay.Size = new System.Drawing.Size(172, 22);
            this.RecievierCardPay.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Title";
            // 
            // TitlePay
            // 
            this.TitlePay.Location = new System.Drawing.Point(9, 39);
            this.TitlePay.Name = "TitlePay";
            this.TitlePay.Size = new System.Drawing.Size(468, 22);
            this.TitlePay.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = ",";
            // 
            // floatPay
            // 
            this.floatPay.Location = new System.Drawing.Point(293, 81);
            this.floatPay.Name = "floatPay";
            this.floatPay.Size = new System.Drawing.Size(94, 22);
            this.floatPay.TabIndex = 14;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.TextBox FundsBox;
        private System.Windows.Forms.TextBox RemoveCardBox;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClientCardPay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ManageFundsBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
    }
}