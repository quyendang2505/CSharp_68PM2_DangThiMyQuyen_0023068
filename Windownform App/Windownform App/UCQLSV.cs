using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class UCQLSV : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public UCQLSV()
        {
            InitializeComponent();
            dgv_DSSV.CellClick += dgv_DSSV_CellClick;
        }
        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DSSV.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells["id"].Value?.ToString();
                txt_hoten.Text = row.Cells["hoten"].Value?.ToString();
                cbo_gioitinh.Text = row.Cells["gioitinh"].Value?.ToString();

                if (row.Cells["ngaysinh"].Value != null)
                    dt_ngaysinh.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);

                cbo_lop.SelectedValue = row.Cells["malop"].Value?.ToString();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCQLSV_Load(object sender, EventArgs e)
        {
            List<tbl_sinhvien> dSSV = db.tbl_sinhviens.ToList();
            dgv_DSSV.DataSource = dSSV;
                        LoadData4LH();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (cbo_lop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học trước khi thêm!");
                return;
            }
            int mSSV = int.Parse(txtMSSV.Text);
            String HoTen = txt_hoten.Text;
            string gioiTinh = cbo_gioitinh.Text;
            string ngaySinh = dt_ngaysinh.Text;
            tbl_sinhvien sinhvien = new tbl_sinhvien();
            sinhvien.id = mSSV;
            sinhvien.hoten = HoTen;
            sinhvien.gioitinh = gioiTinh;
            sinhvien.ngaysinh = DateTime.Parse(ngaySinh);
            sinhvien.malop = cbo_lop.SelectedValue.ToString();
            try
            {
                db.tbl_sinhviens.InsertOnSubmit(sinhvien);
                db.SubmitChanges();
                MessageBox.Show("Them moi sinh vien thanh cong");
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }
        public void LoadData()
        {
            List<tbl_sinhvien> dSSV = db.tbl_sinhviens.ToList();
            dgv_DSSV.DataSource = dSSV;
        }
        public void LoadData4LH()
        {
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList();
            cbo_lop.DataSource = dSLH;
            cbo_lop.DisplayMember = "tenlop";
            cbo_lop.ValueMember = "malop";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbo_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text)) return;

            int id = int.Parse(txtMSSV.Text);
            var sv = db.tbl_sinhviens.FirstOrDefault(s => s.id == id);

            if (sv != null)
            {
                sv.hoten = txt_hoten.Text;
                sv.gioitinh = cbo_gioitinh.Text;
                sv.ngaysinh = dt_ngaysinh.Value;
                sv.malop = cbo_lop.SelectedValue.ToString();

                db.SubmitChanges();
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadData(); // Gọi lại hàm load dữ liệu
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text)) return;

            int id = int.Parse(txtMSSV.Text);
            var sv = db.tbl_sinhviens.FirstOrDefault(s => s.id == id);

            if (sv != null)
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    db.tbl_sinhviens.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadData(); // Gọi lại hàm load dữ liệu

                    txtMSSV.Clear();
                    txt_hoten.Clear();
                }
            }
    }
}
