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
        public string beskrivning;
        public string kursId;

        public Uppgift(string uppgiftsID, string beskrivning, string kursId)
        {
            this.uppgiftsID = uppgiftsID;
            this.beskrivning = beskrivning;
            this.kursId = kursId;
        }

    }
}
