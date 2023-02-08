namespace BTH_QLCHDT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbMahang = new System.Windows.Forms.Label();
            this.lbMaDT = new System.Windows.Forms.Label();
            this.lbTenDT = new System.Windows.Forms.Label();
            this.ldSoluong = new System.Windows.Forms.Label();
            this.lbGiaban = new System.Windows.Forms.Label();
            this.tbMahang = new System.Windows.Forms.TextBox();
            this.tbMaDT = new System.Windows.Forms.TextBox();
            this.tbSoluong = new System.Windows.Forms.TextBox();
            this.tbGiaban = new System.Windows.Forms.TextBox();
            this.tbTenDT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDienthoai = new System.Windows.Forms.DataGridView();
            this.errorCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienthoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMahang
            // 
            this.lbMahang.AutoSize = true;
            this.lbMahang.Location = new System.Drawing.Point(20, 36);
            this.lbMahang.Name = "lbMahang";
            this.lbMahang.Size = new System.Drawing.Size(157, 25);
            this.lbMahang.TabIndex = 0;
            this.lbMahang.Text = "Nhập mã hãng ĐT";
            // 
            // lbMaDT
            // 
            this.lbMaDT.AutoSize = true;
            this.lbMaDT.Location = new System.Drawing.Point(21, 78);
            this.lbMaDT.Name = "lbMaDT";
            this.lbMaDT.Size = new System.Drawing.Size(112, 25);
            this.lbMaDT.TabIndex = 1;
            this.lbMaDT.Text = "Nhập mã ĐT";
            // 
            // lbTenDT
            // 
            this.lbTenDT.AutoSize = true;
            this.lbTenDT.Location = new System.Drawing.Point(21, 118);
            this.lbTenDT.Name = "lbTenDT";
            this.lbTenDT.Size = new System.Drawing.Size(112, 25);
            this.lbTenDT.TabIndex = 2;
            this.lbTenDT.Text = "Nhập tên ĐT";
            // 
            // ldSoluong
            // 
            this.ldSoluong.AutoSize = true;
            this.ldSoluong.Location = new System.Drawing.Point(21, 158);
            this.ldSoluong.Name = "ldSoluong";
            this.ldSoluong.Size = new System.Drawing.Size(131, 25);
            this.ldSoluong.TabIndex = 3;
            this.ldSoluong.Text = "Nhập số lượng";
            // 
            // lbGiaban
            // 
            this.lbGiaban.AutoSize = true;
            this.lbGiaban.Location = new System.Drawing.Point(21, 200);
            this.lbGiaban.Name = "lbGiaban";
            this.lbGiaban.Size = new System.Drawing.Size(119, 25);
            this.lbGiaban.TabIndex = 4;
            this.lbGiaban.Text = "Nhập giá bán";
            // 
            // tbMahang
            // 
            this.tbMahang.Location = new System.Drawing.Point(193, 30);
            this.tbMahang.Name = "tbMahang";
            this.tbMahang.Size = new System.Drawing.Size(254, 31);
            this.tbMahang.TabIndex = 0;
            this.tbMahang.Validating += new System.ComponentModel.CancelEventHandler(this.tbMahang_Validating);
            // 
            // tbMaDT
            // 
            this.tbMaDT.Location = new System.Drawing.Point(193, 73);
            this.tbMaDT.Name = "tbMaDT";
            this.tbMaDT.Size = new System.Drawing.Size(254, 31);
            this.tbMaDT.TabIndex = 1;
            this.tbMaDT.Validating += new System.ComponentModel.CancelEventHandler(this.tbMaDT_Validating);
            // 
            // tbSoluong
            // 
            this.tbSoluong.Location = new System.Drawing.Point(193, 153);
            this.tbSoluong.Name = "tbSoluong";
            this.tbSoluong.Size = new System.Drawing.Size(255, 31);
            this.tbSoluong.TabIndex = 3;
            this.tbSoluong.Validating += new System.ComponentModel.CancelEventHandler(this.tbSoluong_Validating);
            // 
            // tbGiaban
            // 
            this.tbGiaban.Location = new System.Drawing.Point(193, 200);
            this.tbGiaban.Name = "tbGiaban";
            this.tbGiaban.Size = new System.Drawing.Size(254, 31);
            this.tbGiaban.TabIndex = 4;
            this.tbGiaban.Validating += new System.ComponentModel.CancelEventHandler(this.tbGiaban_Validating);
            // 
            // tbTenDT
            // 
            this.tbTenDT.Location = new System.Drawing.Point(193, 114);
            this.tbTenDT.Name = "tbTenDT";
            this.tbTenDT.Size = new System.Drawing.Size(255, 31);
            this.tbTenDT.TabIndex = 2;
            this.tbTenDT.Validating += new System.ComponentModel.CancelEventHandler(this.tbTenDT_Validating);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 255);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(201, 253);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 34);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(383, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 34);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(553, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(718, 253);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDienthoai
            // 
            this.dgvDienthoai.AllowUserToAddRows = false;
            this.dgvDienthoai.AllowUserToDeleteRows = false;
            this.dgvDienthoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienthoai.Location = new System.Drawing.Point(26, 317);
            this.dgvDienthoai.Name = "dgvDienthoai";
            this.dgvDienthoai.RowHeadersWidth = 62;
            this.dgvDienthoai.RowTemplate.Height = 33;
            this.dgvDienthoai.Size = new System.Drawing.Size(1054, 382);
            this.dgvDienthoai.TabIndex = 10;
            // 
            // errorCheck
            // 
            this.errorCheck.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 711);
            this.Controls.Add(this.dgvDienthoai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbTenDT);
            this.Controls.Add(this.tbGiaban);
            this.Controls.Add(this.tbSoluong);
            this.Controls.Add(this.tbMaDT);
            this.Controls.Add(this.tbMahang);
            this.Controls.Add(this.lbGiaban);
            this.Controls.Add(this.ldSoluong);
            this.Controls.Add(this.lbTenDT);
            this.Controls.Add(this.lbMaDT);
            this.Controls.Add(this.lbMahang);
            this.Name = "Form1";
            this.Text = "Quản lý sản phẩm điện thoại";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienthoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMahang;
        private Label lbMaDT;
        private Label lbTenDT;
        private Label ldSoluong;
        private Label lbGiaban;
        private TextBox tbMahang;
        private TextBox tbMaDT;
        private TextBox tbSoluong;
        private TextBox tbGiaban;
        private TextBox tbTenDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnReset;
        private Button btnThoat;
        private DataGridView dgvDienthoai;
        private ErrorProvider errorCheck;
    }
}