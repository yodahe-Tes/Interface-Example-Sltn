using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface_Example
{
    internal class Serpente : Animale
    {
        public string name { get; set; }
        public string colore { get; set; }
        public int velocitaMaxKmh { get; set; }

        public bool isDomestic = false;

        public Serpente(string name, string colore, int velocitaMaxKmh, bool isDomestic)
        {
            this.name = name;
            this.colore = colore;
            this.velocitaMaxKmh = velocitaMaxKmh;
            this.isDomestic = isDomestic;

        }

        public void faVerso()
        {
            Console.WriteLine("SSSSSSS");
        }

        public string showColor()
        {
            return colore;
        }


        public void siMuove()
        {
            Console.WriteLine("Striscia");


        }

        public void comportamento()
        {

            Console.WriteLine("Morde");

        }
    }
}
