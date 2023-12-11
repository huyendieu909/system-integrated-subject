namespace Bai11_Quy440_Si_Winform
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
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            this.btnGetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(12, 76);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 62;
            this.dtgNhanVien.RowTemplate.Height = 28;
            this.dtgNhanVien.Size = new System.Drawing.Size(1068, 550);
            this.dtgNhanVien.TabIndex = 0;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(12, 12);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(309, 47);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Lấy toàn bộ danh sách nhân viên";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 649);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.dtgNhanVien);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNhanVien;
        private System.Windows.Forms.Button btnGetAll;
    }
}

