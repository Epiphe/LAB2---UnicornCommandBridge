using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    abstract class Admin: Användare
    {
        public Admin(string användarId, string namn) : base(användarId, namn)
        {

        }

        
    }
}
