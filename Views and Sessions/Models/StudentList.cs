using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Views_and_Sessions.Models
{
    public class StudentList : List<Student>
    {
        public void Add(int id, string firtsname, string lastname, string gender, int age)
        {
            var Student= new StudentList
            {
                Id = id;
                Firstname = firtsname;
                Lastname = lastname;
                Gender = gender;
                Age = age;
            };
                 this.Add(Student);
            }
        }
    
