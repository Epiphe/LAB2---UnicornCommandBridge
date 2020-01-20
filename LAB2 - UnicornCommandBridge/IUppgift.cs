namespace LAB2___UnicornCommandBridge
{
    public interface IUppgift
    {
        string uppgiftsID { get; set; }
        string uppgiftsNamn { get; set; }

        string ToString();
    }
}