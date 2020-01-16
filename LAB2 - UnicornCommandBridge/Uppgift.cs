using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Uppgift:InterfaceUppg
    {
        public string uppgiftsID { get; set; }
        public string uppgiftsNamn { get; set; }
        public string beskrivning;
        public string kursId;

        public Uppgift(string uppgiftsID, string uppgiftsNamn, string beskrivning, string kursId)
        {
            this.uppgiftsID = uppgiftsID;
            this.uppgiftsNamn = uppgiftsNamn;
            this.beskrivning = beskrivning;
            this.kursId = kursId;
        }

        public override string ToString()
        {
            return uppgiftsID + " " + uppgiftsNamn;
        }

    }
}
