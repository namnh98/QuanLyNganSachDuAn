using QuanLyNganSachDuAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNganSachDuAn
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            GetManagerProject();
        }

        private void btnGobackMain_Click(object sender, EventArgs e)
        {
            fMain main = new fMain();
            this.Hide();
        }

        private void btnXemDA_ma_Click(object sender, EventArgs e)
        {
            GetManagerProject();
        }

        void GetManagerProject()
        {
            dtgvTKDA_ma.DataSource = DuanMainDAO.Instance.GetProject();
            txbMaDA_ma.DataBindings.Clear();
            txbMaDA_ma.DataBindings.Add(new Binding("Text",dtgvTKDA_ma.DataSource,"mada"));
            txbtenDA_ma.DataBindings.Clear();
            txbtenDA_ma.DataBindings.Add(new Binding("Text", dtgvTKDA_ma.DataSource, "tenda"));
            txbTongCP_ma.DataBindings.Clear();
            txbTongCP_ma.DataBindings.Add(new Binding("Text",dtgvTKDA_ma.DataSource,"tongcp"));
            dtpkTgianBD_ma.DataBindings.Clear();
            dtpkTgianBD_ma.DataBindings.Add(new Binding("Text",dtgvTKDA_ma.DataSource,"tgianbd"));
            dtpkTgianKT_ma.DataBindings.Clear();
            dtpkTgianKT_ma.DataBindings.Add(new Binding("Text", dtgvTKDA_ma.DataSource, "tgiankt"));
        }

        private void btnThemDA_ma_Click(object sender, EventArgs e)
        {
            if (DuanMainDAO.Instance.AddProject(txbtenDA_ma.Text, int.Parse(txbTongCP_ma.Text), dtpkTgianBD_ma.Text, dtpkTgianKT_ma.Text))
            {
                MessageBox.Show("Thêm thành công");
                GetManagerProject();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm !");
            }
        }

        private void btnSuaDA_ma_Click(object sender, EventArgs e)
        {
            if (DuanMainDAO.Instance.UpdateProject(txbtenDA_ma.Text, int.Parse(txbTongCP_ma.Text), dtpkTgianBD_ma.Text, dtpkTgianKT_ma.Text, int.Parse(txbMaDA_ma.Text)))
            {
                MessageBox.Show("Sửa dự án "+txbTenCP_ma.Text+" thành công");
                GetManagerProject();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm !");
            }
        }

        private void btnXoaDA_ma_Click(object sender, EventArgs e)
        {
            if (DuanMainDAO.Instance.DeleteProject(int.Parse(txbMaDA_ma.Text)))
            {
                MessageBox.Show("Xóa dự án " + txbTenCP_ma.Text + " thành công");
                GetManagerProject();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm !");
            }
        }
    }
}
