using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Kurs : IInterfaceKurs
    {
        public string kursID { get; set; }
        public string kursNamn { get; set; }

        public Teacher AnsvLarare { get; set; }
        public List<Teacher> larare { get; set; }
        public List<Student> elever { get; set; }
        public List<Uppgift> kursUppgifter { get; set; }

        public Kurs(/*string kursId, string kursNamn, string headTeacher, List<string> teachers, List<string> students/*, List<Uppgift> uppgifter*/)
        {
            //this.kursID = kursId;
            //this.kursNamn = kursNamn;
          
            //this.AnsvLarare = headTeacher;
            //List<string> larare = new List<string>();
            //List<string> elever = new List<string>();
            //List<string> kursUppgifter = new List<string>();

        }

        public override string ToString()
        {
            return kursID + " " + kursNamn;
        }

    }
}
