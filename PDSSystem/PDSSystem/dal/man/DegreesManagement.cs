using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class DegreesManagement
    {
        public static DataRepository<Degree> _d;

        public static int Save(Degree degree)
        {
            var a = new Degree
            {
                DegreeNo = degree.DegreeNo,
                DegreeName = degree.DegreeName,
                DegreeShortName = degree.DegreeShortName,
                IsActive = degree.IsActive,
                modifieddate = degree.modifieddate
            };

            using (_d = new DataRepository<Degree>())
            {
                if (degree.DegreeNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.DegreeNo;
        }

        public static bool Delete(Degree degree)
        {
            using (_d = new DataRepository<Degree>())
            {
                _d.Delete(degree);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Degree>())
            {
                _d.Delete(d => d.DegreeNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Degree> GetAll()
        {
            using (_d = new DataRepository<Degree>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderBy(o => o.DegreeShortName).ToList();
            }
        }
    }
}
