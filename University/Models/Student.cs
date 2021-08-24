using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMVC.Models
{
    public class Student : Section
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }


        public Student() : base() { }
        public Student(int Id, string Name, int Age)
        {
            if (Name != null) this.StudentName = Name;
            this.StudentID = Id;
            this.StudentAge = Age;
        }
    }
}