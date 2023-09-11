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
    public partial class ThongKe : Form
    {
        private readonly AppDbContext context;
        public ThongKe()
        {
            context = new AppDbContext();
            InitializeComponent();
        }

        private void btnTroVeCuaCTPP_Click(object sender, EventArgs e)
        {
            ManHinhChinh frm = new ManHinhChinh();
            frm.Show();
            this.Hide();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            List<HoaDon> listhd = context.HoaDons.ToList();
          
            chart1.Series["Tổng Tiền"].XValueMember = "HoaDon.TongTien";
            chart1.Series["Tổng Tiền"].YValueMembers= "HoaDon.NgayHD.Month";
            chart1.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
