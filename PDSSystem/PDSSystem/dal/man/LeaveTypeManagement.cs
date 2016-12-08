using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class LeaveTypeManagement
    {
        public static DataRepository<LeaveType> _d;

        public static int Save(LeaveType leaveType)
        {
            var a = new LeaveType
            {
                LeaveTypeNo = leaveType.LeaveTypeNo,
                LeaveType1 = leaveType.LeaveType1
            };

            using (_d = new DataRepository<LeaveType>())
            {
                if (leaveType.LeaveTypeNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.LeaveTypeNo;
        }

        public static bool Delete(LeaveType leaveType)
        {
            using (_d = new DataRepository<LeaveType>())
            {
                _d.Delete(leaveType);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<LeaveType>())
            {
                _d.Delete(d => d.LeaveTypeNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<LeaveType> GetAll()
        {
            using (_d = new DataRepository<LeaveType>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.LeaveType1).ToList();
            }
        }
    }
}
