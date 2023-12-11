namespace bai11_4
{
    partial class bai11_4
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
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetByGender = new System.Windows.Forms.Button();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(182, 45);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(67, 24);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(348, 45);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(54, 24);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới tính";
            // 
            // btnGetByGender
            // 
            this.btnGetByGender.Location = new System.Drawing.Point(499, 32);
            this.btnGetByGender.Name = "btnGetByGender";
            this.btnGetByGender.Size = new System.Drawing.Size(305, 50);
            this.btnGetByGender.TabIndex = 3;
            this.btnGetByGender.Text = "Lấy danh  sách nhân viên theo giới tính";
            this.btnGetByGender.UseVisualStyleBackColor = true;
            this.btnGetByGender.Click += new System.EventHandler(this.btnGetByGender_Click);
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(12, 123);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 62;
            this.dtgNhanVien.RowTemplate.Height = 28;
            this.dtgNhanVien.Size = new System.Drawing.Size(817, 311);
            this.dtgNhanVien.TabIndex = 4;
            // 
            // bai11_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 526);
            this.Controls.Add(this.dtgNhanVien);
            this.Controls.Add(this.btnGetByGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Name = "bai11_4";
            this.Text = "Bai11_4";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetByGender;
        private System.Windows.Forms.DataGridView dtgNhanVien;
    }
}

