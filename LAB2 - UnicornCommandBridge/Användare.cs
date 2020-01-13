using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2___UnicornCommandBridge
{
    class Användare
    {
        public string användarId;
        public string namn;

        public Användare(string användarId, string namn)
        {
            this.användarId = användarId;
            this.namn = namn;
        }
    }
}
