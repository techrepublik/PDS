using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    class PersonnelManagement
    {
        public static DataRepository<Personnel> _d;

        public static int Save(Personnel personnel)
        {
            var a = new Personnel
            {
                CSIdNo = personnel.CSIdNo,
                PersonnelNo = personnel.PersonnelNo,
                PersonnelIdNo = personnel.PersonnelIdNo,
                SurName = personnel.SurName,
                FirstName = personnel.FirstName,
                MiddleName = personnel.MiddleName,
                SuffixName = personnel.SuffixName,
                DateOfBirth = personnel.DateOfBirth,
                PlaceOfBirth = personnel.PlaceOfBirth,
                ResidentialAddress = personnel.ResidentialAddress,
                ResidentialZipCode = personnel.ResidentialZipCode,
                ResidentialtelephoneNo = personnel.ResidentialtelephoneNo,
                PermanentAddress = personnel.PermanentAddress,
                PermanentZipCode = personnel.PermanentZipCode,
                PermanentTelephoneNo = personnel.PermanentTelephoneNo,
                Sex = personnel.Sex,
                CivilStatus = personnel.CivilStatus,
                Citizenship = personnel.Citizenship,
                Height = personnel.Height,
                Weight = personnel.Weight,
                BloodType = personnel.BloodType,
                GSISIdNo = personnel.GSISIdNo,
                PagIbigIdNo = personnel.PagIbigIdNo,
                PhiliHealthIdNo = personnel.PhiliHealthIdNo,
                SSSIdNo = personnel.SSSIdNo,
                FatherFirstName = personnel.FatherFirstName,
                FatherLastName = personnel.FatherLastName,
                FatherMiddleName = personnel.FatherMiddleName,
                MotherFirstName = personnel.MotherFirstName,
                MotherLastName = personnel.MotherLastName,
                MotherMiddleName = personnel.MotherMiddleName,
                MotherMaidenName = personnel.MotherMaidenName,
                TIN = personnel.TIN,
                IsActive = personnel.IsActive,
                EmailAddress = personnel.EmailAddress,
                CellphoneNo = personnel.CellphoneNo,
                Photo = personnel.Photo,
                BarcodeImage = personnel.BarcodeImage,
                guid = personnel.guid,
                datemodified = personnel.datemodified
            };

            using (_d = new DataRepository<Personnel>())
            {
                if (personnel.PersonnelNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.PersonnelNo;
        }

        public static bool Delete(Personnel personnel)
        {
            using (_d = new DataRepository<Personnel>())
            {
                _d.Delete(personnel);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Personnel>())
            {
                _d.Delete(d => d.PersonnelNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Personnel> GetAll()
        {
            using (_d = new DataRepository<Personnel>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SurName).ToList();
            }
        }

        public static List<Personnel> GetAll(string search)
        {
            using (_d = new DataRepository<Personnel>())
            {
                _d.LazyLoadingEnabled = false;
                return
                    _d.Find(
                        f => f.SurName.StartsWith(search) || f.FirstName.StartsWith(search) || f.PersonnelIdNo == search)
                        .OrderBy(o => o.SurName)
                        .ToList();
            }
        }
        public static Personnel GetA(string IdNo)
        {
            using (_d = new DataRepository<Personnel>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Single(f => f.PersonnelIdNo == IdNo);
            }
        }

        public static Personnel GetA(int iId)
        {
            using (_d = new DataRepository<Personnel>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Single(f => f.PersonnelNo == iId);
            }
        }
    }
}
