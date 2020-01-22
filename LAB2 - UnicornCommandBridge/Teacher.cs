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


        public Teacher(string användarId, string namn) : base(användarId, namn)
        {
            this.kurser = new List<Kurs>();
            this.salary = 0;
        }
        // Vet inte riktitgt hur vi ska göra denhär just nu tbh, behöver tänka lite
        public void UpdateSalary ()
        {

            int ansv = 150;
            int other = 100;


            foreach (Teacher teach in Form1.teachers)
            {
                int ny = 0;

                foreach (Kurs kurs in Form1.kurser)
                {
                    foreach (Teacher T in kurs.larare)
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
