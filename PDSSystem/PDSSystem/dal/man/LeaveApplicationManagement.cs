using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class LeaveApplicationManagement
    {
        public static DataRepository<LeaveApplication> _d;

        public static int Save(LeaveApplication leaveApplication)
        {
            var a = new LeaveApplication
            {
                LeaveApplicationNo = leaveApplication.LeaveApplicationNo,
                Commutation = leaveApplication.Commutation,
                DateApplied = leaveApplication.DateApplied,
                LeaveDays = leaveApplication.LeaveDays,
                LeaveEnd = leaveApplication.LeaveEnd,
                LeaveNo = leaveApplication.LeaveNo,
                LeaveOfficeNo = leaveApplication.LeaveOfficeNo,
                LeaveSpent = leaveApplication.LeaveSpent,
                LeaveSpentDetail = leaveApplication.LeaveSpentDetail,
                LeaveStart = leaveApplication.LeaveStart,
                LeaveTypeNo = leaveApplication.LeaveTypeNo,
                Recommendation = leaveApplication.Recommendation,
                PersonnelNo = leaveApplication.PersonnelNo,
                RecommendationDetail = leaveApplication.RecommendationDetail
            };

            using (_d = new DataRepository<LeaveApplication>())
            {
                if (leaveApplication.LeaveApplicationNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.LeaveApplicationNo;
        }

        public static bool Delete(LeaveApplication leaveApplication)
        {
            using (_d = new DataRepository<LeaveApplication>())
            {
                _d.Delete(leaveApplication);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<LeaveApplication>())
            {
                _d.Delete(d => d.LeaveApplicationNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<LeaveApplication> GetAll(int iId)
        {
            using (_d = new DataRepository<LeaveApplication>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.Find(f => f.LeaveApplicationNo == iId).ToList();
            }
        }
    }
}
