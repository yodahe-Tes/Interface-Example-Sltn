using Interface_Example;
using System;
using System.Collections.Generic;
using System;
using System.IO; // types for managing the filesystem
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.IO.Compression;
using System.Xml;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

using NuJson = System.Text.Json.JsonSerializer;
using System.Linq;
namespace InterfaceExample // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Leone simba = new Leone("Simba", "brown", 50, false);
            Uccello mario = new Uccello("Mario", "yellow", 15, true);
            Serpente gustavo = new Serpente("Gustavo", "brown", 5, false);
            Cane pluto = new Cane("Pluto", "White", 30, true);
           
            



            // simba.faVerso();
            // mario.faVerso();

            //  simba.siMuove();
            //  mario.siMuove();



            List<Animale> animali = new List<Animale>();


            //animali.Add(mufasa);
            //animali.Add(simba);
            //animali.Add(mario);
            //animali.Add(gustavo);
            //animali.Add(pluto);

            // Esempio Linq

            //var animalBrownFiltered = animali.Where(a => a.showColor().Contains("brown")).ToList<Animale>();
            //foreach (var item in animalBrownFiltered)
            //{
            //    item.faVerso();
            //}
            Leone mufasa = new Leone("Mufasa", "yellow", 70, false);
            Leone buffo = new Leone("buffo", "brown", 50, false);

            Leone mammo = new Leone("mammo", "brown", 50, false);
            Leone pippo = new Leone("buffo", "yellow", 50, false);

            List<Leone> leoni = new List<Leone>();

            leoni.Add(buffo);
            leoni.Add(mammo);
            leoni.Add(pippo);
            leoni.Add(simba);
            leoni.Add(mufasa);


            var nuovaListaLeoni = leoni.Where(item => item.showColor().Contains("brown"))
                                    .Select(x => new {  nuovoNome = x.getName()}).ToList();



            //foreach (var item in nuovaListaLeoni)
            //{

            //    Console.WriteLine($"Nome: {item.nuovoNome}");
            //}
            //foreach (var item in nuovaListaLeoni)
            //{
            //    Console.WriteLine(item.nuovoVeloc);

            //}

            string jsonPath = Combine(CurrentDirectory, "animali.json");

            using (StreamWriter jsonStream = File.CreateText(jsonPath))
            {
                var jss = new Newtonsoft.Json.JsonSerializer();
                // serialize the object graph into a string 
                jss.Serialize(jsonStream, animali);
            }

            // Display the serialized object graph 
            WriteLine(File.ReadAllText(jsonPath));


            // Deserializing JSON using new APIs

            using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
            {
                // deserialize object graph into a List of Person 
                var loadLeone = (List<Leone>)
                    NuJson.Deserialize(utf8Json: jsonLoad, returnType: typeof(List<Leone>));

                foreach (var item in loadLeone)
                {
                    WriteLine("{0} has {1} domestic", item.colore, item.velocitaMaxKmh);
                }
            }



        }
        }
    
}