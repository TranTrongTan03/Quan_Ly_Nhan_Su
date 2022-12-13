namespace GUI
{
    partial class CongViecForm
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
            this.tbTenCongViec = new System.Windows.Forms.TextBox();
            this.tbMaCongViec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDanhSachCongViec = new System.Windows.Forms.DataGridView();
            this.MaCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý công việc";
            // 
            // tbTenCongViec
            // 
            this.tbTenCongViec.Location = new System.Drawing.Point(152, 107);
            this.tbTenCongViec.Name = "tbTenCongViec";
            this.tbTenCongViec.Size = new System.Drawing.Size(164, 27);
            this.tbTenCongViec.TabIndex = 10;
            // 
            // tbMaCongViec
            // 
            this.tbMaCongViec.Location = new System.Drawing.Point(154, 59);
            this.tbMaCongViec.Name = "tbMaCongViec";
            this.tbMaCongViec.Size = new System.Drawing.Size(164, 27);
            this.tbMaCongViec.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên công việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã công việc";
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(506, 79);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(164, 27);
            this.tbTim.TabIndex = 12;
            this.tbTim.TextChanged += new System.EventHandler(this.tbTim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm";
            // 
            // dgvDanhSachCongViec
            // 
            this.dgvDanhSachCongViec.AllowUserToAddRows = false;
            this.dgvDanhSachCongViec.AllowUserToDeleteRows = false;
            this.dgvDanhSachCongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCongViec,
            this.TenCongViec});
            this.dgvDanhSachCongViec.Location = new System.Drawing.Point(405, 126);
            this.dgvDanhSachCongViec.Name = "dgvDanhSachCongViec";
            this.dgvDanhSachCongViec.ReadOnly = true;
            this.dgvDanhSachCongViec.RowHeadersWidth = 51;
            this.dgvDanhSachCongViec.RowTemplate.Height = 29;
            this.dgvDanhSachCongViec.Size = new System.Drawing.Size(371, 244);
            this.dgvDanhSachCongViec.TabIndex = 13;
            this.dgvDanhSachCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachCongViec_CellClick);
            // 
            // MaCongViec
            // 
            this.MaCongViec.DataPropertyName = "MaCongViec";
            this.MaCongViec.HeaderText = "Mã công việc";
            this.MaCongViec.MinimumWidth = 6;
            this.MaCongViec.Name = "MaCongViec";
            this.MaCongViec.ReadOnly = true;
            // 
            // TenCongViec
            // 
            this.TenCongViec.DataPropertyName = "TenCongViec";
            this.TenCongViec.HeaderText = "Tên công việc ";
            this.TenCongViec.MinimumWidth = 6;
            this.TenCongViec.Name = "TenCongViec";
            this.TenCongViec.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(29, 154);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(154, 154);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(280, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 27);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(694, 9);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(94, 58);
            this.btnDangXuat.TabIndex = 18;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // CongViecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSachCongViec);
            this.Controls.Add(this.tbTim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTenCongViec);
            this.Controls.Add(this.tbMaCongViec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CongViecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Việc";
            this.Load += new System.EventHandler(this.CongViecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCongViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbTenCongViec;
        private TextBox tbMaCongViec;
        private Label label3;
        private Label label2;
        private TextBox tbTim;
        private Label label4;
        private DataGridView dgvDanhSachCongViec;
        private DataGridViewTextBoxColumn MaCongViec;
        private DataGridViewTextBoxColumn TenCongViec;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnBack;
        private Button btnDangXuat;
    }
}