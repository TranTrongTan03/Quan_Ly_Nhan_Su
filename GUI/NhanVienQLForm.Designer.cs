namespace GUI
{
    partial class NhanVienQLForm
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
            this.tbMaQL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoDt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanVienQL = new System.Windows.Forms.DataGridView();
            this.MaQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienQL)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMaQL
            // 
            this.tbMaQL.Location = new System.Drawing.Point(326, 130);
            this.tbMaQL.Name = "tbMaQL";
            this.tbMaQL.Size = new System.Drawing.Size(232, 27);
            this.tbMaQL.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "MA NHAN VIEN QL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "ĐỊA CHỈ";
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.FormattingEnabled = true;
            this.tbGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Không Xác Định"});
            this.tbGioiTinh.Location = new System.Drawing.Point(326, 289);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(232, 28);
            this.tbGioiTinh.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "GIỚI TÍNH";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(326, 400);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(232, 27);
            this.tbEmail.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "SỐ ĐIỆN THOẠI";
            // 
            // tbSoDt
            // 
            this.tbSoDt.Location = new System.Drawing.Point(326, 345);
            this.tbSoDt.Name = "tbSoDt";
            this.tbSoDt.Size = new System.Drawing.Size(232, 27);
            this.tbSoDt.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "EMAIL";
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Location = new System.Drawing.Point(326, 239);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(232, 27);
            this.tbNgaySinh.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "NGÀY SINH";
            // 
            // tbTenQL
            // 
            this.tbTenQL.Location = new System.Drawing.Point(326, 184);
            this.tbTenQL.Name = "tbTenQL";
            this.tbTenQL.Size = new System.Drawing.Size(232, 27);
            this.tbTenQL.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "TÊN NHÂN VIÊN";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(326, 453);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(232, 27);
            this.tbDiaChi.TabIndex = 51;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(627, 447);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(627, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 54;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(627, 237);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 53;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(627, 184);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanVienQL
            // 
            this.dgvNhanVienQL.AllowUserToAddRows = false;
            this.dgvNhanVienQL.AllowUserToDeleteRows = false;
            this.dgvNhanVienQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVienQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQL,
            this.TenQL,
            this.NgaySinh,
            this.GioiTinh,
            this.DienThoai,
            this.Email,
            this.DiaChi});
            this.dgvNhanVienQL.Location = new System.Drawing.Point(54, 545);
            this.dgvNhanVienQL.Name = "dgvNhanVienQL";
            this.dgvNhanVienQL.ReadOnly = true;
            this.dgvNhanVienQL.RowHeadersWidth = 51;
            this.dgvNhanVienQL.RowTemplate.Height = 29;
            this.dgvNhanVienQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVienQL.Size = new System.Drawing.Size(953, 302);
            this.dgvNhanVienQL.TabIndex = 57;
            this.dgvNhanVienQL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVienQL_Click);
            // 
            // MaQL
            // 
            this.MaQL.DataPropertyName = "MaQL";
            this.MaQL.HeaderText = "MaQl";
            this.MaQL.MinimumWidth = 6;
            this.MaQL.Name = "MaQL";
            this.MaQL.ReadOnly = true;
            this.MaQL.Width = 125;
            // 
            // TenQL
            // 
            this.TenQL.DataPropertyName = "TenQL";
            this.TenQL.HeaderText = "Tên QL";
            this.TenQL.MinimumWidth = 6;
            this.TenQL.Name = "TenQL";
            this.TenQL.ReadOnly = true;
            this.TenQL.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Số Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 125;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(747, 131);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(232, 27);
            this.tbTimKiem.TabIndex = 58;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Tìm kiếm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(420, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 35);
            this.label10.TabIndex = 61;
            this.label10.Text = "NHÂN VIÊN QUẢN LÝ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(83, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 28);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(900, 31);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(94, 58);
            this.btnDangXuat.TabIndex = 63;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // NhanVienQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 889);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.dgvNhanVienQL);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbMaQL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSoDt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenQL);
            this.Controls.Add(this.label3);
            this.Name = "NhanVienQLForm";
            this.Text = "NhanVienQLForm";
            this.Load += new System.EventHandler(this.NhanVienQLForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVienQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbMaQL;
        private Label label8;
        private Label label7;
        private ComboBox tbGioiTinh;
        private Label label2;
        private TextBox tbEmail;
        private Label label6;
        private TextBox tbSoDt;
        private Label label5;
        private TextBox tbNgaySinh;
        private Label label4;
        private TextBox tbTenQL;
        private Label label3;
        private TextBox tbDiaChi;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgvNhanVienQL;
        private DataGridViewTextBoxColumn MaQL;
        private DataGridViewTextBoxColumn TenQL;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DiaChi;
        private TextBox tbTimKiem;
        private Label label1;
        private Label label10;
        private Button btnBack;
        private Button btnDangXuat;
    }
}