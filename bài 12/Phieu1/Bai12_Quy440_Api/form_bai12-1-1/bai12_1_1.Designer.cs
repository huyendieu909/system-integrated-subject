namespace form_bai12_1_1
{
    partial class form_bai12_1_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaDM = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btnGetByMaDM = new System.Windows.Forms.Button();
            this.btnGetByPrice = new System.Windows.Forms.Button();
            this.dtgSanPham = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoảng giá";
            // 
            // tbMaDM
            // 
            this.tbMaDM.Location = new System.Drawing.Point(161, 29);
            this.tbMaDM.Name = "tbMaDM";
            this.tbMaDM.Size = new System.Drawing.Size(100, 26);
            this.tbMaDM.TabIndex = 2;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(161, 81);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 26);
            this.tbA.TabIndex = 3;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(348, 81);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 26);
            this.tbB.TabIndex = 4;
            // 
            // btnGetByMaDM
            // 
            this.btnGetByMaDM.Location = new System.Drawing.Point(467, 12);
            this.btnGetByMaDM.Name = "btnGetByMaDM";
            this.btnGetByMaDM.Size = new System.Drawing.Size(321, 37);
            this.btnGetByMaDM.TabIndex = 5;
            this.btnGetByMaDM.Text = "Lấy danh sách sản phẩm theo danh mục";
            this.btnGetByMaDM.UseVisualStyleBackColor = true;
            this.btnGetByMaDM.Click += new System.EventHandler(this.btnGetByMaDM_Click);
            // 
            // btnGetByPrice
            // 
            this.btnGetByPrice.Location = new System.Drawing.Point(467, 68);
            this.btnGetByPrice.Name = "btnGetByPrice";
            this.btnGetByPrice.Size = new System.Drawing.Size(321, 52);
            this.btnGetByPrice.TabIndex = 6;
            this.btnGetByPrice.Text = "Lấy danh sách sản phẩm có trong khoảng đơn giá";
            this.btnGetByPrice.UseVisualStyleBackColor = true;
            this.btnGetByPrice.Click += new System.EventHandler(this.btnGetByPrice_Click);
            // 
            // dtgSanPham
            // 
            this.dtgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSanPham.Location = new System.Drawing.Point(12, 130);
            this.dtgSanPham.Name = "dtgSanPham";
            this.dtgSanPham.RowHeadersWidth = 62;
            this.dtgSanPham.RowTemplate.Height = 28;
            this.dtgSanPham.Size = new System.Drawing.Size(776, 308);
            this.dtgSanPham.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đến";
            // 
            // form_bai12_1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgSanPham);
            this.Controls.Add(this.btnGetByPrice);
            this.Controls.Add(this.btnGetByMaDM);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbMaDM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_bai12_1_1";
            this.Text = "Bài 12.1.1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaDM;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btnGetByMaDM;
        private System.Windows.Forms.Button btnGetByPrice;
        private System.Windows.Forms.DataGridView dtgSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

