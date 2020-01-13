using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    class Student: Användare
    {
       

        public Student(string användarId, string namn) : base(användarId, namn)
        {
            
            
               

             
            List<Student> students = new List<Student>();
            students.Add(new Student( användarId = "S100",  namn = "Anders"));
        }
    }
}
