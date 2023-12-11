namespace bai11_7
{
    partial class bai11_7
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
            this.btnGet = new System.Windows.Forms.Button();
            this.tbMaDV = new System.Windows.Forms.TextBox();
            this.dtgDonVi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonVi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn vị";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(409, 9);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(298, 39);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Lấy đơn vị theo mã";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // tbMaDV
            // 
            this.tbMaDV.Location = new System.Drawing.Point(145, 15);
            this.tbMaDV.Name = "tbMaDV";
            this.tbMaDV.Size = new System.Drawing.Size(202, 26);
            this.tbMaDV.TabIndex = 2;
            this.tbMaDV.TextChanged += new System.EventHandler(this.tbMaDV_TextChanged);
            // 
            // dtgDonVi
            // 
            this.dtgDonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDonVi.Location = new System.Drawing.Point(16, 63);
            this.dtgDonVi.Name = "dtgDonVi";
            this.dtgDonVi.RowHeadersWidth = 62;
            this.dtgDonVi.RowTemplate.Height = 28;
            this.dtgDonVi.Size = new System.Drawing.Size(772, 375);
            this.dtgDonVi.TabIndex = 3;
            // 
            // bai11_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgDonVi);
            this.Controls.Add(this.tbMaDV);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.label1);
            this.Name = "bai11_7";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonVi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox tbMaDV;
        private System.Windows.Forms.DataGridView dtgDonVi;
    }
}

