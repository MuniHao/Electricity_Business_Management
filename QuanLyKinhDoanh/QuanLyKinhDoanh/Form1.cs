﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKinhDoanh
{
    public partial class Form1 : Form
    {
        //private string connectionString = "Server=.;Database=QuanLyDien;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            LoadMaKH();
        }
        private void LoadMaKH()
        {
            try
               {
                clsDatabase.OpenConnection();
                string query = "SELECT MAKH FROM KHACHHANG ORDER BY MAKH";
                SqlDataAdapter adapter = new SqlDataAdapter(query, clsDatabase.con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboMaKH.DataSource = dt;
                cboMaKH.DisplayMember = "MAKH";
                cboMaKH.ValueMember = "MAKH";
                cboMaKH.SelectedIndex = -1; // Không chọn mặc định
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách MAKH: " + ex.Message);
            }
            
        }

        // Truy vấn và trả về dữ liệu từ cơ sở dữ liệu
        private (DataTable dt, decimal tongTien) GetData(string maKH)
        {
            DataTable dt = new DataTable();
            decimal tongTien = 0;

            {
                try
                {
                    clsDatabase.OpenConnection();
                    // Cập nhật THANHTIEN trong bảng CHITIET
                    string updateQuery = @"
                        UPDATE CHITIET
                        SET THANHTIEN = CHITIET.SOKW * SUDUNG.DONGIA
                        FROM CHITIET
                        JOIN SUDUNG ON CHITIET.MASD = SUDUNG.MASD";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, clsDatabase.con);
                    updateCmd.ExecuteNonQuery();

                    // Truy vấn dữ liệu theo MAKH được chọn
                    string selectQuery = @"
                        SELECT KH.MAKH, KH.TENKHACH, KH.DIACHI, CT.MASD, SD.LOAISD, CT.SOKW, SD.DONGIA, CT.THANHTIEN
                        FROM KHACHHANG KH
                        JOIN CHITIET CT ON KH.MAKH = CT.MAKH
                        JOIN SUDUNG SD ON CT.MASD = SD.MASD
                        WHERE KH.MAKH = @MaKH";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, clsDatabase.con);
                    selectCmd.Parameters.AddWithValue("@MaKH", maKH);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);
                    adapter.Fill(dt);

                    // Tính tổng tiền
                    string sumQuery = @"
                        SELECT SUM(THANHTIEN) AS TongTien
                        FROM CHITIET
                        WHERE MAKH = @MaKH";
                    SqlCommand sumCmd = new SqlCommand(sumQuery, clsDatabase.con);
                    sumCmd.Parameters.AddWithValue("@MaKH", maKH);
                    object result = sumCmd.ExecuteScalar();
                    tongTien = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    clsDatabase.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            return (dt, tongTien);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cboMaKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã khách hàng!");
                return;
            }
            string maKH = cboMaKH.SelectedValue.ToString();
            var (dt, tongTien) = GetData(maKH);
            DisplayData(dt, tongTien, maKH); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Phương thức hiển thị dữ liệu lên giao diện
        public void DisplayData(DataTable dt, decimal tongTien, string selectedMaKH)
        {
            if (dt.Rows.Count > 0)
            {
                // Hiển thị MAKH, TENKHACH, DIACHI vào các TextBox
                txtTenKhach.Text = dt.Rows[0]["TENKHACH"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();

                // Loại bỏ các cột không cần thiết khỏi DataGridView
                DataTable dtGrid = dt.Copy();
                dtGrid.Columns.Remove("MAKH");
                dtGrid.Columns.Remove("TENKHACH");
                dtGrid.Columns.Remove("DIACHI");

                // Hiển thị dữ liệu trong DataGridView
                dataGridViewKetQua.DataSource = dtGrid;

                // Đặt tiêu đề cột
                dataGridViewKetQua.Columns["MASD"].HeaderText = "Mã sử dụng";
                dataGridViewKetQua.Columns["LOAISD"].HeaderText = "Loại sử dụng";
                dataGridViewKetQua.Columns["SOKW"].HeaderText = "Số KW";
                dataGridViewKetQua.Columns["DONGIA"].HeaderText = "Đơn giá";
                dataGridViewKetQua.Columns["THANHTIEN"].HeaderText = "Thành tiền";

                // Hiển thị tổng tiền
                //lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0");
                txtTongTien.Text = tongTien.ToString("N0");
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cho khách hàng: " + selectedMaKH);
                ClearForm();
            }
        }

        // Xóa dữ liệu trên form
        public void ClearForm()
        {
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            dataGridViewKetQua.DataSource = null;
            lblTongTien.Text = "Tổng tiền: 0";
        }
    }
}