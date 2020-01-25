using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Kurs : IKurs
    {
        public Kurs()
        {
            Larare = new List<Teacher>();
            Elever = new List<Student>();
            KursUppgifter = new List<Uppgift>();
        }

        public string kursID { get; set; }
        public string kursNamn { get; set; }

        public Teacher AnsvLarare { get; set; }
        public List<Teacher> Larare { get; set; }
        public List<Student> Elever { get; set; }
        public List<Uppgift> KursUppgifter { get; set; }

        public Kurs(string kursId, string kursNamn)
        {
            this.kursID = kursId;
            this.kursNamn = kursNamn;
        }

        public Kurs(Teacher ansvLarare, List<Teacher> Larare, List<Student> Elever, List<Uppgift> Uppgifter)
        {
            this.AnsvLarare = ansvLarare;
            this.Larare = Larare;
            this.Elever = Elever;
            this.KursUppgifter = Uppgifter;
        }

        public override string ToString()
        {
            return kursID + " " + kursNamn;
        }

    }
}
