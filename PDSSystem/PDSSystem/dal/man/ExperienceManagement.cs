using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class ExperienceManagement
    {
        public static DataRepository<Experiency> _d;

        public static int Save(Experiency experience)
        {
            var a = new Experiency
            {
                ExperienceNo = experience.ExperienceNo,
                PersonnelNo = experience.PersonnelNo,
                ExperienceDate1 = experience.ExperienceDate1,
                ExperienceDate2 = experience.ExperienceDate2,
                ExperiencePosition = experience.ExperiencePosition,
                ExperienceOffice = experience.ExperienceOffice,
                ExperienceSalary = experience.ExperienceSalary,
                ExperienceSalaryGrade = experience.ExperienceSalaryGrade,
                ExperienceStatus = experience.ExperienceStatus,
                ExperienceIsGovernment = experience.ExperienceIsGovernment,
                IsActive = experience.IsActive,
                modifieddate = experience.modifieddate
            };

            using (_d = new DataRepository<Experiency>())
            {
                if (experience.ExperienceNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.ExperienceNo;
        }

        public static bool Delete(Experiency experience)
        {
            using (_d = new DataRepository<Experiency>())
            {
                _d.Delete(experience);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Experiency>())
            {
                _d.Delete(d => d.ExperienceNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Experiency> GetAll()
        {
            using (_d = new DataRepository<Experiency>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderByDescending(o => o.ExperienceDate1).ToList();
            }
        }

        public static List<Experiency> GetAll(int iId)
        {
            using (_d = new DataRepository<Experiency>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderByDescending(o => o.ExperienceDate1).ToList();
            }
        }
    }
}
