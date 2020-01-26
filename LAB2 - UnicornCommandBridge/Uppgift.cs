using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Uppgift : IUppgift
    {

        public string uppgiftsID { get; set; }
        public string uppgiftsNamn { get; set; }
        public string beskrivning { get; set; }
        public List<Betyg> betyg { get; set; }
        public Kurs kurs { get; set; }

        public Uppgift(string uppgiftsID, string uppgiftsNamn, string beskrivning, Kurs kurs/*, List<Betyg> Betyg*/)
        {
            this.uppgiftsID = uppgiftsID;
            this.uppgiftsNamn = uppgiftsNamn;
            this.beskrivning = beskrivning;
            this.kurs = kurs;
            //this.betyg = Betyg;

        }

        public override string ToString()
        {
            return uppgiftsID + " " + uppgiftsNamn;
        }

    }
}
