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
        public string beskrivning;
        public Kurs kurs = null;

        public Uppgift(string uppgiftsID, string uppgiftsNamn, string beskrivning, Kurs kursId)
        {
            this.uppgiftsID = uppgiftsID;
            this.uppgiftsNamn = uppgiftsNamn;
            this.beskrivning = beskrivning;
            this.kurs = kursId;
        }

        public override string ToString()
        {
            return uppgiftsID + " " + uppgiftsNamn;
        }

    }
}
