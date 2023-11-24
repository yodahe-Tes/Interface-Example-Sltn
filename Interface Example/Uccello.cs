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
        private string name { get; set; }
        public String colore { get; set; }
        public int velocitaMaxKmh { get; set; }
        public Boolean isDomestic = false;

        public Uccello(string name, string colore, int velocitaMaxKmh,  bool isDomestic)
        {
            this.name = name;
            this.colore = colore;
            this.velocitaMaxKmh = velocitaMaxKmh;
            this.isDomestic = isDomestic;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string Nome)
        {
            this.name = Nome;
        }

        public string getColore()
        {
            return this.colore;
        }

        public void setColore(string color)
        {
            this.colore = color;
        }

        public int getVelocitMax()
        {
            return velocitaMaxKmh;
        }
        public void setVelocMax(int velocM)
        {
            this.velocitaMaxKmh = velocM;
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
