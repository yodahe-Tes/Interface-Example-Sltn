using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    internal class Uccello : Animale
    {
        String colore = "default";
        public void faVerso()
        {
            Console.WriteLine("piu piu");
        }
        public void siMuove()
        {
            Console.WriteLine("vola");
        }

        public void showColor()
        {
            Console.WriteLine(colore);
        }


    }
}
