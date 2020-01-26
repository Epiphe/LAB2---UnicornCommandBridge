using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Teacher : Användare, ITeacher
    {

        public int salary { get; set; }
        public List<Kurs> kurser = new List<Kurs>();

        public Teacher(string användarId, string namn) : base(användarId, namn)
        {
            this.kurser = new List<Kurs>();
            this.salary = 0;
        }

        public Datastore Datastore { get; set; }

        public void UpdateSalary (Datastore datastore)
        {
            Datastore = datastore;
            int ansv = 150;
            int other = 100;


            foreach (Teacher teach in Datastore.teachers)
            {
                int ny = 0;

                foreach (Kurs kurs in Datastore.kurser)
                {
                    foreach (Teacher T in kurs.Larare)
                    {
                        if (T.användarId == teach.användarId)
                        {
                            ny = ny + other;
                        }
                    }

                    if (teach.användarId == kurs.AnsvLarare.användarId)
                    {
                        ny = ny + ansv;
                    }
                }
                teach.salary = ny;
            }

        }

        public override string ToString()
        {
            return användarId + " " + namn;
        }
    }
}
