using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class LeaveOfficeManagement
    {
        public static DataRepository<LeaveOffice> _d;

        public static int Save(LeaveOffice leaveOffice)
        {
            var a = new LeaveOffice
            {
               LeaveOfficeNo = leaveOffice.LeaveOfficeNo,
               PersonnelNo = leaveOffice.PersonnelNo,
               BasicSalary = leaveOffice.BasicSalary,
               DateFiled = leaveOffice.DateFiled,
               OfficeAgency = leaveOffice.OfficeAgency,
               Position = leaveOffice.Position
            };

            using (_d = new DataRepository<LeaveOffice>())
            {
                if (leaveOffice.LeaveOfficeNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.LeaveOfficeNo;
        }

        public static bool Delete(LeaveOffice leaveOffice)
        {
            using (_d = new DataRepository<LeaveOffice>())
            {
                _d.Delete(leaveOffice);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<LeaveOffice>())
            {
                _d.Delete(d => d.LeaveOfficeNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<LeaveOffice> GetAll(int iId)
        {
            using (_d = new DataRepository<LeaveOffice>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.Find(f => f.PersonnelNo == iId).ToList();
            }
        }
    }
}
