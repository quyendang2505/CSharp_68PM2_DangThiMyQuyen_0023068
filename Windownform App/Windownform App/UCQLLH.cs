using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windownform_App
{
    public partial class UCQLLH : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();

        public UCQLLH()
        {
            InitializeComponent();
            dgv_dSLH.CellClick += dgv_dSLH_CellClick;
        }
        private void dgv_dSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_dSLH.Rows[e.RowIndex];
                textBox1.Text = row.Cells["id"].Value?.ToString();
                textBox2.Text = row.Cells["malop"].Value?.ToString();
                textBox3.Text = row.Cells["tenlop"].Value?.ToString();
                textBox4.Text = row.Cells["ghichu"].Value?.ToString();
            }
        }
        private void UCQLLH_Load(object sender, EventArgs e)
        {
          
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList();
            dgv_dSLH.DataSource = dSLH;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng chọn một lớp học trên bảng trước!");
                return;
            }

            string maLop = textBox2.Text;
            var students = db.tbl_sinhviens.Where(s => s.malop == maLop).Select(s => new {
                s.id,
                s.hoten,
                s.gioitinh,
                s.ngaysinh
            }).ToList();

            if (students.Count == 0)
            {
                MessageBox.Show($"Lớp {maLop} hiện tại chưa có sinh viên.");
                return;
            }

            Form frmSV = new Form();
            frmSV.Text = "Danh sách sinh viên lớp: " + maLop;
            frmSV.Size = new Size(600, 400);
            frmSV.StartPosition = FormStartPosition.CenterParent;

            DataGridView dgv = new DataGridView();
            dgv.DataSource = students;
            dgv.Dock = DockStyle.Fill;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;

            frmSV.Controls.Add(dgv);
            frmSV.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_lophoc lh = new tbl_lophoc();
                lh.malop = textBox2.Text;
                lh.tenlop = textBox3.Text;
                lh.ghichu = textBox4.Text;

                db.tbl_lophocs.InsertOnSubmit(lh);
                db.SubmitChanges();
                MessageBox.Show("Thêm lớp học thành công!");
                // Gọi hàm load dữ liệu của bạn, giả sử là LoadData() hoặc gọi lại list
                List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList();
                dgv_dSLH.DataSource = dSLH;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            int id = int.Parse(textBox1.Text);
            var lh = db.tbl_lophocs.FirstOrDefault(l => l.id == id);

            if (lh != null)
            {
                lh.malop = textBox2.Text;
                lh.tenlop = textBox3.Text;
                lh.ghichu = textBox4.Text;

                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!");
                dgv_dSLH.DataSource = db.tbl_lophocs.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            int id = int.Parse(textBox1.Text);
            var lh = db.tbl_lophocs.FirstOrDefault(l => l.id == id);

            if (lh != null)
            {
                if (lh.tbl_sinhviens.Any())
                {
                    MessageBox.Show("Không thể xóa lớp này vì đang có sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.tbl_lophocs.DeleteOnSubmit(lh);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công!");
                    dgv_dSLH.DataSource = db.tbl_lophocs.ToList();
                }
            }
        }
    }
}
