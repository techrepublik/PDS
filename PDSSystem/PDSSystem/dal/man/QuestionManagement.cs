using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class QuestionManagement
    {
        public static DataRepository<Question> _d;

        public static int Save(Question question)
        {
            var a = new Question
            {
                QuestionNo = question.QuestionNo,
                PersonnelNo = question.PersonnelNo,
                Q36A_Yes = question.Q36A_Yes,
                Q36A_No = question.Q36A_No,
                Q36B_No = question.Q36B_No,
                Q36B_Yes = question.Q36B_Yes,
                Q36B_YesDetails = question.Q36B_YesDetails,
                Q36A_YesDetails = question.Q36A_YesDetails,
                Q37A_Yes = question.Q37A_Yes,
                Q37A_No = question.Q37A_No,
                Q37A_YesDetails = question.Q37A_YesDetails,
                Q37B_No = question.Q37B_No,
                Q37B_Yes = question.Q37B_Yes,
                Q37B_YesDetails = question.Q37B_YesDetails,
                Q38_No = question.Q38_No,
                Q38_Yes = question.Q38_Yes,
                Q38_YesDetails = question.Q38_YesDetails,
                Q39_No = question.Q39_No,
                Q39_Yes = question.Q39_Yes,
                Q39_YesDetails = question.Q39_YesDetails,
                Q40_No = question.Q40_No,
                Q40_Yes = question.Q40_Yes,
                Q40_YesDetails = question.Q40_YesDetails,
                Q41A_No = question.Q41A_No,
                Q41A_Yes = question.Q41A_Yes,
                Q41A_YesDetails = question.Q41A_YesDetails,
                Q41B_No = question.Q41B_No,
                Q41B_Yes = question.Q41B_Yes,
                Q41B_YesDetails = question.Q41B_YesDetails,
                Q41C_No = question.Q41C_No,
                Q41C_Yes = question.Q41C_Yes,
                Q41C_YesDetails = question.Q41C_YesDetails,
                IsActive = question.IsActive
            };

            using (_d = new DataRepository<Question>())
            {
                if (question.QuestionNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.QuestionNo;
        }

        public static bool Delete(Question question)
        {
            using (_d = new DataRepository<Question>())
            {
                _d.Delete(question);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Question>())
            {
                _d.Delete(d => d.QuestionNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Question> GetAll()
        {
            using (_d = new DataRepository<Question>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

        public static List<Question> GetAll(int iId)
        {
            using (_d = new DataRepository<Question>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).ToList();
            }
        }

        public static Question Get(int iId)
        {
            using (_d = new DataRepository<Question>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.FirstOrDefault(f => f.PersonnelNo == iId);
            }
        }
    }
}
