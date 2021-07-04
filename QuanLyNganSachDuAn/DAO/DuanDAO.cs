using QuanLyNganSachDuAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganSachDuAn.DAO
{
    public class DuanDAO
    {
        private static DuanDAO instance;

        public static DuanDAO Instance
        {
            get { if (instance == null) instance = new DuanDAO(); return DuanDAO.instance; }
            private set { DuanDAO.instance = value; }
        }

        private DuanDAO() { }

        public List<Duan> GetProject()
        {
            List<Duan> listda = new List<Duan>();

            string query = "exec laythongkeduan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Duan da = new Duan(item);
                listda.Add(da);
            }

            return listda;
        }
    }
}
