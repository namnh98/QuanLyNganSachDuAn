using QuanLyNganSachDuAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNganSachDuAn.DAO
{
    public class DuanMainDAO
    {
        private static DuanMainDAO instance;

        public static DuanMainDAO Instance
        {
            get { if (instance == null) instance = new DuanMainDAO(); return DuanMainDAO.instance; }
            private set { DuanMainDAO.instance = value; }
        }

        private DuanMainDAO() { }

        public List<DuanMain> GetProject()
        {
            List<DuanMain> listda = new List<DuanMain>();

            string query = "exec getProjectList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DuanMain da = new DuanMain(item);
                listda.Add(da);
            }

            return listda;
        }

        public bool AddProject(string tenduan, int tongkp, string tgianbd, string tgiankt)
        {
            string query = string.Format("insert into duan values (N'{0}', {1}, convert(datetime,'{2}',105), convert(datetime,'{3}',105))", tenduan, tongkp, tgianbd, tgiankt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProject(string tenduan, int tongkp, string tgianbd, string tgiankt,int maduan)
        {
            string query = string.Format("update duan set tenduan=N'{0}',tongkinhphi={1},thoigianbatdau=convert(datetime,'{2}',105), thoigianketthuc=convert(datetime,'{3}',105) where maduan={4}", tenduan, tongkp, tgianbd, tgiankt,maduan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteProject(int maduan)
        {
            string query = string.Format("Delete duan where maduan = {0}", maduan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
