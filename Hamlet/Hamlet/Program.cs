using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamlet
{
    class Hamlet
    {
        public string MostWords { get; set; }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            string Hamlet = File.ReadAllText("/Projects/week01/Day03/Hamlet/Hamlet");
        }
    }
}
