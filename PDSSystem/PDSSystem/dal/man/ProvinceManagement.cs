using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class ProvinceManagement
    {
        public static DataRepository<Province> _d;

        public static int Save(Province province)
        {
            var a = new Province
            {
                ProvinceNo = province.ProvinceNo,
                ProvinceName = province.ProvinceName,
                RegionNo = province.RegionNo,
                IsActive = province.IsActive,
                modifieddate = province.modifieddate
            };

            using (_d = new DataRepository<Province>())
            {
                if (province.ProvinceNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.ProvinceNo;
        }

        public static bool Delete(Province province)
        {
            using (_d = new DataRepository<Province>())
            {
                _d.Delete(province);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Province>())
            {
                _d.Delete(d => d.ProvinceNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Province> GetAll()
        {
            using (_d = new DataRepository<Province>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderBy(o => o.ProvinceName).ToList();
            }
        }
    }
}
