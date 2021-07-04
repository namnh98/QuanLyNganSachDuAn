using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganSachDuAn.DTO
{
    public class DuanMain
    {
        public DuanMain(int ma, string ten, int tong, DateTime? bd, DateTime? kt)
        {
            this.MaDA = ma;
            this.TenDA = ten;
            this.TongCP = tong;
            this.TgianBD = bd;
            this.TgianKT = kt;
        }

        public DuanMain(DataRow rows)
        {
            this.MaDA = (int)rows["maduan"];
            this.TenDA = rows["tenduan"].ToString();
            this.TongCP = (int)rows["tongkinhphi"];
            this.TgianBD = (DateTime)rows["thoigianbatdau"];
            this.TgianKT = (DateTime)rows["thoigianketthuc"];
        }

        private DateTime? tgianKT;
        private DateTime? tgianBD;
        private int tongCP;
        private string tenDA;
        private int maDA;

        public int MaDA { get => maDA; set => maDA = value; }
        public string TenDA { get => tenDA; set => tenDA = value; }
        public int TongCP { get => tongCP; set => tongCP = value; }
        public DateTime? TgianBD { get => tgianBD; set => tgianBD = value; }
        public DateTime? TgianKT { get => tgianKT; set => tgianKT = value; }
    }
}
