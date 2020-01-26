using System.Collections.Generic;

namespace LAB2___UnicornCommandBridge
{
    public interface IUppgift
    {
        string beskrivning { get; set; }
        List<Betyg> betyg { get; set; }
        Kurs kurs { get; set; }
        string uppgiftsID { get; set; }
        string uppgiftsNamn { get; set; }

        string ToString();
    }
}