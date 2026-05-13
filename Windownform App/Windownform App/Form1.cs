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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_tendangnhap_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu người dng nhập vào
            string username = txt_tendangnhap.Text.Trim();
            string password = txt_matkhau.Text.Trim();

            // Kiểm tra điều kiện: Tên đăng nhập là email, mật khẩu là MSSV
            if (username == "dangthimyquyen1970@gmail.com" && password == "0023068")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
