using DoAn_KHMT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_KHMT
{
    public partial class DangNhap : Form
    {
        private readonly AppDbContext context;
        public DangNhap()
        {
            context = new AppDbContext();   
            InitializeComponent();         
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCheckPass_MouseDown(object sender, MouseEventArgs e)
        {
            
                txtPassword.UseSystemPasswordChar=true;
            
        }

        private void btnCheckPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Tên đăng nhập")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Tên đăng nhập";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string User = txtUser.Text;
            string Password = txtPassword.Text;

            var checktk = context.MatKhaus.FirstOrDefault(x => x.username == User);

            if (checktk != null)
            {
                if (checktk.password == Password)
                {
                    ManHinhChinh frm = new ManHinhChinh();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void lblChuaCoTaiKhoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dang update !");
        }

        private void btnCheckPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
