using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class RegionManagement
    {
        public static DataRepository<Region> _d;

        public static int Save(Region region)
        {
            var a = new Region
            {
                RegionNo = region.RegionNo,
                RegionName = region.RegionName,
                modifieddate = region.modifieddate
            };

            using (_d = new DataRepository<Region>())
            {
                if (region.RegionNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.RegionNo;
        }

        public static bool Delete(Region region)
        {
            using (_d = new DataRepository<Region>())
            {
                _d.Delete(region);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Region>())
            {
                _d.Delete(d => d.RegionNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Region> GetAll()
        {
            using (_d = new DataRepository<Region>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderBy(o => o.RegionName).ToList();
            }
        }
    }
}
