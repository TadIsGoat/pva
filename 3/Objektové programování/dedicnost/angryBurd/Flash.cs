using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angryBurd
{
    public class Flash : Postava
    {
        public Flash(string name) : base(name)
        {

        }

        public override void GoGoGo()
        {
            Random r = new Random();
            int x = r.Next(0, 10);
            int y = r.Next(10);

            this.x = x;
            this.y = y;
        }
    }
}
