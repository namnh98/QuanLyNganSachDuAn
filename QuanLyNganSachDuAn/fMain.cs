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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            GetProject();
        }

        void GetProject()
        {
            dtgvThongKeDuAn.DataSource = DuanDAO.Instance.GetProject();
            txbMaDA.DataBindings.Clear();
            txbMaDA.DataBindings.Add(new Binding("Text", dtgvThongKeDuAn.DataSource, "maduan"));
            txbtenDA.DataBindings.Clear();
            txbtenDA.DataBindings.Add(new Binding("Text", dtgvThongKeDuAn.DataSource, "tenduan"));
            txbtongchiphi.DataBindings.Clear();
            txbtongchiphi.DataBindings.Add(new Binding("Text", dtgvThongKeDuAn.DataSource, "tongcp"));
            txbtenchiphi.DataBindings.Clear();
            txbtenchiphi.DataBindings.Add(new Binding("Text", dtgvThongKeDuAn.DataSource, "tencp"));
            txbtienchi.DataBindings.Clear();
            txbtienchi.DataBindings.Add(new Binding("Text",dtgvThongKeDuAn.DataSource,"cpchi"));
            txbluyke.DataBindings.Clear();
            txbluyke.DataBindings.Add(new Binding("Text", dtgvThongKeDuAn.DataSource, "cpluyke"));
            dtpkTgianbatdau.DataBindings.Clear();
            dtpkTgianbatdau.DataBindings.Add(new Binding("Text", dtgvThongKeDuAn.DataSource, "tgianbd"));
            dtpkTgianketthuc.DataBindings.Clear();
            dtpkTgianketthuc.DataBindings.Add(new Binding("Text", dtgvThongKeDuAn.DataSource, "tgiankt"));
            dtpktgianThang.DataBindings.Clear();
            dtpktgianThang.DataBindings.Add(new Binding("Text",dtgvThongKeDuAn.DataSource,"tgianthang"));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GetProject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            fManager ma = new fManager();
            this.Hide();
            ma.ShowDialog();
            this.Show();
        }
    }
}
