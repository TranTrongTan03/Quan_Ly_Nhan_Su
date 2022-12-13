namespace GUI
{
    partial class PhanCongForm
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
            this.tbMaQuanLy = new System.Windows.Forms.TextBox();
            this.dgvDanhSachPhanCong = new System.Windows.Forms.DataGridView();
            this.MaQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã quản lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã công việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã phòng";
            // 
            // tbMaQuanLy
            // 
            this.tbMaQuanLy.Location = new System.Drawing.Point(126, 66);
            this.tbMaQuanLy.Name = "tbMaQuanLy";
            this.tbMaQuanLy.Size = new System.Drawing.Size(224, 27);
            this.tbMaQuanLy.TabIndex = 4;
            // 
            // dgvDanhSachPhanCong
            // 
            this.dgvDanhSachPhanCong.AllowUserToAddRows = false;
            this.dgvDanhSachPhanCong.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuanLy,
            this.MaCongViec,
            this.MaPhong});
            this.dgvDanhSachPhanCong.Location = new System.Drawing.Point(374, 112);
            this.dgvDanhSachPhanCong.Name = "dgvDanhSachPhanCong";
            this.dgvDanhSachPhanCong.ReadOnly = true;
            this.dgvDanhSachPhanCong.RowHeadersWidth = 51;
            this.dgvDanhSachPhanCong.RowTemplate.Height = 29;
            this.dgvDanhSachPhanCong.Size = new System.Drawing.Size(414, 308);
            this.dgvDanhSachPhanCong.TabIndex = 7;
            // 
            // MaQuanLy
            // 
            this.MaQuanLy.DataPropertyName = "MaQuanLy";
            this.MaQuanLy.HeaderText = "Mã Quản Lý";
            this.MaQuanLy.MinimumWidth = 6;
            this.MaQuanLy.Name = "MaQuanLy";
            this.MaQuanLy.ReadOnly = true;
            // 
            // MaCongViec
            // 
            this.MaCongViec.DataPropertyName = "MaCongViec";
            this.MaCongViec.HeaderText = "Mã Công Việc";
            this.MaCongViec.MinimumWidth = 6;
            this.MaCongViec.Name = "MaCongViec";
            this.MaCongViec.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // tbTim
            // 
            this.tbTim.Location = new System.Drawing.Point(526, 67);
            this.tbTim.Name = "tbTim";
            this.tbTim.Size = new System.Drawing.Size(224, 27);
            this.tbTim.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 215);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(140, 215);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(256, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CV001",
            "CV002",
            "CV003",
            "CV004",
            "CV005",
            "CV006",
            "CV007",
            "CV008"});
            this.comboBox1.Location = new System.Drawing.Point(123, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "P001",
            "P002",
            "P003",
            "P004",
            "P005",
            "P006"});
            this.comboBox2.Location = new System.Drawing.Point(123, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // PhanCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDanhSachPhanCong);
            this.Controls.Add(this.tbMaQuanLy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhanCongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanCongForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMaQuanLy;
        private DataGridView dgvDanhSachPhanCong;
        private DataGridViewTextBoxColumn MaQuanLy;
        private DataGridViewTextBoxColumn MaCongViec;
        private DataGridViewTextBoxColumn MaPhong;
        private TextBox tbTim;
        private Label label5;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}