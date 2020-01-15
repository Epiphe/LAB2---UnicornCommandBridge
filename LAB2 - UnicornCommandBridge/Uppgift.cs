using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Uppgift
    {
        public string uppgiftsID;
        public string uppgiftsNamn;
        public string beskrivning;
        public string kursId;

        public Uppgift(string uppgiftsID, string uppgiftsnamn, string beskrivning, string kursId)
        {
            this.uppgiftsID = uppgiftsID;
            this.uppgiftsNamn = uppgiftsNamn;
            this.beskrivning = beskrivning;
            this.kursId = kursId;
        }

    }
}
