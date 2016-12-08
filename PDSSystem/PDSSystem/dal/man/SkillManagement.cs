using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class SkillManagement
    {
        public static DataRepository<Skill> _d;

        public static int Save(Skill skill)
        {
            var a = new Skill
            {
                SkillNo = skill.SkillNo,
                PersonnelNo = skill.PersonnelNo,
                SkillName = skill.SkillName,
                modifieddate = skill.modifieddate
            };

            using (_d = new DataRepository<Skill>())
            {
                if (skill.SkillNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.SkillNo;
        }

        public static bool Delete(Skill skill)
        {
            using (_d = new DataRepository<Skill>())
            {
                _d.Delete(skill);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Skill>())
            {
                _d.Delete(d => d.SkillNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Skill> GetAll()
        {
            using (_d = new DataRepository<Skill>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.SkillName).ToList();
            }
        }

        public static List<Skill> GetAll(int iId)
        {
            using (_d = new DataRepository<Skill>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderBy(o => o.SkillName).ToList();
            }
        }
    }
}
