﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Try.Datas
{
    public class Student
    {
        //public int StudentId { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        //public int GradeId { get; set; }
        //public Grade Grade { get; set; }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }        
        public string StudentCourses { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }        
        public StudentAddress Address { get; internal set; }
    }
}
