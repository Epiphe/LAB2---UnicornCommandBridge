using System.Collections.Generic;

namespace LAB2___UnicornCommandBridge
{
    public interface IDatastore
    {
        List<Kurs> kurser { get; set; }
        List<Student> students { get; set; }
        List<Teacher> teachers { get; set; }
        List<Uppgift> uppgifter { get; set; }
    }
}