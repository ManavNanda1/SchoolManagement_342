using SchoolManagement_342.Models.Context;
using SchoolManagement_342.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_342.Helpers.Helpers
{
    public class SubjectHelper
    {
        public SubjectDetail AddSubjectInDb(SubjectModel SubjectData)
        {
            SubjectDetail Subjects = new SubjectDetail();
            Subjects.SubjectName = SubjectData.SubjectName;
            return Subjects;

        }
    }
}
