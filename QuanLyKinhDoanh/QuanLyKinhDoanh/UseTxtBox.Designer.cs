using System.Data;

namespace QuanLyKinhDoanh
{
    partial class UseTxtBox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblMaKH = new Label();
            lblTenKhach = new Label();
            lblDiaChi = new Label();
            txtMaKH = new TextBox(); // Thay cboMaKH thành txtMaKH
            txtTenKhach = new TextBox();
            txtDiaChi = new TextBox();
            dataGridViewKetQua = new DataGridView();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            btnFind = new Button();
            btnClose = new Button();
            panelTitle = new Panel();
            panelCustomerInfo = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKetQua).BeginInit();
            panelTitle.SuspendLayout();
            panelCustomerInfo.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Black;
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(201, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(361, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THEO DỖI KINH DOANH";
            // 
            // lblMaKH
            // 
            lblMaKH.BackColor = Color.Black;
            lblMaKH.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblMaKH.ForeColor = Color.White;
            lblMaKH.Location = new Point(53, 8);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(68, 31);
            lblMaKH.TabIndex = 1;
            lblMaKH.Text = "MAKH";
            lblMaKH.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenKhach
            // 
            lblTenKhach.BackColor = Color.Black;
            lblTenKhach.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTenKhach.ForeColor = Color.White;
            lblTenKhach.Location = new Point(345, 8);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(119, 30);
            lblTenKhach.TabIndex = 2;
            lblTenKhach.Text = "TENKHACH";
            lblTenKhach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiaChi
            // 
            lblDiaChi.BackColor = Color.Black;
            lblDiaChi.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDiaChi.ForeColor = Color.White;
            lblDiaChi.Location = new Point(235, 69);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(75, 30);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "DIACHI";
            lblDiaChi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaKH
            // 
            txtMaKH.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtMaKH.Location = new Point(127, 8);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(150, 30);
            txtMaKH.TabIndex = 0;
            txtMaKH.BorderStyle = BorderStyle.FixedSingle;
            // 
            // txtTenKhach
            // 
            txtTenKhach.BackColor = Color.White;
            txtTenKhach.BorderStyle = BorderStyle.FixedSingle;
            txtTenKhach.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtTenKhach.Location = new Point(470, 8);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.ReadOnly = true;
            txtTenKhach.Size = new Size(227, 30);
            txtTenKhach.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.White;
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtDiaChi.Location = new Point(316, 69);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(260, 30);
            txtDiaChi.TabIndex = 3;
            // 
            // dataGridViewKetQua
            // 
            dataGridViewKetQua.BackgroundColor = Color.White;
            dataGridViewKetQua.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewKetQua.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewKetQua.EnableHeadersVisualStyles = false;
            dataGridViewKetQua.Location = new Point(28, 123);
            dataGridViewKetQua.Name = "dataGridViewKetQua";
            dataGridViewKetQua.RowHeadersWidth = 51;
            dataGridViewKetQua.Size = new Size(704, 276);
            dataGridViewKetQua.TabIndex = 5;
            // 
            // lblTongTien
            // 
            lblTongTien.BackColor = Color.Black;
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.ForeColor = Color.White;
            lblTongTien.Location = new Point(433, 459);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(81, 30);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng tiền: ";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.BorderStyle = BorderStyle.FixedSingle;
            txtTongTien.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtTongTien.Location = new Point(520, 459);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(181, 30);
            txtTongTien.TabIndex = 3;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.White;
            btnFind.FlatAppearance.BorderColor = Color.Black;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ForeColor = Color.Black;
            btnFind.Location = new Point(235, 31);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 33);
            btnFind.TabIndex = 7;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderColor = Color.Black;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(439, 31);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 33);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelTitle
            // 
            panelTitle.BorderStyle = BorderStyle.FixedSingle;
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Location = new Point(12, 10);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(766, 64);
            panelTitle.TabIndex = 0;
            // 
            // panelCustomerInfo
            // 
            panelCustomerInfo.BorderStyle = BorderStyle.FixedSingle;
            panelCustomerInfo.Controls.Add(dataGridViewKetQua);
            panelCustomerInfo.Controls.Add(lblMaKH);
            panelCustomerInfo.Controls.Add(lblDiaChi);
            panelCustomerInfo.Controls.Add(txtMaKH); // Thay cboMaKH thành txtMaKH
            panelCustomerInfo.Controls.Add(txtDiaChi);
            panelCustomerInfo.Controls.Add(txtTenKhach);
            panelCustomerInfo.Controls.Add(lblTongTien);
            panelCustomerInfo.Controls.Add(lblTenKhach);
            panelCustomerInfo.Controls.Add(txtTongTien);
            panelCustomerInfo.Location = new Point(12, 73);
            panelCustomerInfo.Name = "panelCustomerInfo";
            panelCustomerInfo.Size = new Size(766, 499);
            panelCustomerInfo.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.BorderStyle = BorderStyle.FixedSingle;
            panelButtons.Controls.Add(btnFind);
            panelButtons.Controls.Add(btnClose);
            panelButtons.Location = new Point(12, 569);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(766, 109);
            panelButtons.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 697);
            Controls.Add(panelCustomerInfo);
            Controls.Add(panelTitle);
            Controls.Add(panelButtons);
            Name = "Form1";
            Text = "THEO DỖI KINH DOANH";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKetQua).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelCustomerInfo;
        private System.Windows.Forms.Panel panelButtons;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH; // Thay cboMaKH thành txtMaKH

        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;

        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;

        private System.Windows.Forms.DataGridView dataGridViewKetQua;

        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
    }
}