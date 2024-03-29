namespace Them_Sua
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.NamSinh = new System.Windows.Forms.TextBox();
            this.QueQuan = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_Trove = new System.Windows.Forms.Button();
            this.Tim_Kiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Tên";
            // 
            // MaTen
            // 
            this.MaTen.Location = new System.Drawing.Point(102, 61);
            this.MaTen.Name = "MaTen";
            this.MaTen.Size = new System.Drawing.Size(100, 22);
            this.MaTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Năm Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quê Quán";
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(102, 105);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(100, 22);
            this.HoTen.TabIndex = 2;
            // 
            // NamSinh
            // 
            this.NamSinh.Location = new System.Drawing.Point(102, 156);
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Size = new System.Drawing.Size(100, 22);
            this.NamSinh.TabIndex = 2;
            // 
            // QueQuan
            // 
            this.QueQuan.Location = new System.Drawing.Point(102, 199);
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Size = new System.Drawing.Size(100, 22);
            this.QueQuan.TabIndex = 2;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(29, 367);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(101, 62);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(137, 367);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(101, 62);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(245, 367);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(101, 62);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(353, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(461, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 62);
            this.button5.TabIndex = 3;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(569, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 62);
            this.button6.TabIndex = 3;
            this.button6.Text = "Tìm Kiếm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_Trove
            // 
            this.btn_Trove.Location = new System.Drawing.Point(677, 367);
            this.btn_Trove.Name = "btn_Trove";
            this.btn_Trove.Size = new System.Drawing.Size(101, 62);
            this.btn_Trove.TabIndex = 3;
            this.btn_Trove.Text = "Trợ Về";
            this.btn_Trove.UseVisualStyleBackColor = true;
            this.btn_Trove.Click += new System.EventHandler(this.btn_Trove_Click);
            // 
            // Tim_Kiem
            // 
            this.Tim_Kiem.Location = new System.Drawing.Point(81, 287);
            this.Tim_Kiem.Name = "Tim_Kiem";
            this.Tim_Kiem.Size = new System.Drawing.Size(121, 22);
            this.Tim_Kiem.TabIndex = 2;
            this.Tim_Kiem.TextChanged += new System.EventHandler(this.Tim_Kiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm Kiếm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Trove);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.Tim_Kiem);
            this.Controls.Add(this.QueQuan);
            this.Controls.Add(this.NamSinh);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.MaTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox NamSinh;
        private System.Windows.Forms.TextBox QueQuan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_Trove;
        private System.Windows.Forms.TextBox Tim_Kiem;
        private System.Windows.Forms.Label label5;
    }
}

