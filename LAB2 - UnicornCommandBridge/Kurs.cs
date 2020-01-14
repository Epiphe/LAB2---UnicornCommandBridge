using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    class Kurs
    {
        public string kursId;
        public string kursNamn;
        public Teacher headTeacher;
        public List<Teacher> kursTeachers;
        public List<Student> kursStudents;
        public List<Uppgift> kursUppgifter;

        public Kurs(string kursId, string kursNamn,Teacher headTeacher, Teacher teacher, List<Teacher> teachers, List<Student> students, List<Uppgift> uppgifter)
        {
            this.kursId = kursId;
            this.kursNamn = kursNamn;
            this.headTeacher = headTeacher;
            List<Teacher> kursTeachers = new List<Teacher>();
            List<Student> kursStudents = new List<Student>();
            List<Uppgift> kursUppgifter = new List<Uppgift>();
        }
    }
}
