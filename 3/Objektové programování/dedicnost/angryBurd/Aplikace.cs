using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angryBurd
{
    public class Aplikace
    {
        public void Start()
        {
            Postava p1 = new Levacek("Lefty");
            Postava p2 = new Levacek("Leftien");
            Postava p3 = new Pravacek("Righty");
            Postava p4 = new Flash("Flashy");
            Postava p5 = new Flash("Roman");

            p1.GoGoGo();
            p2.GoGoGo();
            p3.GoGoGo();
            p4.GoGoGo();
            p5.GoGoGo();

            p1.ShowMe();
            p2.ShowMe();
            p3.ShowMe();
            p4.ShowMe();
            p5.ShowMe();
        }
    }
}
