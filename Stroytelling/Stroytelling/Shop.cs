using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class Shop : IState
    {
        public void Update()
        {
            Console.WriteLine("Es befinden sich nun 2 Türen im Shop.");
            Console.WriteLine("zu deiner Rechten befindet sich die Galerie.");
            Console.WriteLine("zu deiner Linken der Eingang.");
        }
        public IState Check()
        {
            string input = Console.ReadLine();
            if (input == "Eingang")
            {
                return new Eingang();
            }
            else if (input == "Galerie")
            {
                return new Gallerie();
            }
            return null;
        }

        public void StartState()
        {
            Console.WriteLine("Du stehst nun im Shop.");
            Console.Write("");
            Console.WriteLine("Du betrittst den Souvenir Shop des Museums.");
            Console.WriteLine("Der Raum ist klein und quadratisch, mit Regalen voller Postkarten, Bücher und T-Shirts an allen Wänden.");
            Console.WriteLine("In der Mitte des Raumes steht ein Glastisch mit kleinen Souvenirs wie Schlüsselanhängern und Magneten.");
            Console.WriteLine("An der Decke hängen bunte Lampen, die ein warmes Licht spenden.");
            Console.Write("");
        }
        public void EndState()
        {
            Console.WriteLine("Du Verlässt den Shop");
        }
    }
}
