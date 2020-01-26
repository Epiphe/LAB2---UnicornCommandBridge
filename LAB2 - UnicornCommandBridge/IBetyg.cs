namespace LAB2___UnicornCommandBridge
{
    public interface IBetyg
    {
        Student Student { get; set; }
        Uppgift Uppgift { get; set; }
        string uppgiftsbetyg { get; set; }

        string ToString();
    }
}