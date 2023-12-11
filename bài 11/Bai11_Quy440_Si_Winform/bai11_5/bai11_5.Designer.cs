namespace bai11_5
{
    partial class bai11_5
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetBySalary = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.dtgNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập khoảng hệ số lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến";
            // 
            // btnGetBySalary
            // 
            this.btnGetBySalary.Location = new System.Drawing.Point(623, 9);
            this.btnGetBySalary.Name = "btnGetBySalary";
            this.btnGetBySalary.Size = new System.Drawing.Size(275, 53);
            this.btnGetBySalary.TabIndex = 3;
            this.btnGetBySalary.Text = "Lấy danh sách nhân viên theo khoảng lương";
            this.btnGetBySalary.UseVisualStyleBackColor = true;
            this.btnGetBySalary.Click += new System.EventHandler(this.btnGetBySalary_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(299, 22);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 26);
            this.tbA.TabIndex = 4;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(473, 22);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 26);
            this.tbB.TabIndex = 5;
            // 
            // dtgNhanVien
            // 
            this.dtgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNhanVien.Location = new System.Drawing.Point(12, 68);
            this.dtgNhanVien.Name = "dtgNhanVien";
            this.dtgNhanVien.RowHeadersWidth = 62;
            this.dtgNhanVien.RowTemplate.Height = 28;
            this.dtgNhanVien.Size = new System.Drawing.Size(886, 453);
            this.dtgNhanVien.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 533);
            this.Controls.Add(this.dtgNhanVien);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.btnGetBySalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetBySalary;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.DataGridView dtgNhanVien;
    }
}

