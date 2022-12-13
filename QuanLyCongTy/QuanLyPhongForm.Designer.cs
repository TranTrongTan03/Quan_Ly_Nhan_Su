namespace GUI
{
    partial class QuanLyPhongForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaPhong = new System.Windows.Forms.TextBox();
            this.tbSoNhanVien = new System.Windows.Forms.TextBox();
            this.tbTruongPhong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruongPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaQuanLy = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phòng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trưởng phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã quản lý";
            // 
            // tbMaPhong
            // 
            this.tbMaPhong.Location = new System.Drawing.Point(169, 53);
            this.tbMaPhong.Name = "tbMaPhong";
            this.tbMaPhong.Size = new System.Drawing.Size(164, 27);
            this.tbMaPhong.TabIndex = 5;
            // 
            // tbSoNhanVien
            // 
            this.tbSoNhanVien.Location = new System.Drawing.Point(169, 106);
            this.tbSoNhanVien.Name = "tbSoNhanVien";
            this.tbSoNhanVien.Size = new System.Drawing.Size(164, 27);
            this.tbSoNhanVien.TabIndex = 6;
            // 
            // tbTruongPhong
            // 
            this.tbTruongPhong.Location = new System.Drawing.Point(169, 162);
            this.tbTruongPhong.Name = "tbTruongPhong";
            this.tbTruongPhong.Size = new System.Drawing.Size(164, 27);
            this.tbTruongPhong.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 286);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(125, 286);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(239, 286);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDanhSachPhong
            // 
            this.dgvDanhSachPhong.AllowUserToAddRows = false;
            this.dgvDanhSachPhong.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.SoNV,
            this.TruongPhong,
            this.NVQuanLy});
            this.dgvDanhSachPhong.Location = new System.Drawing.Point(360, 125);
            this.dgvDanhSachPhong.Name = "dgvDanhSachPhong";
            this.dgvDanhSachPhong.ReadOnly = true;
            this.dgvDanhSachPhong.RowHeadersWidth = 51;
            this.dgvDanhSachPhong.RowTemplate.Height = 29;
            this.dgvDanhSachPhong.Size = new System.Drawing.Size(586, 313);
            this.dgvDanhSachPhong.TabIndex = 12;
            this.dgvDanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhong_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // SoNV
            // 
            this.SoNV.DataPropertyName = "SoNV";
            this.SoNV.HeaderText = "Số nhân viên";
            this.SoNV.MinimumWidth = 6;
            this.SoNV.Name = "SoNV";
            this.SoNV.ReadOnly = true;
            // 
            // TruongPhong
            // 
            this.TruongPhong.DataPropertyName = "TruongPhong";
            this.TruongPhong.HeaderText = "Trưởng phòng";
            this.TruongPhong.MinimumWidth = 6;
            this.TruongPhong.Name = "TruongPhong";
            this.TruongPhong.ReadOnly = true;
            // 
            // NVQuanLy
            // 
            this.NVQuanLy.DataPropertyName = "NVQuanLy";
            this.NVQuanLy.HeaderText = "Mã quản lý";
            this.NVQuanLy.MinimumWidth = 6;
            this.NVQuanLy.Name = "NVQuanLy";
            this.NVQuanLy.ReadOnly = true;
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(575, 81);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(224, 27);
            this.tbTim.TabIndex = 14;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tìm";
            // 
            // cbbMaQuanLy
            // 
            this.cbbMaQuanLy.FormattingEnabled = true;
            this.cbbMaQuanLy.Location = new System.Drawing.Point(169, 226);
            this.cbbMaQuanLy.Name = "cbbMaQuanLy";
            this.cbbMaQuanLy.Size = new System.Drawing.Size(164, 28);
            this.cbbMaQuanLy.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 27);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(852, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(94, 58);
            this.btnDangXuat.TabIndex = 17;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // QuanLyPhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbbMaQuanLy);
            this.Controls.Add(this.tbTim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDanhSachPhong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbTruongPhong);
            this.Controls.Add(this.tbSoNhanVien);
            this.Controls.Add(this.tbMaPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyPhongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyPhongForm";
            this.Load += new System.EventHandler(this.QuanLyPhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbMaPhong;
        private TextBox tbSoNhanVien;
        private TextBox tbTruongPhong;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvDanhSachPhong;
        private TextBox tbTim;
        private Label label6;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn SoNV;
        private DataGridViewTextBoxColumn TruongPhong;
        private DataGridViewTextBoxColumn NVQuanLy;
        private ComboBox cbbMaQuanLy;
        private Button btnBack;
        private Button btnDangXuat;
    }
}