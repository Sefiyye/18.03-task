using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Şkaf : Mebel
    {
        public string Design;

        public Şkaf(string color, string materials) : base(color, materials)
        {
        }

        public Şkaf(string color, string materials, string design) : base(color, materials)
        {
            Design = design;

        }

        public override void Lifeless()
        {
            Console.WriteLine("Cansizdir");
        }

        public override void Movement()
        {
            Console.WriteLine("Şkaf hərəkət etmir");
        }
    }
}
