using PDSSystem.dal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.repo;
using PDSSystem.dal.classes;

namespace PDSSystem.dal.quer
{
    public class StaticClass
    {
        public static List<Personnel> ListPersonnel()
        {
            var d = new DataRepository<Personnel>();

            using (d = new DataRepository<Personnel>())
            {
                d.LazyLoadingEnabled = false;
                return d.GetAll().OrderBy(o => o.SurName).ToList();
            }
        }

        public static List<EducationObj> ListEducation(int iId)
        {
            using (var data = new PDSEntities())
            {
                var q = from educ in data.Educations
                        join scho in data.SchoolNames on educ.EducationNo equals scho.SchoolNo
                        join degr in data.Degrees on educ.DegreeNo equals degr.DegreeNo
                        where educ.PersonnelNo == iId //filter by personnel id
                        select new EducationObj
                        {
                            EducationNo = educ.EducationNo,
                            DegreeNo = degr.DegreeNo,
                            SchoolNo = scho.SchoolNo,
                            SchoolsName = scho.SchoolName1,
                            DegreesName = degr.DegreeName,
                            EducationLevelNo = educ.EducationLevelNo,
                            HighestLevelEarned = educ.HighestLevelEarned,
                            InclusiveDate1 = educ.InclusiveDate1,
                            InclusiveDate2 = educ.InclusiveDate2,
                            ScholarshipHonor = educ.ScholarshipHonor,
                            YearGraduated = educ.YearGraduated
                        };

                return q.OrderByDescending(o => o.InclusiveDate1).ToList();
            }
        }

        public static List<ChildrenObj> ListChildren(int iId)
        {
            using (var data = new PDSEntities())
            {
                var q = from child in data.Childrens
                        where child.SpouseNo == iId //filter by spouse id
                        select new ChildrenObj
                        {
                            ChildrenLastName = child.ChildrenLastName,
                            ChildrenFirstName = child.ChildrenFirstName,
                            ChildrenMiddleName = child.ChildrenMiddleName,
                            ChildrenBirthDate = child.ChildrenBirthDate
                        };

                return q.OrderByDescending(o => o.ChildrenBirthDate).ToList();
            }
        }

        #region Leave
        public static List<EmployeeObj> ListEmployee()
        {
            using (var data = new PDSEntities())
            {
                var q = from pers in data.Personnels
                        select new EmployeeObj
                        {
                           SurName = pers.SurName,
                           FirstName = pers.FirstName,
                           MiddleName = pers.MiddleName,
                           PersonnelNo = pers.PersonnelNo
                        };

                return q.OrderBy(o => o.SurName).ToList();
            }
        }

        public static List<LeaveObj> ListLeaveApplication(int iMonth, int iYear)
        {
            using (var data = new PDSEntities())
            {
                var q = from pers in data.Personnels
                        join leav in data.LeaveApplications on pers.PersonnelNo equals leav.PersonnelNo
                        join leaf in data.Leaves on leav.LeaveNo equals leaf.LeaveNo
                        join lety in data.LeaveTypes on leav.LeaveTypeNo equals lety.LeaveTypeNo
                        where (leav.DateApplied.Value.Month == iMonth) && (leav.DateApplied.Value.Year == iYear)
                        select new LeaveObj
                        {
                            LastName = pers.SurName,
                            FirstName = pers.FirstName,
                            MiddleName = pers.MiddleName,
                            SuffixName = pers.SuffixName,
                            PersonnelNo = pers.PersonnelNo,
                            DateApplied = leav.DateApplied,
                            LeaveApplicationNo = leav.LeaveApplicationNo,
                            LeaveDays = leav.LeaveDays,
                            Commutation = leav.Commutation,
                            LeaveEnd = leav.LeaveEnd,
                            LeaveStart = leav.LeaveStart,
                            LeaveName = leaf.LeaveName,
                            LeaveNo = leaf.LeaveNo,
                            LeaveSpent = leav.LeaveSpent,
                            LeaveSpentDetail = leav.LeaveSpentDetail,
                            LeaveType = lety.LeaveType1,
                            LeaveTypeNo = lety.LeaveTypeNo,
                            Recommendation = leav.Recommendation,
                            RecommendationDetail = leav.RecommendationDetail
                        };

                return q.OrderByDescending(o => o.DateApplied).ToList();
            }
        }

        public static List<LeaveObj> ListLeaveApplication()
        {
            using (var data = new PDSEntities())
            {
                var q = from pers in data.Personnels
                        join leav in data.LeaveApplications on pers.PersonnelNo equals leav.PersonnelNo
                        join leaf in data.Leaves on leav.LeaveNo equals leaf.LeaveNo
                        join lety in data.LeaveTypes on leav.LeaveTypeNo equals lety.LeaveTypeNo
                        select new LeaveObj
                        {
                            LastName = pers.SurName,
                            FirstName = pers.FirstName,
                            MiddleName = pers.MiddleName,
                            SuffixName = pers.SuffixName,
                            PersonnelNo = pers.PersonnelNo,
                            DateApplied = leav.DateApplied,
                            LeaveApplicationNo = leav.LeaveApplicationNo,
                            LeaveDays = leav.LeaveDays,
                            Commutation = leav.Commutation,
                            LeaveEnd = leav.LeaveEnd,
                            LeaveStart = leav.LeaveStart,
                            LeaveName = leaf.LeaveName,
                            LeaveNo = leaf.LeaveNo,
                            LeaveSpent = leav.LeaveSpent,
                            LeaveSpentDetail = leav.LeaveSpentDetail,
                            LeaveType = lety.LeaveType1,
                            LeaveTypeNo = lety.LeaveTypeNo,
                            Recommendation = leav.Recommendation,
                            RecommendationDetail = leav.RecommendationDetail
                        };

                return q.OrderByDescending(o => o.DateApplied).ToList();
            }
        }

        public static List<LeaveCreditObj> ListLeaveCreditSum()
        {
            using (var data = new PDSEntities())
            {
                var q = from pers in data.Personnels
                        join leav in data.LeaveCredits on pers.PersonnelNo equals leav.PersonnelNo
                        group leav by pers.SurName into g1
                        select new LeaveCreditObj
                        {
                            PersonnelNo = g1.First().Personnel.PersonnelNo,
                            LastName = g1.First().Personnel.SurName,
                            FirstName = g1.First().Personnel.FirstName,
                            MiddleName = g1.First().Personnel.MiddleName,
                            SuffixName = g1.First().Personnel.SuffixName,
                            VacationEarned = g1.Sum(s => s.VacationEarned),
                            SickEarned = g1.Sum(s => s.SickEarned),
                            SickDeduction1 = g1.Sum(s => s.SickDeduction1),
                            SickDeduction2 = g1.Sum(s => s.SickDeduction2),
                            VacationDeduction1 = g1.Sum(s => s.VacationDeduction1),
                            VacationDeduction2 = g1.Sum(s => s.VacationDeduction2)
                        };

                return q.OrderBy(o => o.LastName).ToList();
            }
        }

        #endregion
    }
}
