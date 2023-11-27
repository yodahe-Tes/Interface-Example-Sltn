using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    internal class Cane : Animale
    {

        public string name { get; set; }
        public string colore { get; set; }
        public int velocitaMaxKmh { get; set; }

        public bool isDomestic = true;

        public Cane(string name, string colore, int velocitaMaxKmh, bool isDomestic)
        {
            this.name = name;
            this.colore = colore;
            this.velocitaMaxKmh = velocitaMaxKmh;
            this.isDomestic = isDomestic;

        }


        public void faVerso()
        {
            Console.WriteLine("Woof");
        }

        public string showColor()
        {
            return colore;
        }

        public void siMuove()
        {
            Console.WriteLine("Corre");


        }

        public void comportamento()
        {

            Console.WriteLine("Morde");

        }
    }
}
