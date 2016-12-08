using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class LeaveManagement
    {
        public static DataRepository<Leaf> _d;

        public static int Save(Leaf leave)
        {
            var a = new Leaf
            {
                LeaveNo = leave.LeaveNo,
                LeaveName = leave.LeaveName
            };

            using (_d = new DataRepository<Leaf>())
            {
                if (leave.LeaveNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.LeaveNo;
        }

        public static bool Delete(Leaf leave)
        {
            using (_d = new DataRepository<Leaf>())
            {
                _d.Delete(leave);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Leaf>())
            {
                _d.Delete(d => d.LeaveNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Leaf> GetAll()
        {
            using (_d = new DataRepository<Leaf>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.LeaveName).ToList();
            }
        }
    }
}
