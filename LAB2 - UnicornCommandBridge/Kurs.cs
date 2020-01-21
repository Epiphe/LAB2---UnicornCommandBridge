using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Kurs : IKurs
    {
        public string kursID { get; set; }
        public string kursNamn { get; set; }

        public Teacher AnsvLarare { get; set; }
        public List<Teacher> larare { get; set; }
        public List<Student> elever { get; set; }
        public List<Uppgift> kursUppgifter { get; set; }

        public Kurs(string kursId, string kursNamn, Teacher ansvLarare, List<Teacher> Larare, List<Student> Elever, List<Uppgift> Uppgifter)
        {
            this.kursID = kursId;
            this.kursNamn = kursNamn;
            this.AnsvLarare = ansvLarare;

            List<Teacher> larare = new List<Teacher>();
            this.larare = Larare;
            List<Student> elever = new List<Student>();
            this.elever = Elever;
            List<Uppgift> kursUppgifter = new List<Uppgift>();
            this.kursUppgifter = Uppgifter;

        }

        public override string ToString()
        {
            return kursID + " " + kursNamn;
        }

    }
}
