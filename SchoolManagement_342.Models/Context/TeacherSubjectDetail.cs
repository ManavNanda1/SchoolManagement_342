//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement_342.Models.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherSubjectDetail
    {
        public long Id { get; set; }
        public Nullable<long> TeacherId { get; set; }
        public Nullable<long> SubjectId { get; set; }
    
        public virtual SubjectDetail SubjectDetail { get; set; }
        public virtual TeacherDetail TeacherDetail { get; set; }
    }
}