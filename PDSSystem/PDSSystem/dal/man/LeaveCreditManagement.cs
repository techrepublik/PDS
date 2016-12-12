using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PDSSystem.dal.man
{
    public class LeaveCreditManagement
    {
        public static DataRepository<LeaveCredit> _d;

        public static int Save(LeaveCredit leaveCredit)
        {
            var a = new LeaveCredit
            {
                LeaveCreditNo = leaveCredit.LeaveCreditNo,
                CreditFrom = leaveCredit.CreditFrom,
                CreditTo = leaveCredit.CreditTo,
                Particulars = leaveCredit.Particulars,
                VacationEarned = leaveCredit.VacationEarned,
                VacationDeduction1 = leaveCredit.VacationDeduction1,
                VacationDeduction2 = leaveCredit.VacationDeduction2,
                SickEarned = leaveCredit.SickEarned,
                SickDeduction1 = leaveCredit.SickDeduction1,
                SickDeduction2 = leaveCredit.SickDeduction2,
                PersonnelNo = leaveCredit.PersonnelNo
            };

            using (_d = new DataRepository<LeaveCredit>())
            {
                if (leaveCredit.LeaveCreditNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.LeaveCreditNo;
        }

        public static bool Delete(LeaveCredit leaveCredit)
        {
            using (_d = new DataRepository<LeaveCredit>())
            {
                _d.Delete(leaveCredit);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<LeaveCredit>())
            {
                _d.Delete(d => d.LeaveCreditNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<LeaveCredit> GetAll()
        {
            using (_d = new DataRepository<LeaveCredit>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

        public static List<LeaveCredit> GetAll(int iId)
        {
            using (_d = new DataRepository<LeaveCredit>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).ToList();
            }
        }
    }
}
