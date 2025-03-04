using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angryBurd
{
    public class Postava
    {
        protected int x = 0;
        protected int y = 0;
        protected string name;

        public Postava(string name)
        {
            this.name = name;
        }

        public virtual void GoGoGo()
        {

        }

        public void ShowMe()
        {
            Console.WriteLine($"{name} [{x}, {y}]");
        }
    }
}
