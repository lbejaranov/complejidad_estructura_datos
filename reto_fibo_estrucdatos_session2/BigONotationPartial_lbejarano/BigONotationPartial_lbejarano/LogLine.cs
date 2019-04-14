using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BigONotationPartial_lbejarano
{
    class LogLine
    {
        int counter;
        public LogLine(int counter)
        {
            this.counter = counter;
        }

        public string GetIP()
        {
            return "ip-" + counter;
        }
    }
}
