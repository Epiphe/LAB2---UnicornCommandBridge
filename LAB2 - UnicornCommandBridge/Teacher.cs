using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    public class Teacher : Användare, ITeacher
    {

        public Teacher(string användarId, string namn) : base(användarId, namn)
        {

        }

        public override string ToString()
        {
            return användarId + " " + namn;
        }
    }
}
