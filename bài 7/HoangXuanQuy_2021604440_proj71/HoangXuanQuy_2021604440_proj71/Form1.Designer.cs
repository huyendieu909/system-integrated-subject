namespace HoangXuanQuy_2021604440_proj71
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStk = new System.Windows.Forms.TextBox();
            this.tbTtk = new System.Windows.Forms.TextBox();
            this.tbDc = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.countAcc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 403);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 343);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetAnAccount);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "So tai khoan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ten tai khoan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dia chi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "So dien thoai";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbStk
            // 
            this.tbStk.Location = new System.Drawing.Point(438, 72);
            this.tbStk.Margin = new System.Windows.Forms.Padding(4);
            this.tbStk.Name = "tbStk";
            this.tbStk.Size = new System.Drawing.Size(132, 30);
            this.tbStk.TabIndex = 8;
            // 
            // tbTtk
            // 
            this.tbTtk.Location = new System.Drawing.Point(438, 130);
            this.tbTtk.Margin = new System.Windows.Forms.Padding(4);
            this.tbTtk.Name = "tbTtk";
            this.tbTtk.Size = new System.Drawing.Size(132, 30);
            this.tbTtk.TabIndex = 9;
            // 
            // tbDc
            // 
            this.tbDc.Location = new System.Drawing.Point(438, 188);
            this.tbDc.Margin = new System.Windows.Forms.Padding(4);
            this.tbDc.Name = "tbDc";
            this.tbDc.Size = new System.Drawing.Size(132, 30);
            this.tbDc.TabIndex = 10;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(438, 246);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(132, 30);
            this.tbSdt.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(720, 72);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 13;
            this.button4.Text = "&Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(720, 131);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 14;
            this.button5.Text = "&Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(720, 190);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 29);
            this.button6.TabIndex = 15;
            this.button6.Text = "&Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(720, 249);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 29);
            this.button7.TabIndex = 16;
            this.button7.Text = "&Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "ACCOUNTS MANAGEMENT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbSt
            // 
            this.tbSt.Location = new System.Drawing.Point(438, 310);
            this.tbSt.Margin = new System.Windows.Forms.Padding(4);
            this.tbSt.Name = "tbSt";
            this.tbSt.Size = new System.Drawing.Size(132, 30);
            this.tbSt.TabIndex = 12;
            this.tbSt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "So tien";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(967, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 20;
            this.button2.Text = "Clo&se";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Number of Accounts";
            // 
            // countAcc
            // 
            this.countAcc.AutoSize = true;
            this.countAcc.Location = new System.Drawing.Point(748, 345);
            this.countAcc.Name = "countAcc";
            this.countAcc.Size = new System.Drawing.Size(23, 25);
            this.countAcc.TabIndex = 22;
            this.countAcc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 744);
            this.Controls.Add(this.countAcc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbSt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbSdt);
            this.Controls.Add(this.tbDc);
            this.Controls.Add(this.tbTtk);
            this.Controls.Add(this.tbStk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Nganhang";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStk;
        private System.Windows.Forms.TextBox tbTtk;
        private System.Windows.Forms.TextBox tbDc;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label countAcc;
    }
}

