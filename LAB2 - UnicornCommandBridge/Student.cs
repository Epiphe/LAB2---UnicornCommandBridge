using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Student: Användare
    {
        List<string> betyg = new List<string>();

        public Student(string användarId, string namn) : base(användarId, namn)
        {
            this.betyg = new List<string>();

        }
        public override string ToString()
        {
            return användarId + " " + namn;
        }

        /*private void uppdateraBetygsLista(List<Uppgift> inputA)
        {
            foreach (Uppgift a in inputA)
            {

                foreach (string b in betyg)
                {

                    if (a.uppgiftsID == b)
                    {

                    }
                    else
                    {
                        //.add
                    }
                }
            }
        }*/

    }
}
