namespace bai11_6
{
    partial class bai11_6
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
            this.btnGetAllDonVi = new System.Windows.Forms.Button();
            this.dtgDonVi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAllDonVi
            // 
            this.btnGetAllDonVi.Location = new System.Drawing.Point(0, 0);
            this.btnGetAllDonVi.Name = "btnGetAllDonVi";
            this.btnGetAllDonVi.Size = new System.Drawing.Size(346, 47);
            this.btnGetAllDonVi.TabIndex = 0;
            this.btnGetAllDonVi.Text = "Lấy toàn bộ danh sách đơn vị";
            this.btnGetAllDonVi.UseVisualStyleBackColor = true;
            this.btnGetAllDonVi.Click += new System.EventHandler(this.btnGetAllDonVi_Click);
            // 
            // dtgDonVi
            // 
            this.dtgDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDonVi.Location = new System.Drawing.Point(12, 53);
            this.dtgDonVi.Name = "dtgDonVi";
            this.dtgDonVi.RowHeadersWidth = 62;
            this.dtgDonVi.RowTemplate.Height = 28;
            this.dtgDonVi.Size = new System.Drawing.Size(776, 385);
            this.dtgDonVi.TabIndex = 1;
            // 
            // bai11_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgDonVi);
            this.Controls.Add(this.btnGetAllDonVi);
            this.Name = "bai11_6";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonVi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllDonVi;
        private System.Windows.Forms.DataGridView dtgDonVi;
    }
}

