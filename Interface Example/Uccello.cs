using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface_Example
{
    internal class Uccello : Animale
    {
        public string name { get; set; }
        public string colore { get; set; }
        public int velocitaMaxKmh { get; set; }

        public bool isDomestic = true;

        public Uccello(string name, string colore, int velocitaMaxKmh, bool isDomestic)
        {
            this.name = name;
            this.colore = colore;
            this.velocitaMaxKmh = velocitaMaxKmh;
            this.isDomestic = isDomestic;

        }

        public void faVerso()
        {
            Console.WriteLine("piu piu");
        }
        public void siMuove()
        {
            Console.WriteLine("vola");
        }

        public string showColor()
        {
            return colore;
        }



    }
}
