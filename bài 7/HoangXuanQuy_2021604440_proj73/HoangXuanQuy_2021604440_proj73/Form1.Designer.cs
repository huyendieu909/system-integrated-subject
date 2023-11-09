namespace HoangXuanQuy_2021604440_proj73
{
    partial class Bai7
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
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.lbAccountNo = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.tbAccountNo = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClrTB = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(16, 489);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersWidth = 62;
            this.dgvAccounts.RowTemplate.Height = 28;
            this.dgvAccounts.Size = new System.Drawing.Size(1266, 225);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
            this.dgvAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellContentClick);
            // 
            // lbAccountNo
            // 
            this.lbAccountNo.AutoSize = true;
            this.lbAccountNo.Location = new System.Drawing.Point(78, 40);
            this.lbAccountNo.Name = "lbAccountNo";
            this.lbAccountNo.Size = new System.Drawing.Size(98, 20);
            this.lbAccountNo.TabIndex = 1;
            this.lbAccountNo.Text = "Số tài khoản";
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(78, 82);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(105, 20);
            this.lbAccountName.TabIndex = 2;
            this.lbAccountName.Text = "Tên tài khoản";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(78, 124);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(57, 20);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(78, 166);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(81, 20);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Điện thoại";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(78, 208);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(59, 20);
            this.lbBalance.TabIndex = 5;
            this.lbBalance.Text = "Số tiền";
            // 
            // tbAccountNo
            // 
            this.tbAccountNo.Location = new System.Drawing.Point(266, 42);
            this.tbAccountNo.Name = "tbAccountNo";
            this.tbAccountNo.Size = new System.Drawing.Size(100, 26);
            this.tbAccountNo.TabIndex = 6;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(266, 82);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(100, 26);
            this.tbAccountName.TabIndex = 7;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(266, 122);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 26);
            this.tbAddress.TabIndex = 8;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(266, 162);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 26);
            this.tbPhone.TabIndex = 9;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(266, 202);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(100, 26);
            this.tbBalance.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(556, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(556, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(556, 145);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 44);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "&Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(556, 201);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 44);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClrTB
            // 
            this.btnClrTB.Location = new System.Drawing.Point(211, 253);
            this.btnClrTB.Name = "btnClrTB";
            this.btnClrTB.Size = new System.Drawing.Size(155, 41);
            this.btnClrTB.TabIndex = 15;
            this.btnClrTB.Text = "&ClearTextBox";
            this.btnClrTB.UseVisualStyleBackColor = true;
            this.btnClrTB.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(556, 262);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 80);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 731);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnClrTB);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbAccountName);
            this.Controls.Add(this.tbAccountNo);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.lbAccountNo);
            this.Controls.Add(this.dgvAccounts);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Label lbAccountNo;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox tbAccountNo;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClrTB;
        private System.Windows.Forms.Button btnShowAll;
    }
}

