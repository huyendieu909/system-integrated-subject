namespace bai11_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.btnGet1NV = new System.Windows.Forms.Button();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(250, 47);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(351, 26);
            this.tbMaNV.TabIndex = 1;
            // 
            // btnGet1NV
            // 
            this.btnGet1NV.Location = new System.Drawing.Point(635, 38);
            this.btnGet1NV.Name = "btnGet1NV";
            this.btnGet1NV.Size = new System.Drawing.Size(231, 45);
            this.btnGet1NV.TabIndex = 2;
            this.btnGet1NV.Text = "Lấy thông tin nhân viên";
            this.btnGet1NV.UseVisualStyleBackColor = true;
            this.btnGet1NV.Click += new System.EventHandler(this.btnGet1NV_Click);
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(12, 124);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 62;
            this.dtgNhanVien.RowTemplate.Height = 28;
            this.dtgNhanVien.Size = new System.Drawing.Size(1014, 508);
            this.dtgNhanVien.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 669);
            this.Controls.Add(this.dtgNhanVien);
            this.Controls.Add(this.btnGet1NV);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Button btnGet1NV;
        private System.Windows.Forms.DataGridView dtgNhanVien;
    }
}

