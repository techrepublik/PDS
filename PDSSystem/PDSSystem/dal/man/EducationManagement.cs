using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class EducationManagement
    {
        public static DataRepository<Education> _d;

        public static int Save(Education education)
        {
            var a = new Education
            {
               EducationNo = education.EducationNo,
               PersonnelNo = education.PersonnelNo,
               EducationLevelNo = education.EducationLevelNo,
               SchoolNo = education.SchoolNo,
               DegreeNo = education.DegreeNo,
               YearGraduated = education.YearGraduated,
               HighestLevelEarned = education.HighestLevelEarned,
               InclusiveDate1 = education.InclusiveDate1,
               InclusiveDate2 = education.InclusiveDate2,
               ScholarshipHonor = education.ScholarshipHonor,
               modifieddate = education.modifieddate
            };

            using (_d = new DataRepository<Education>())
            {
                if (education.EducationNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.EducationNo;
        }

        public static bool Delete(Education education)
        {
            using (_d = new DataRepository<Education>())
            {
                _d.Delete(education);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Education>())
            {
                _d.Delete(d => d.DegreeNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Education> GetAll()
        {
            using (_d = new DataRepository<Education>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderByDescending(o => o.YearGraduated).ToList();
            }
        }
    }
}
