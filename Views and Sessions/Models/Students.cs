using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Views_and_Sessions.Models
{
    public class Student
    {
        public int Id { get; set;}
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Student (int id,string firtsname,string lastname,string gender,int age)
        {
            Id = id;
            Firstname = firtsname;
            Lastname = lastname;
            Gender = gender;
            Age = age;
        }
    }
}