namespace LAB2___UnicornCommandBridge
{
    public interface ITeacher
    {
        Datastore Datastore { get; set; }
        int salary { get; set; }

        string ToString();
        void UpdateSalary(Datastore datastore);
    }
}