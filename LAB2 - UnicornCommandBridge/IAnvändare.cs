using System.Collections.Generic;

namespace LAB2___UnicornCommandBridge
{
    public interface IAnvändare
    {
        string användarId { get; set; }
        List<Kurs> Kurser { get; set; }
        string namn { get; set; }
    }
}