using System;
using System.Collections.Generic;

namespace UserDAL.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string? Mname { get; set; }
        public string Lname { get; set; } = null!;
        public string Taddress { get; set; } = null!;
        public string TemailAddress { get; set; } = null!;
        public string Tlocation { get; set; } = null!;
        public string Tstandard { get; set; } = null!;
    }
}
