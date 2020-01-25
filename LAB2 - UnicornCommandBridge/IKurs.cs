using System.Collections.Generic;

namespace LAB2___UnicornCommandBridge
{
    public interface IKurs
    {
        Teacher AnsvLarare { get; set; }
        List<Student> Elever { get; set; }
        string kursID { get; set; }
        string kursNamn { get; set; }
        List<Uppgift> KursUppgifter { get; set; }
        List<Teacher> Larare { get; set; }

        string ToString();
    }
}