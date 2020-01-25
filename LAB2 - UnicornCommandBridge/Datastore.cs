using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Datastore
    {

        public List<Student> students = new List<Student>()
        {
            new Student("S100", "Anders"),
            new Student("S101", "Börje"),
            new Student("S102", "Uffe"),
            new Student("S103", "Koffe"),
            new Student("S104", "Fredrik"),
            new Student("S105", "Johanes"),
            new Student("S106", "Louise")
        };

        List<Betyg> sb = new List<Betyg>();     

        public List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher("T100", "Roger"),
            new Teacher("T101", "Lisa"),
            new Teacher("T102", "Erik"),
            new Teacher("T103", "Pelle"),
            new Teacher("T104", "Johan"),
            new Teacher("T105", "Magnus"),
            new Teacher("T106", "Moa"),
            new Teacher("T107", "Lena")
        };

        public List<Kurs> kurser = new List<Kurs>()
        {
            new Kurs("SysAdm", "System administation"),
            new Kurs("WebDes", "WebbDesign")
        }
            ;

        private List<Betyg> ub = new List<Betyg>();

        public List<Uppgift> uppgifter = new List<Uppgift>()
        {
            new Uppgift("U100", "HTML - Lab1", "Lång uppgiftsbeskrivning om HTML - Lab1 med sammor av text", null),
            new Uppgift("U101", "Vattenfallsmetoden Lab1", "Lång uppgiftsbeskrivning om uppgiften med vattenvallsmetoden Lab1", null)
        };

        List<Teacher> teachA = new List<Teacher>();
        List<Teacher> teachB = new List<Teacher>();
        List<Student> studA = new List<Student>();
        List<Student> studB = new List<Student>();

        public Datastore()
        {
            foreach (Student stud in students)
            {
                stud.betyg = sb;
            }
            foreach (Teacher t in teachers)
            {
                teachA.Add(t);
            }
            foreach (Teacher t in teachers)
            {
                teachB.Add(t);
            }
            foreach (Student s in students)
            {
                studA.Add(s);
            }
            foreach (Student s in students)
            {
                studB.Add(s);
            }
            foreach (Kurs k in kurser)
            {
                k.AnsvLarare = teachers[0];
            }
          

        }
    }
}
