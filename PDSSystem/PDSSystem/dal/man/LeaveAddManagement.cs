using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class LeaveAddManagement
    {
        public static DataRepository<LeaveAdd> _d;

        public static int Save(LeaveAdd leaveAdd)
        {
            var a = new LeaveAdd
            {
                LeaveAddNo = leaveAdd.LeaveAddNo,
                LeaveAddDate = leaveAdd.LeaveAddDate,
                LeaveApplicationNo = leaveAdd.LeaveApplicationNo,
                LeaveCreditNo = leaveAdd.LeaveCreditNo
            };

            using (_d = new DataRepository<LeaveAdd>())
            {
                if (leaveAdd.LeaveAddNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.LeaveAddNo;
        }

        public static bool Delete(LeaveAdd leaveAdd)
        {
            using (_d = new DataRepository<LeaveAdd>())
            {
                _d.Delete(leaveAdd);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<LeaveAdd>())
            {
                _d.Delete(d => d.LeaveAddNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<LeaveAdd> GetAll()
        {
            using (_d = new DataRepository<LeaveAdd>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

        public static List<LeaveAdd> GetAll(int iId)
        {
            using (_d = new DataRepository<LeaveAdd>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.LeaveCreditNo == iId).ToList();
            }
        }
    }
}
