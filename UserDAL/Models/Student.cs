using System;
using System.Collections.Generic;

namespace UserDAL.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string? Mname { get; set; }
        public string Lname { get; set; } = null!;
        public string Saddress { get; set; } = null!;
        public string SemailAddress { get; set; } = null!;
        public string Slocation { get; set; } = null!;
        public int? Sstandard { get; set; }
        public int? StotalMarks { get; set; }
        public decimal? Sgrade { get; set; }
    }
}
