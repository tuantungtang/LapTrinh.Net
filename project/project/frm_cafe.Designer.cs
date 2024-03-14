namespace project
{
    partial class frm_cafe
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_phanLoai = new System.Windows.Forms.ComboBox();
            this.txb_trangthai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_cafe = new System.Windows.Forms.DataGridView();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Mota = new System.Windows.Forms.TextBox();
            this.txb_tensp = new System.Windows.Forms.TextBox();
            this.txb_masp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_soLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cafe)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 32);
            this.label7.TabIndex = 72;
            this.label7.Text = "Quan Ly Cafe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "Phan loai";
            // 
            // cb_phanLoai
            // 
            this.cb_phanLoai.FormattingEnabled = true;
            this.cb_phanLoai.Location = new System.Drawing.Point(183, 353);
            this.cb_phanLoai.Name = "cb_phanLoai";
            this.cb_phanLoai.Size = new System.Drawing.Size(148, 24);
            this.cb_phanLoai.TabIndex = 70;
            this.cb_phanLoai.SelectedIndexChanged += new System.EventHandler(this.cb_LoaiSach_SelectedIndexChanged);
            // 
            // txb_trangthai
            // 
            this.txb_trangthai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_trangthai.Location = new System.Drawing.Point(183, 294);
            this.txb_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_trangthai.Multiline = true;
            this.txb_trangthai.Name = "txb_trangthai";
            this.txb_trangthai.Size = new System.Drawing.Size(148, 31);
            this.txb_trangthai.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 26);
            this.label6.TabIndex = 68;
            this.label6.Text = "Trang thai";
            // 
            // dt_cafe
            // 
            this.dt_cafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_cafe.Location = new System.Drawing.Point(92, 418);
            this.dt_cafe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_cafe.Name = "dt_cafe";
            this.dt_cafe.RowTemplate.Height = 28;
            this.dt_cafe.Size = new System.Drawing.Size(735, 257);
            this.dt_cafe.TabIndex = 67;
            this.dt_cafe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_cafe_CellClick);
            this.dt_cafe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_Sach_CellContentClick);
            // 
            // btn_Dem
            // 
            this.btn_Dem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dem.Location = new System.Drawing.Point(767, 88);
            this.btn_Dem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(112, 49);
            this.btn_Dem.TabIndex = 66;
            this.btn_Dem.Text = "Dem";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(682, 298);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(113, 51);
            this.btn_Sua.TabIndex = 65;
            this.btn_Sua.Text = "Sua";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(558, 298);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(113, 51);
            this.btn_Xoa.TabIndex = 64;
            this.btn_Xoa.Text = "Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(422, 298);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(113, 51);
            this.btn_Them.TabIndex = 63;
            this.btn_Them.Text = "Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "So Luong";
            // 
            // txb_Mota
            // 
            this.txb_Mota.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Mota.Location = new System.Drawing.Point(183, 233);
            this.txb_Mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Mota.Multiline = true;
            this.txb_Mota.Name = "txb_Mota";
            this.txb_Mota.Size = new System.Drawing.Size(148, 39);
            this.txb_Mota.TabIndex = 60;
            // 
            // txb_tensp
            // 
            this.txb_tensp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tensp.Location = new System.Drawing.Point(183, 156);
            this.txb_tensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_tensp.Multiline = true;
            this.txb_tensp.Name = "txb_tensp";
            this.txb_tensp.Size = new System.Drawing.Size(148, 43);
            this.txb_tensp.TabIndex = 59;
            // 
            // txb_masp
            // 
            this.txb_masp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_masp.Location = new System.Drawing.Point(183, 94);
            this.txb_masp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_masp.Multiline = true;
            this.txb_masp.Name = "txb_masp";
            this.txb_masp.Size = new System.Drawing.Size(148, 43);
            this.txb_masp.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "Mo ta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Ten SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ma SP";
            // 
            // txb_soLuong
            // 
            this.txb_soLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soLuong.Location = new System.Drawing.Point(558, 94);
            this.txb_soLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_soLuong.Multiline = true;
            this.txb_soLuong.Name = "txb_soLuong";
            this.txb_soLuong.Size = new System.Drawing.Size(148, 43);
            this.txb_soLuong.TabIndex = 73;
            // 
            // frm_cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 708);
            this.Controls.Add(this.txb_soLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_phanLoai);
            this.Controls.Add(this.txb_trangthai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_cafe);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Mota);
            this.Controls.Add(this.txb_tensp);
            this.Controls.Add(this.txb_masp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_cafe";
            this.Text = "frm_cafe";
            this.Load += new System.EventHandler(this.frm_cafe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_cafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_phanLoai;
        private System.Windows.Forms.TextBox txb_trangthai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dt_cafe;
        private System.Windows.Forms.Button btn_Dem;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Mota;
        private System.Windows.Forms.TextBox txb_tensp;
        private System.Windows.Forms.TextBox txb_masp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_soLuong;
    }
}