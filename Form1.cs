using System;
using System.Windows.Forms;

namespace BT02_ThongTin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string ngayThangNam = $"{dateTimePicker1.Value.Day}/{dateTimePicker1.Value.Month}/{dateTimePicker1.Value.Year}";

            string show = tbHovaTen.Text
                + "\r\n" + ngayThangNam
                + "\r\n" + tbSoThich.Text;
            textBox1.Text = show;
        }

        private void lbSothich_Click(object sender, EventArgs e)
        {
            tbSoThich.Text = "Hát, Thể Thao, Xem Phim";
        }

        private void lbHoVaTen_Click(object sender, EventArgs e)
        {
            tbHovaTen.Text = "Nguyen Van A";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
