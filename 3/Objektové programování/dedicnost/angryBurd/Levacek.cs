using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angryBurd
{
    public class Levacek : Postava
    {
        public Levacek(string name) : base(name)
        {

        }

        public override void GoGoGo()
        {
            x--;
        }
    }
}
