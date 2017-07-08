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
            this.ServBtn = new System.Windows.Forms.Button();
            this.TransBtn = new System.Windows.Forms.Button();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CliKRSAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CliNameAdd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RmvBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientNameGrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsKRSGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientTypeGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.ServBtn);
            this.groupBox1.Controls.Add(this.TransBtn);
            this.groupBox1.Controls.Add(this.ShopBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CliKRSAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CliNameAdd);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(512, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 388);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Clients";
            // 
            // ServBtn
            // 
            this.ServBtn.Location = new System.Drawing.Point(272, 152);
            this.ServBtn.Name = "ServBtn";
            this.ServBtn.Size = new System.Drawing.Size(90, 23);
            this.ServBtn.TabIndex = 12;
            this.ServBtn.Text = "Service";
            this.ServBtn.UseVisualStyleBackColor = true;
            // 
            // TransBtn
            // 
            this.TransBtn.Location = new System.Drawing.Point(176, 152);
            this.TransBtn.Name = "TransBtn";
            this.TransBtn.Size = new System.Drawing.Size(90, 23);
            this.TransBtn.TabIndex = 11;
            this.TransBtn.Text = "Transport";
            this.TransBtn.UseVisualStyleBackColor = true;
            // 
            // ShopBtn
            // 
            this.ShopBtn.Location = new System.Drawing.Point(80, 152);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(90, 23);
            this.ShopBtn.TabIndex = 8;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "KRS";
            // 
            // CliKRSAdd
            // 
            this.CliKRSAdd.Location = new System.Drawing.Point(6, 89);
            this.CliKRSAdd.Name = "CliKRSAdd";
            this.CliKRSAdd.Size = new System.Drawing.Size(175, 22);
            this.CliKRSAdd.TabIndex = 9;
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
            // CliNameAdd
            // 
            this.CliNameAdd.Location = new System.Drawing.Point(6, 41);
            this.CliNameAdd.Name = "CliNameAdd";
            this.CliNameAdd.Size = new System.Drawing.Size(175, 22);
            this.CliNameAdd.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RmvBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 176);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove";
            // 
            // RmvBtn
            // 
            this.RmvBtn.Location = new System.Drawing.Point(22, 21);
            this.RmvBtn.Name = "RmvBtn";
            this.RmvBtn.Size = new System.Drawing.Size(75, 23);
            this.RmvBtn.TabIndex = 1;
            this.RmvBtn.Text = "Remove";
            this.RmvBtn.UseVisualStyleBackColor = true;
            this.RmvBtn.Click += new System.EventHandler(this.RmvBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientNameGrd,
            this.ClientsKRSGrid,
            this.ClientTypeGrid});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClientNameGrd
            // 
            this.ClientNameGrd.HeaderText = "Name";
            this.ClientNameGrd.Name = "ClientNameGrd";
            this.ClientNameGrd.ReadOnly = true;
            this.ClientNameGrd.Width = 130;
            // 
            // ClientsKRSGrid
            // 
            this.ClientsKRSGrid.HeaderText = "KRS";
            this.ClientsKRSGrid.Name = "ClientsKRSGrid";
            this.ClientsKRSGrid.ReadOnly = true;
            this.ClientsKRSGrid.Width = 120;
            // 
            // ClientTypeGrid
            // 
            this.ClientTypeGrid.HeaderText = "Type";
            this.ClientTypeGrid.Name = "ClientTypeGrid";
            this.ClientTypeGrid.ReadOnly = true;
            this.ClientTypeGrid.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cards";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsKRSGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientTypeGrid;
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
    }
}