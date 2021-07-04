using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganSachDuAn.DTO
{
    public class Duan
    {
        public Duan(int ma,string tenda,DateTime? tgbd, DateTime? tgkt,int tongcp,string tencp,DateTime? tgThang,string cpChi,string cpluyke)
        {
            this.MaDuan = ma;
            this.TenDuan = tenda;
            this.TgianBD = tgbd;
            this.TgianKT = tgkt;
            this.TongCP = tongcp;
            this.TenCP = tencp;
            this.TgianThang = tgThang;
            this.CpChi = cpChi;
            this.CpLuyke = cpluyke;
        }

        public Duan(DataRow rows)
        {
            this.MaDuan = (int)rows["maduan"];
            this.TenDuan = rows["tenduan"].ToString();
            this.TgianBD = (DateTime?)rows["thoigianbatdau"];
            this.TgianKT = (DateTime?)rows["thoigianketthuc"];
            this.TongCP = (int)rows["tongkinhphi"];
            this.TenCP = rows["tenchiphi"].ToString();
            this.TgianThang = (DateTime?)rows["thoigian"];
            this.CpChi = rows["tienchi1thang"].ToString();
            this.CpLuyke = rows["luyke"].ToString();
        }

        private string cpLuyke;
        private string cpChi;
        private DateTime? tgianThang;
        private string tenCP;
        private int tongCP;
        private DateTime? tgianKT;
        private DateTime? tgianBD;
        private string tenDuan;
        private int maDuan;

        public int MaDuan { get => maDuan; set => maDuan = value; }
        public string TenDuan { get => tenDuan; set => tenDuan = value; }
        public DateTime? TgianBD { get => tgianBD; set => tgianBD = value; }
        public DateTime? TgianKT { get => tgianKT; set => tgianKT = value; }
        public int TongCP { get => tongCP; set => tongCP = value; }
        public string TenCP { get => tenCP; set => tenCP = value; }
        public DateTime? TgianThang { get => tgianThang; set => tgianThang = value; }
        public string CpChi { get => cpChi; set => cpChi = value; }
        public string CpLuyke { get => cpLuyke; set => cpLuyke = value; }
    }
}
