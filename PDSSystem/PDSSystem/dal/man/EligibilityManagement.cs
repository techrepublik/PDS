using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class EligibilityManagement
    {
        public static DataRepository<Eligibility> _d;

        public static int Save(Eligibility eligibility)
        {
            var a = new Eligibility
            {
                EligibilityExamDate = eligibility.EligibilityExamDate,
                EligibilityExamPlace = eligibility.EligibilityExamPlace,
                EligibilityLicenseDate = eligibility.EligibilityLicenseDate,
                EligibilityLicenseNo = eligibility.EligibilityLicenseNo,
                EligibilityName = eligibility.EligibilityName,
                EligibilityNo = eligibility.EligibilityNo,
                PersonnelNo = eligibility.PersonnelNo,
                EligibilityRating = eligibility.EligibilityRating,
                modifieddate = eligibility.modifieddate
            };

            using (_d = new DataRepository<Eligibility>())
            {
                if (eligibility.EligibilityNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.EligibilityNo;
        }

        public static bool Delete(Eligibility eligibility)
        {
            using (_d = new DataRepository<Eligibility>())
            {
                _d.Delete(eligibility);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Eligibility>())
            {
                _d.Delete(d => d.EligibilityNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Eligibility> GetAll()
        {
            using (_d = new DataRepository<Eligibility>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderByDescending(o => o.EligibilityExamDate).ToList();
            }
        }

        public static List<Eligibility> GetAll(int iId)
        {
            using (_d = new DataRepository<Eligibility>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderByDescending(o => o.EligibilityExamDate).ToList();
            }
        }
    }
}
