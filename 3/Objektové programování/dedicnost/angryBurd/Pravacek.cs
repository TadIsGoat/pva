using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angryBurd
{
    public class Pravacek : Postava
    {
        public Pravacek(string name) : base(name)
        {
            
        }

        public override void GoGoGo()
        {
            this.x = x + 3;
        }
    }
}
