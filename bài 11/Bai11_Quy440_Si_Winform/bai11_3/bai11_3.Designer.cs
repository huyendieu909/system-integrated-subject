namespace bai11_3
{
    partial class bai11_3
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
            this.tbMaDV = new System.Windows.Forms.TextBox();
            this.btnGetDonVi = new System.Windows.Forms.Button();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn vị";
            // 
            // tbMaDV
            // 
            this.tbMaDV.Location = new System.Drawing.Point(184, 27);
            this.tbMaDV.Name = "tbMaDV";
            this.tbMaDV.Size = new System.Drawing.Size(149, 26);
            this.tbMaDV.TabIndex = 1;
            // 
            // btnGetDonVi
            // 
            this.btnGetDonVi.Location = new System.Drawing.Point(406, 22);
            this.btnGetDonVi.Name = "btnGetDonVi";
            this.btnGetDonVi.Size = new System.Drawing.Size(336, 36);
            this.btnGetDonVi.TabIndex = 2;
            this.btnGetDonVi.Text = "Lấy danh sách nhân viên theo mã đơn vị";
            this.btnGetDonVi.UseVisualStyleBackColor = true;
            this.btnGetDonVi.Click += new System.EventHandler(this.btnGetDonVi_Click);
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(12, 76);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 62;
            this.dtgNhanVien.RowTemplate.Height = 28;
            this.dtgNhanVien.Size = new System.Drawing.Size(776, 362);
            this.dtgNhanVien.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgNhanVien);
            this.Controls.Add(this.btnGetDonVi);
            this.Controls.Add(this.tbMaDV);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaDV;
        private System.Windows.Forms.Button btnGetDonVi;
        private System.Windows.Forms.DataGridView dtgNhanVien;
    }
}

