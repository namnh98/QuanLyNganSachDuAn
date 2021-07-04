using QuanLyNganSachDuAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganSachDuAn.DAO
{
    public class ChiphiDAO
    {
        private static ChiphiDAO instance;

        public static ChiphiDAO Instance
        {
            get { if (instance == null) instance = new ChiphiDAO(); return ChiphiDAO.instance; }
            private set { ChiphiDAO.instance = value; }
        }

        private ChiphiDAO() { }

        public List<Chiphi> GetChiPhi()
        {
            List<Chiphi> listda = new List<Chiphi>();

            string query = "select * from chiphiduan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Chiphi da = new Chiphi(item);
                listda.Add(da);
            }

            return listda;
        }

        public bool AddFee(string tenchiphi)
        {
            string query = string.Format("insert into chiphiduan values (N'{0}')", tenchiphi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFee(string tenchiphi,int machiphi)
        {
            string query = string.Format("update chiphiduan set tenchiphi=N'{0}' where machiphi={1}", tenchiphi,machiphi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFee(int machiphi)
        {
            string query = string.Format("Delete chiphiduan where machiphi = {0}", machiphi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
