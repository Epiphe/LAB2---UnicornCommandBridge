using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{


    public class Datastore : IDatastore
    {
        public List<Student> students { get; set; }
        public List<Teacher> teachers { get; set; }
        public List<Kurs> kurser { get; set; }
        public List<Uppgift> uppgifter { get; set; }


        public Datastore()
        {
            students = new List<Student>();
            students.Add(new Student("S100", "Anders"));
            students.Add(new Student("S101", "Börje"));
            students.Add(new Student("S102", "Uffe"));
            students.Add(new Student("S103", "Koffe"));
            students.Add(new Student("S104", "Fredrik"));
            students.Add(new Student("S105", "Johanes"));
            students.Add(new Student("S106", "Louise"));

            Teacher Roger = new Teacher("T100", "Roger");
            Teacher Lisa = new Teacher("T101", "Lisa");

            teachers = new List<Teacher>();
            teachers.Add(Roger);
            teachers.Add(Lisa);
            teachers.Add(new Teacher("T102", "Erik"));
            teachers.Add(new Teacher("T103", "Pelle"));
            teachers.Add(new Teacher("T104", "Johan"));
            teachers.Add(new Teacher("T104", "Johan"));
            teachers.Add(new Teacher("T105", "Magnus"));
            teachers.Add(new Teacher("T106", "Moa"));
            teachers.Add(new Teacher("T107", "Lena"));


            Kurs Sys = new Kurs("SysAdm", "System administation");
            Kurs Web = new Kurs("WebDes", "WebbDesign");
            kurser = new List<Kurs>();

            Uppgift HTML = new Uppgift("U100", "HTML - Lab1", "Lång uppgiftsbeskrivning om HTML - Lab1 med sammor av text", null);
            Uppgift vatten = new Uppgift("U101", "Vattenfallsmetoden Lab1", "Lång uppgiftsbeskrivning om uppgiften med vattenvallsmetoden Lab1", null);
            uppgifter = new List<Uppgift>();


            Sys.AnsvLarare = Roger;
            Web.AnsvLarare = Lisa;
            vatten.kurs = Sys;
            uppgifter.Add(vatten);
            HTML.kurs = Web;
            uppgifter.Add(HTML);

            foreach (Student stud in students)
            {
                stud.kurser.Add(Sys);
                stud.Kurser.Add(Web);
            }
            foreach (Teacher t in teachers)
            {
                t.kurser.Add(Sys);
                t.Kurser.Add(Web);
            }


            Sys.Elever = students;
            Sys.Larare = teachers;
            Sys.KursUppgifter.Add(vatten);
            Web.Elever = students;
            Web.Larare = teachers;
            Web.KursUppgifter.Add(HTML);


            kurser.Add(Sys);
            kurser.Add(Web);
        }
    }
}
