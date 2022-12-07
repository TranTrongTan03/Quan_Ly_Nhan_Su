namespace QuanLyNhanSu
{
    partial class QuanLyForm
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
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(100, 54);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(200, 150);
            this.btnQuanLyTaiKhoan.TabIndex = 0;
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(495, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 150);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 150);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 150);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQuanLyTaiKhoan);
            this.Name = "QuanLyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnQuanLyTaiKhoan;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}