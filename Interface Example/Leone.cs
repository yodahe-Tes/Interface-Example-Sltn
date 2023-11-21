using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    internal class Leone : Animale
    {

        public String colore = "default";
        public void faVerso()
        {
            Console.WriteLine("Roar");
        }

        public void showColor()
        {
            Console.WriteLine(colore);
        }

        public void siMuove()
        {
            Console.WriteLine("Corre");


        }

        public void comportamento() {

            Console.WriteLine("Morde");

        }
    }
}
