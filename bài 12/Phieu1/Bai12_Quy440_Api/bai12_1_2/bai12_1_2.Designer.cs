namespace bai12_1_2
{
    partial class bai1212
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
            this.tbTenDM = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgDanhMuc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên danh mục";
            // 
            // tbMaDM
            // 
            this.tbMaDM.Location = new System.Drawing.Point(247, 15);
            this.tbMaDM.Name = "tbMaDM";
            this.tbMaDM.Size = new System.Drawing.Size(100, 26);
            this.tbMaDM.TabIndex = 2;
            // 
            // tbTenDM
            // 
            this.tbTenDM.Location = new System.Drawing.Point(247, 72);
            this.tbTenDM.Name = "tbTenDM";
            this.tbTenDM.Size = new System.Drawing.Size(100, 26);
            this.tbTenDM.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(411, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 38);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(554, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 38);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(483, 63);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 38);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgDanhMuc
            // 
            this.dtgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhMuc.Location = new System.Drawing.Point(12, 117);
            this.dtgDanhMuc.Name = "dtgDanhMuc";
            this.dtgDanhMuc.RowHeadersWidth = 62;
            this.dtgDanhMuc.RowTemplate.Height = 28;
            this.dtgDanhMuc.Size = new System.Drawing.Size(776, 321);
            this.dtgDanhMuc.TabIndex = 7;
            this.dtgDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhMuc_CellClick);
            this.dtgDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhMuc_CellContentClick);
            // 
            // bai1212
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgDanhMuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbTenDM);
            this.Controls.Add(this.tbMaDM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai1212";
            this.Text = "Bài 12.1.2";
            this.Load += new System.EventHandler(this.bai1212_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaDM;
        private System.Windows.Forms.TextBox tbTenDM;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgDanhMuc;
    }
}

