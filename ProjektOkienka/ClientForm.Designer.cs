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
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.PaymentBtn = new System.Windows.Forms.Button();
            this.floatPay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TitlePay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RecievierCardPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.intPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RecievierNamePay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rmvbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.BankNameBox = new System.Windows.Forms.TextBox();
            this.Debitbtn = new System.Windows.Forms.Button();
            this.ATMbtn = new System.Windows.Forms.Button();
            this.Creditbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.floatFundsBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.intFundsBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterDate = new System.Windows.Forms.TextBox();
            this.FilterTCard = new System.Windows.Forms.TextBox();
            this.FilterRec = new System.Windows.Forms.TextBox();
            this.FilterAmount = new System.Windows.Forms.TextBox();
            this.FilterFCard = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Button();
            this.FilterTitle = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(987, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ErrorLabel);
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
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(493, 144);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabel.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.PaymentBtn);
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
            this.groupBox5.Location = new System.Drawing.Point(485, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(490, 226);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment";
            // 
            // PaymentBtn
            // 
            this.PaymentBtn.Location = new System.Drawing.Point(281, 92);
            this.PaymentBtn.Name = "PaymentBtn";
            this.PaymentBtn.Size = new System.Drawing.Size(141, 65);
            this.PaymentBtn.TabIndex = 7;
            this.PaymentBtn.Text = "Make a payment";
            this.PaymentBtn.UseVisualStyleBackColor = true;
            this.PaymentBtn.Click += new System.EventHandler(this.PaymentBtn_Click);
            // 
            // floatPay
            // 
            this.floatPay.Location = new System.Drawing.Point(110, 89);
            this.floatPay.Name = "floatPay";
            this.floatPay.Size = new System.Drawing.Size(94, 22);
            this.floatPay.TabIndex = 14;
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
            this.RecievierCardPay.Size = new System.Drawing.Size(201, 22);
            this.RecievierCardPay.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Recivers KRS";
            // 
            // RecievierNamePay
            // 
            this.RecievierNamePay.Location = new System.Drawing.Point(3, 134);
            this.RecievierNamePay.Name = "RecievierNamePay";
            this.RecievierNamePay.Size = new System.Drawing.Size(201, 22);
            this.RecievierNamePay.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(485, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Managment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rmvbtn);
            this.groupBox2.Location = new System.Drawing.Point(390, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 109);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Card";
            // 
            // Rmvbtn
            // 
            this.Rmvbtn.Location = new System.Drawing.Point(2, 48);
            this.Rmvbtn.Name = "Rmvbtn";
            this.Rmvbtn.Size = new System.Drawing.Size(75, 23);
            this.Rmvbtn.TabIndex = 5;
            this.Rmvbtn.Text = "Remove";
            this.Rmvbtn.UseVisualStyleBackColor = true;
            this.Rmvbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BankNameLabel);
            this.groupBox4.Controls.Add(this.BankNameBox);
            this.groupBox4.Controls.Add(this.Debitbtn);
            this.groupBox4.Controls.Add(this.ATMbtn);
            this.groupBox4.Controls.Add(this.Creditbtn);
            this.groupBox4.Location = new System.Drawing.Point(204, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 109);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request Card";
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.Location = new System.Drawing.Point(4, 18);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(81, 17);
            this.BankNameLabel.TabIndex = 18;
            this.BankNameLabel.Text = "Bank Name";
            // 
            // BankNameBox
            // 
            this.BankNameBox.Location = new System.Drawing.Point(7, 38);
            this.BankNameBox.Name = "BankNameBox";
            this.BankNameBox.Size = new System.Drawing.Size(159, 22);
            this.BankNameBox.TabIndex = 17;
            // 
            // Debitbtn
            // 
            this.Debitbtn.Location = new System.Drawing.Point(7, 79);
            this.Debitbtn.Name = "Debitbtn";
            this.Debitbtn.Size = new System.Drawing.Size(55, 23);
            this.Debitbtn.TabIndex = 8;
            this.Debitbtn.Text = "Debit";
            this.Debitbtn.UseVisualStyleBackColor = true;
            this.Debitbtn.Click += new System.EventHandler(this.Debitbtn_Click);
            // 
            // ATMbtn
            // 
            this.ATMbtn.Location = new System.Drawing.Point(121, 79);
            this.ATMbtn.Name = "ATMbtn";
            this.ATMbtn.Size = new System.Drawing.Size(55, 23);
            this.ATMbtn.TabIndex = 6;
            this.ATMbtn.Text = "ATM";
            this.ATMbtn.UseVisualStyleBackColor = true;
            this.ATMbtn.Click += new System.EventHandler(this.ATMbtn_Click);
            // 
            // Creditbtn
            // 
            this.Creditbtn.Location = new System.Drawing.Point(62, 79);
            this.Creditbtn.Name = "Creditbtn";
            this.Creditbtn.Size = new System.Drawing.Size(56, 23);
            this.Creditbtn.TabIndex = 7;
            this.Creditbtn.Text = "Credit";
            this.Creditbtn.UseVisualStyleBackColor = true;
            this.Creditbtn.Click += new System.EventHandler(this.Creditbtn_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Funds";
            // 
            // intFundsBox
            // 
            this.intFundsBox.Location = new System.Drawing.Point(6, 38);
            this.intFundsBox.Name = "intFundsBox";
            this.intFundsBox.Size = new System.Drawing.Size(82, 22);
            this.intFundsBox.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Funds,
            this.Bank,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(476, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nr
            // 
            this.Nr.HeaderText = "Nr";
            this.Nr.Name = "Nr";
            this.Nr.ReadOnly = true;
            this.Nr.Width = 125;
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
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 50;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(979, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment history";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.FilterDate);
            this.groupBox6.Controls.Add(this.FilterTCard);
            this.groupBox6.Controls.Add(this.FilterRec);
            this.groupBox6.Controls.Add(this.FilterAmount);
            this.groupBox6.Controls.Add(this.FilterFCard);
            this.groupBox6.Controls.Add(this.Filter);
            this.groupBox6.Controls.Add(this.FilterTitle);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(972, 61);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(724, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(618, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "To card";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(495, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Receiver";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "From card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title";
            // 
            // FilterDate
            // 
            this.FilterDate.Location = new System.Drawing.Point(727, 27);
            this.FilterDate.Name = "FilterDate";
            this.FilterDate.Size = new System.Drawing.Size(100, 22);
            this.FilterDate.TabIndex = 6;
            // 
            // FilterTCard
            // 
            this.FilterTCard.Location = new System.Drawing.Point(612, 27);
            this.FilterTCard.Name = "FilterTCard";
            this.FilterTCard.Size = new System.Drawing.Size(109, 22);
            this.FilterTCard.TabIndex = 5;
            // 
            // FilterRec
            // 
            this.FilterRec.Location = new System.Drawing.Point(492, 27);
            this.FilterRec.Name = "FilterRec";
            this.FilterRec.Size = new System.Drawing.Size(114, 22);
            this.FilterRec.TabIndex = 4;
            // 
            // FilterAmount
            // 
            this.FilterAmount.Location = new System.Drawing.Point(391, 27);
            this.FilterAmount.Name = "FilterAmount";
            this.FilterAmount.Size = new System.Drawing.Size(95, 22);
            this.FilterAmount.TabIndex = 3;
            // 
            // FilterFCard
            // 
            this.FilterFCard.Location = new System.Drawing.Point(282, 27);
            this.FilterFCard.Name = "FilterFCard";
            this.FilterFCard.Size = new System.Drawing.Size(96, 22);
            this.FilterFCard.TabIndex = 2;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(877, 13);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(95, 42);
            this.Filter.TabIndex = 1;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // FilterTitle
            // 
            this.FilterTitle.Location = new System.Drawing.Point(6, 27);
            this.FilterTitle.Name = "FilterTitle";
            this.FilterTitle.Size = new System.Drawing.Size(267, 22);
            this.FilterTitle.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ToCard,
            this.Data});
            this.dataGridView2.Location = new System.Drawing.Point(3, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(972, 332);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 240;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "From card";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Receiver";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // ToCard
            // 
            this.ToCard.HeaderText = "To card";
            this.ToCard.Name = "ToCard";
            this.ToCard.ReadOnly = true;
            this.ToCard.Width = 110;
            // 
            // Data
            // 
            this.Data.HeaderText = "Date";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 120;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button Debitbtn;
        private System.Windows.Forms.Button ATMbtn;
        private System.Windows.Forms.Button Creditbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Rmvbtn;
        private System.Windows.Forms.TextBox floatFundsBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PaymentBtn;
        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.TextBox BankNameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox FilterTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilterDate;
        private System.Windows.Forms.TextBox FilterTCard;
        private System.Windows.Forms.TextBox FilterRec;
        private System.Windows.Forms.TextBox FilterAmount;
        private System.Windows.Forms.TextBox FilterFCard;
        private System.Windows.Forms.Button Filter;
    }
}