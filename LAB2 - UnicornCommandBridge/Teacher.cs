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

            foreach (Kurs k in Form1.kurser)
            {
                foreach (Teacher teach in k.larare)
                {
                    teach.salary = salary + other;
                }
                k.AnsvLarare.salary = salary + ansv;
            }

        }

        public override string ToString()
        {
            return användarId + " " + namn;
        }
    }
}
