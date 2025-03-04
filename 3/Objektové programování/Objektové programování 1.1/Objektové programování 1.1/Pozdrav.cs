//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Objektové_programování_1._1
{
    internal class Pozdrav
    {
        public void Pozdraveni(string jmeno)
        {
            Console.WriteLine("Ahoj {0}", jmeno);

            
        }

        public string text;

        public string Pozdravit (string jmeno)
        {
            return String.Format($"{text} {jmeno}");
        }
    }
}
