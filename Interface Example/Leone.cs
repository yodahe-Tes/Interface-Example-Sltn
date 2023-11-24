using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface_Example
{
    internal class Leone : Animale
    {
        private string name;
        public string colore;
        public int velocitaMaxKmh;

        public bool? isDomestic = false;

        public Leone(string Name, string Colore, int VelocitaMaxKmh, bool? IsDomestic)
        {
            this.name = Name;
            this.colore = Colore;
            this.velocitaMaxKmh = VelocitaMaxKmh;
            this.isDomestic = IsDomestic;
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
            Console.WriteLine("Roar");
        }

        public string showColor()
        {
            return colore;
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
