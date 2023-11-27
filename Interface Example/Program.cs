using Interface_Example;
using Newtonsoft.Json;
using static System.Console;
using static System.Environment;
using static System.IO.Path;


namespace InterfaceExample // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea animali
            Leone simba = new Leone("Simba", "brown", 50, false);
            Uccello mario = new Uccello("Mario", "yellow", 15, true);
            Serpente gustavo = new Serpente("Gustavo", "brown", 5, false);
            Cane pluto = new Cane("Pluto", "White", 30, true);


            List<Animale> animali = new List<Animale>(); // NoOP


            // Crea Leoni


            // Scrittura snella
            Leone mufasa = new("Mufasa", "yellow", 70, false);

            // Utilizzo di Var che verrà titpizzata al primo utilizzo 
            var buffo = new Leone("buffo", "brown", 50, false);

            //scrittura estesa
            Leone mammo = new Leone("mammo", "brown", 50, false);
            Leone pippo = new Leone("buffo", "yellow", 50, false);



            // Crea la lista di Leoni
            var leoni = new List<Leone>();

            // Aggiunge leoni alla lista
            leoni.Add(buffo);
            leoni.Add(mammo);
            leoni.Add(pippo);
            leoni.Add(simba);
            leoni.Add(mufasa);


            // filtra la listain una sottolista non tipizzata
            var nuovaListaLeoni = leoni.Where(item => item.showColor().Contains("brown"))
                                    .Select(x => new { nuovoNome = x.getName() }).ToList();


            //Creo il path del file da utilizzare
            string jsonPath = Combine(CurrentDirectory, "animali.json");

            //Utilizzo la calsse statica del NewtonSoft
            var js2 = JsonConvert.SerializeObject(leoni);
            // Utilizzo File.Write all della classe System.IO ( che gestisce in autonomia lo stream )
            File.WriteAllText(jsonPath, js2);

            // Display the serialized object graph 
            WriteLine(File.ReadAllText(jsonPath));

            //Rileggere il file serializzato appoggiandolo in una stringa
            string buff = File.ReadAllText(jsonPath);

            //Ricrea la lista di Obj Leone a partire dalla stringa Json 
            var loadLeone = JsonConvert.DeserializeObject<List<Leone>>(buff);


            // controlla l'esistenza dell'obj
            if (loadLeone != null)
            {
                // se l'obj esiste lo scrive a video
                foreach (var item in loadLeone)
                {
                    WriteLine("{0} has {1} domestic", item.colore, item.velocitaMaxKmh);
                }
            }
            else
            {
                Console.Write("La Lista di Leoni è vuota");
            }



        }
    }

}