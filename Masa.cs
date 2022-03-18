using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Masa : Mebel
    {
        public string Species;

        public Masa(string color, string materials,string species ):base(color,materials)

        {
            Species = species;
        }

        public override void Lifeless()
        {
            Console.WriteLine("Cansizdir");
        }

        public override void Movement()
        {
            Console.WriteLine("Masa hereket etmir");
        }
    }
}
