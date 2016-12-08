using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class TrainingManagement
    {
        public static DataRepository<Training> _d;

        public static int Save(Training training)
        {
            var a = new Training
            {
                TrainingNo = training.TrainingNo,
                PersonnelNo = training.PersonnelNo,
                TrainingName = training.TrainingName,
                TrainingDate1 = training.TrainingDate1,
                TrainingDate2 = training.TrainingDate2,
                TrainingNoHours = training.TrainingNoHours,
                TrainingSponsor = training.TrainingSponsor,
                IsActive = training.IsActive,
                modifieddate = training.modifieddate
            };

            using (_d = new DataRepository<Training>())
            {
                if (training.TrainingNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.TrainingNo;
        }

        public static bool Delete(Training training)
        {
            using (_d = new DataRepository<Training>())
            {
                _d.Delete(training);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Training>())
            {
                _d.Delete(d => d.TrainingNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Training> GetAll()
        {
            using (_d = new DataRepository<Training>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderByDescending(o => o.TrainingDate2).ToList();
            }
        }

        public static List<Training> GetAll(int iId)
        {
            using (_d = new DataRepository<Training>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderByDescending(o => o.TrainingDate1).ToList();
            }
        }
    }
}
