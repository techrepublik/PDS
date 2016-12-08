using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class SpouseManagement
    {
        public static DataRepository<Spous> _d;

        public static int Save(Spous spouse)
        {
            var a = new Spous
            {
                SpouseNo = spouse.SpouseNo,
                PersonnelNo = spouse.PersonnelNo,
                SpouseSurName = spouse.SpouseSurName,
                SpouseFirstName = spouse.SpouseFirstName,
                SpouseMiddleName = spouse.SpouseMiddleName,
                Occupation = spouse.Occupation,
                Employer = spouse.Employer,
                EmployerAddress = spouse.EmployerAddress,
                TelephoneNo = spouse.TelephoneNo,
                IsActive = spouse.IsActive,
                modifieddate = spouse.modifieddate
            };

            using (_d = new DataRepository<Spous>())
            {
                if (spouse.SpouseNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.SpouseNo;
        }

        public static bool Delete(Spous spouse)
        {
            using (_d = new DataRepository<Spous>())
            {
                _d.Delete(spouse);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Spous>())
            {
                _d.Delete(d => d.SpouseNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Spous> GetAll()
        {
            using (_d = new DataRepository<Spous>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SpouseSurName).ToList();
            }
        }

        public static List<Spous> GetAll(int iId)
        {
            using (_d = new DataRepository<Spous>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderBy(o => o.SpouseSurName).ToList();
            }
        }

        public static Spous GetA(int iId)
        {
            using (_d = new DataRepository<Spous>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Single(f => f.PersonnelNo == iId && f.IsActive == true);
            }
        }
    }
}
