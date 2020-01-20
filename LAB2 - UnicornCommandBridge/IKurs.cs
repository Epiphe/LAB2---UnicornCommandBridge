using System.Collections.Generic;

namespace LAB2___UnicornCommandBridge
{
    public interface IKurs
    {
        Teacher AnsvLarare { get; set; }
        List<Student> elever { get; set; }
        string kursID { get; set; }
        string kursNamn { get; set; }
        List<Uppgift> kursUppgifter { get; set; }
        List<Teacher> larare { get; set; }

        string ToString();
    }
}