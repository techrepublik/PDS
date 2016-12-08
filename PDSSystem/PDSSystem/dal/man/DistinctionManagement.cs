using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class DistinctionManagement
    {
        public static DataRepository<Distinction> _d;

        public static int Save(Distinction distinction)
        {
            var a = new Distinction
            {
                DistinctionNo = distinction.DistinctionNo,
                PersonnelNo = distinction.PersonnelNo,
                DistinctionName = distinction.DistinctionName,
                modifieddate = distinction.modifieddate
            };

            using (_d = new DataRepository<Distinction>())
            {
                if (distinction.DistinctionNo> 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.DistinctionNo;
        }

        public static bool Delete(Distinction distinction)
        {
            using (_d = new DataRepository<Distinction>())
            {
                _d.Delete(distinction);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Distinction>())
            {
                _d.Delete(d => d.DistinctionNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Distinction> GetAll()
        {
            using (_d = new DataRepository<Distinction>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderByDescending(o => o.DistinctionName).ToList();
            }
        }

        public static List<Distinction> GetAll(int iId)
        {
            using (_d = new DataRepository<Distinction>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderBy(o => o.DistinctionName).ToList();
            }
        }
    }
}
