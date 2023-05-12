using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Repository.Repository
{
   public  interface ISubject
    {
        List<Sp_Get_Subject_Result> GetSubjectTable();

        void AddSubjectData(SubjectModel SubData);

        int DelSubjectInDb(int SubjectId);

        SubjectModel EditSubjectInDb(int SubjectId);

        void UpdateData(int id, SubjectModel Model);
    }
}
