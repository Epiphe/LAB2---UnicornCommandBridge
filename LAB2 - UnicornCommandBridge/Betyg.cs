using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Betyg : IBetyg
    {
        public string uppgiftsbetyg { get; set; }
        Student Student { get; set; }
        Uppgift Uppgift { get; set; }

        public Betyg(string uppgiftsbetyg, Student student, Uppgift uppgift)
        {
            this.uppgiftsbetyg = uppgiftsbetyg;
            this.Student = student;
            this.Uppgift = uppgift;
        }

     }
}
