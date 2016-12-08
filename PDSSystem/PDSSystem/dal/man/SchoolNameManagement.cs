using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class SchoolNameManagement
    {
        public static DataRepository<SchoolName> _d;

        public static int Save(SchoolName schoolName)
        {
            var a = new SchoolName
            {
                SchoolNo = schoolName.SchoolNo,
                SchoolName1 = schoolName.SchoolName1,
                SchoolShortName = schoolName.SchoolShortName,
                IsActive = schoolName.IsActive,
                modifieddate = schoolName.modifieddate
            };

            using (_d = new DataRepository<SchoolName>())
            {
                if (schoolName.SchoolNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.SchoolNo;
        }

        public static bool Delete(SchoolName schoolName)
        {
            using (_d = new DataRepository<SchoolName>())
            {
                _d.Delete(schoolName);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<SchoolName>())
            {
                _d.Delete(d => d.SchoolNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<SchoolName> GetAll()
        {
            using (_d = new DataRepository<SchoolName>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderByDescending(o => o.SchoolShortName).ToList();
            }
        }
    }
}
