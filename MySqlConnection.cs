using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class MySqlConnection
    {
        private string costring;

        public MySqlConnection(string costring)
        {
            this.costring = costring;
        }
    }
}
