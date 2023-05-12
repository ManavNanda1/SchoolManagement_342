using SchoolManagement_342.Helpers.Helpers;
using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using SchoolManagement_342.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Services
{
    public class SubjectService : ISubject
    {
        Manav_SchoolMgmt_42Entities context = new Manav_SchoolMgmt_42Entities();

        public void AddSubjectData(SubjectModel SubData)
        {
            try
            {
                SubjectHelper data = new SubjectHelper();
                SubjectDetail s = data.AddSubjectInDb(SubData);
                context.SubjectDetails.Add(s);
                context.SaveChanges();
            }
            catch(Exception E)
            {
                throw E;
            }
            
        }

        public int DelSubjectInDb(int SubjectId)
        {
            try
            {
                var SubjectStatus = context.SubjectDetails.Any(x => x.Id == SubjectId);
                if (SubjectStatus)
                {
                    var SubjectData = context.SubjectDetails.Find(SubjectId);
                    context.SubjectDetails.Remove(SubjectData);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception E)
            {
                throw E;
            }
        }

       

        public List<Sp_Get_Subject_Result> GetSubjectTable()
        {
            try
            {

                List<Sp_Get_Subject_Result> SubjectList = context.Sp_Get_Subject().ToList();
                return SubjectList;

            }
            catch(Exception E)
            {
                throw E;
            }
            
        }


        public SubjectModel EditSubjectInDb(int SubjectId)
        {
            try
            {
                var Subject = context.SubjectDetails.Where(x => x.Id == SubjectId).FirstOrDefault();
                return new SubjectModel
                {
                    Id = (int)Subject.Id,
                    SubjectName = Subject.SubjectName
                };
            }
            catch (Exception E)
            {
                throw E;
            }

        }

        public void UpdateData(int id, SubjectModel Model)
        {
            try
            {
                var Subject = context.SubjectDetails.Where(x => x.Id == id).FirstOrDefault();
                Subject.SubjectName = Model.SubjectName;
                context.SaveChanges();
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}
