using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class Details
    {
        public static DataRepository<Detail> _d;

        public static int Save(Detail detail)
        {
            var a = new Detail
            {
                DetailNo = detail.DetailNo,
                PersonnelNo = detail.PersonnelNo,
                CommunityTaxNo = detail.CommunityTaxNo,
                IssuedOn = detail.IssuedOn,
                IssuedAt = detail.IssuedAt,
                DateAccomplished = detail.DateAccomplished,
                Signature = detail.Signature,
                Thnumbmark = detail.Thnumbmark,
                IsActive = detail.IsActive
            };

            using (_d = new DataRepository<Detail>())
            {
                if (detail.DetailNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.DetailNo;
        }

        public static bool Delete(Detail detail)
        {
            using (_d = new DataRepository<Detail>())
            {
                _d.Delete(detail);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Detail>())
            {
                _d.Delete(d => d.DetailNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Detail> GetAll()
        {
            using (_d = new DataRepository<Detail>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

        public static List<Detail> GetAll(int iId)
        {
            using (_d = new DataRepository<Detail>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).ToList();
            }
        }
    }
}
