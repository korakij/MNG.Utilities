using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNG.Utilities.Samples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Util.AppendFile("charges.csv", "C-181109-01", DateTime.Now, 100.20);
            Util.AppendFile("charges.csv", "C-181109-02", DateTime.Now, 200.10);
            Util.AppendFile("charges.csv", "C-181109-03", DateTime.Now, 120.20);
        }
    }
}
