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
        public List<Teacher> Larare { get; set; }
        public List<Student> Elever { get; set; }
        public List<Uppgift> KursUppgifter { get; set; }

        public Kurs(string kursId, string kursNamn)
        {
            this.kursID = kursId;
            this.kursNamn = kursNamn;
            this.Larare = new List<Teacher>();
            this.Elever = new List<Student>();
            this.KursUppgifter = new List<Uppgift>();
        }


        public override string ToString()
        {
            return kursID + " " + kursNamn;
        }

    }
}
