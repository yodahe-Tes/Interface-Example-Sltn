using Interface_Example;
using System;
using System.Collections.Generic;

namespace InterfaceExample // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leone simba = new Leone();
            Uccello mario = new Uccello();

           // simba.faVerso();
           // mario.faVerso();

          //  simba.siMuove();
          //  mario.siMuove();

            Animale anim = simba;


           // anim.siMuove();
            anim = mario;
            //anim.siMuove();

            List<Animale> animali = new List<Animale>();
            animali.Add(simba);

            Leone mufasa = new Leone();
            mufasa.colore = "giallo";
            animali.Add(mufasa);

            animali.Add(new Uccello());

            foreach (var item in animali)
            {
                item.faVerso();
                //Console.WriteLine(item.colore);
            }
        }
    }
}