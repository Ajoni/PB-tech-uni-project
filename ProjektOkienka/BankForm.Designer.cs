namespace ProjektOkienka
{
    partial class BankForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CliPassBox = new System.Windows.Forms.TextBox();
            this.ServBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CliNameAdd = new System.Windows.Forms.TextBox();
            this.CliKRSAdd = new System.Windows.Forms.TextBox();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.TransBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RmvBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientNameGrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsKRSGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientTypeGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonATM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CardKRSBox = new System.Windows.Forms.TextBox();
            this.buttonDebit = new System.Windows.Forms.Button();
            this.buttonCredit = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RmvCardBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(982, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ErrorBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Clients";
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.SystemColors.Window;
            this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorBox.Location = new System.Drawing.Point(780, 15);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.Size = new System.Drawing.Size(157, 96);
            this.ErrorBox.TabIndex = 3;
            this.ErrorBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CliPassBox);
            this.groupBox3.Controls.Add(this.ServBtn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CliNameAdd);
            this.groupBox3.Controls.Add(this.CliKRSAdd);
            this.groupBox3.Controls.Add(this.ShopBtn);
            this.groupBox3.Controls.Add(this.TransBtn);
            this.groupBox3.Location = new System.Drawing.Point(6, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 117);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // CliPassBox
            // 
            this.CliPassBox.Location = new System.Drawing.Point(461, 41);
            this.CliPassBox.Name = "CliPassBox";
            this.CliPassBox.Size = new System.Drawing.Size(167, 22);
            this.CliPassBox.TabIndex = 13;
            // 
            // ServBtn
            // 
            this.ServBtn.Location = new System.Drawing.Point(198, 82);
            this.ServBtn.Name = "ServBtn";
            this.ServBtn.Size = new System.Drawing.Size(90, 23);
            this.ServBtn.TabIndex = 12;
            this.ServBtn.Text = "Service";
            this.ServBtn.UseVisualStyleBackColor = true;
            this.ServBtn.Click += new System.EventHandler(this.ServBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "KRS";
            // 
            // CliNameAdd
            // 
            this.CliNameAdd.Location = new System.Drawing.Point(6, 41);
            this.CliNameAdd.Name = "CliNameAdd";
            this.CliNameAdd.Size = new System.Drawing.Size(276, 22);
            this.CliNameAdd.TabIndex = 6;
            // 
            // CliKRSAdd
            // 
            this.CliKRSAdd.Location = new System.Drawing.Point(288, 41);
            this.CliKRSAdd.Name = "CliKRSAdd";
            this.CliKRSAdd.Size = new System.Drawing.Size(167, 22);
            this.CliKRSAdd.TabIndex = 9;
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(6, 82);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(90, 23);
            this.ShopBtn.TabIndex = 8;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // TransBtn
            // 
            this.TransBtn.Location = new System.Drawing.Point(102, 82);
            this.TransBtn.Name = "TransBtn";
            this.TransBtn.Size = new System.Drawing.Size(90, 23);
            this.TransBtn.TabIndex = 11;
            this.TransBtn.Text = "Transport";
            this.TransBtn.UseVisualStyleBackColor = true;
            this.TransBtn.Click += new System.EventHandler(this.TransBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RmvBtn);
            this.groupBox2.Location = new System.Drawing.Point(654, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove";
            // 
            // RmvBtn
            // 
            this.RmvBtn.Location = new System.Drawing.Point(6, 21);
            this.RmvBtn.Name = "RmvBtn";
            this.RmvBtn.Size = new System.Drawing.Size(96, 49);
            this.RmvBtn.TabIndex = 1;
            this.RmvBtn.Text = "Remove";
            this.RmvBtn.UseVisualStyleBackColor = true;
            this.RmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientNameGrd,
            this.ClientsKRSGrid,
            this.ClientTypeGrid});
            this.dataGridView1.Location = new System.Drawing.Point(6, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClientNameGrd
            // 
            this.ClientNameGrd.HeaderText = "Name";
            this.ClientNameGrd.Name = "ClientNameGrd";
            this.ClientNameGrd.ReadOnly = true;
            this.ClientNameGrd.Width = 150;
            // 
            // ClientsKRSGrid
            // 
            this.ClientsKRSGrid.HeaderText = "KRS";
            this.ClientsKRSGrid.Name = "ClientsKRSGrid";
            this.ClientsKRSGrid.ReadOnly = true;
            this.ClientsKRSGrid.Width = 150;
            // 
            // ClientTypeGrid
            // 
            this.ClientTypeGrid.HeaderText = "Type";
            this.ClientTypeGrid.Name = "ClientTypeGrid";
            this.ClientTypeGrid.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(962, 133);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Cards";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(780, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(157, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonATM);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.CardKRSBox);
            this.groupBox5.Controls.Add(this.buttonDebit);
            this.groupBox5.Controls.Add(this.buttonCredit);
            this.groupBox5.Location = new System.Drawing.Point(6, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(564, 117);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add";
            // 
            // buttonATM
            // 
            this.buttonATM.Location = new System.Drawing.Point(198, 82);
            this.buttonATM.Name = "buttonATM";
            this.buttonATM.Size = new System.Drawing.Size(90, 23);
            this.buttonATM.TabIndex = 12;
            this.buttonATM.Text = "ATM";
            this.buttonATM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "KRS";
            // 
            // CardKRSBox
            // 
            this.CardKRSBox.Location = new System.Drawing.Point(6, 43);
            this.CardKRSBox.Name = "CardKRSBox";
            this.CardKRSBox.Size = new System.Drawing.Size(242, 22);
            this.CardKRSBox.TabIndex = 9;
            // 
            // buttonDebit
            // 
            this.buttonDebit.Location = new System.Drawing.Point(6, 82);
            this.buttonDebit.Name = "buttonDebit";
            this.buttonDebit.Size = new System.Drawing.Size(90, 23);
            this.buttonDebit.TabIndex = 8;
            this.buttonDebit.Text = "Debit";
            this.buttonDebit.UseVisualStyleBackColor = true;
            this.buttonDebit.Click += new System.EventHandler(this.buttonDebit_Click);
            // 
            // buttonCredit
            // 
            this.buttonCredit.Location = new System.Drawing.Point(102, 82);
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.Size = new System.Drawing.Size(90, 23);
            this.buttonCredit.TabIndex = 11;
            this.buttonCredit.Text = "Credit";
            this.buttonCredit.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RmvCardBtn);
            this.groupBox6.Location = new System.Drawing.Point(599, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(175, 94);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Remove";
            // 
            // RmvCardBtn
            // 
            this.RmvCardBtn.Location = new System.Drawing.Point(22, 21);
            this.RmvCardBtn.Name = "RmvCardBtn";
            this.RmvCardBtn.Size = new System.Drawing.Size(134, 67);
            this.RmvCardBtn.TabIndex = 1;
            this.RmvCardBtn.Text = "Remove";
            this.RmvCardBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Funds,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(6, 145);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(965, 248);
            this.dataGridView2.TabIndex = 3;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(897, 0);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(95, 35);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "KRS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Funds
            // 
            this.Funds.HeaderText = "Funds";
            this.Funds.Name = "Funds";
            this.Funds.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 453);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "BankForm";
            this.Text = "BankForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ServBtn;
        private System.Windows.Forms.Button TransBtn;
        private System.Windows.Forms.Button ShopBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CliKRSAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CliNameAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RmvBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsKRSGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientTypeGrid;
        private System.Windows.Forms.RichTextBox ErrorBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonATM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CardKRSBox;
        private System.Windows.Forms.Button buttonDebit;
        private System.Windows.Forms.Button buttonCredit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button RmvCardBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CliPassBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funds;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}