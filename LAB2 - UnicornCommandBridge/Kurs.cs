using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Kurs:IInterfaceKurs
    {
        public string kursID { get; set;}
        public string kursNamn { get; set;}
        public Teacher AnsvLarare;
        public List<Teacher> larare;
        public List<Student> elever;
        public List<Uppgift> kursUppgifter;

        public Kurs(string kursId, string kursNamn, /*Teacher headTeacher, */List<Teacher> teachers, List<Student> students/*, List<Uppgift> uppgifter*/)
        {
            this.kursID = kursId;
            this.kursNamn = kursNamn;
            //this.AnsvLarare = headTeacher;
            List<Teacher> larare = new List<Teacher>();
            List<Student> elever = new List<Student>();
            List<Uppgift> kursUppgifter = new List<Uppgift>();

        }

        public override string ToString()
        {
            return kursID + " " + kursNamn;
        }

        /*public string kursId;
       public string kursNamn;
       public string headTeacher;
       public List<Teacher> kursTeachers;
       public List<Student> kursStudents;
       public List<Uppgift> kursUppgifter;

       public Kurs(string kursId, string kursNamn, string headTeacher, List<Teacher> teachers, List<Student> students, List<Uppgift> uppgifter)
       {
           this.kursId = kursId;
           this.kursNamn = kursNamn;
           this.headTeacher = headTeacher;
           List<Teacher> kursTeachers = new List<Teacher>();
           List<Student> kursStudents = new List<Student>();
           List<Uppgift> kursUppgifter = new List<Uppgift>();
       }*/
    }
}
