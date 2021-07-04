using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganSachDuAn.DTO
{
    public class Chiphi
    {
        public Chiphi(int ma,string ten)
        {
            this.MaCP = ma;
            this.TenCP = ten;
        }

        public Chiphi(DataRow rows)
        {
            this.MaCP = (int)rows["machiphi"];
            this.TenCP = rows["tenchiphi"].ToString();
        }

        private string tenCP;
        private int maCP;

        public int MaCP { get => maCP; set => maCP = value; }
        public string TenCP { get => tenCP; set => tenCP = value; }
    }
}
