using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class MunicipalityManagement
    {
        public static DataRepository<Municipality> _d;

        public static int Save(Municipality municipality)
        {
            var a = new Municipality
            {
                MunicipalityNo = municipality.MunicipalityNo,
                MunicipalityName = municipality.MunicipalityName,
                MunicipalityPostalCode = municipality.MunicipalityPostalCode,
                ProvinceNo = municipality.ProvinceNo,
                IsActive = municipality.IsActive,
                datemodified = municipality.datemodified
            };

            using (_d = new DataRepository<Municipality>())
            {
                if (municipality.MunicipalityNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.MunicipalityNo;
        }

        public static bool Delete(Municipality municipality)
        {
            using (_d = new DataRepository<Municipality>())
            {
                _d.Delete(municipality);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Municipality>())
            {
                _d.Delete(d => d.MunicipalityNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Municipality> GetAll()
        {
            using (_d = new DataRepository<Municipality>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderBy(o => o.MunicipalityName).ToList();
            }
        }
    }
}
