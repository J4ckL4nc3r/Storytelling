using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class Gallerie : IState
    {
        public void Update()
        {
            Console.WriteLine("Was möchtest du tun?");
        }
        public IState Check()
        {
            if (Console.ReadLine() == "Shop")
            {
                return new Shop();
            }
            else if (Console.ReadLine() == "Innenhof")
            {
                return new Innenhof();
            }
            else if (Console.ReadLine() == "Sonderausstellung")
            {
                return new Sonderausstellung();
            }
            return null;
        }


        public void StartState() //Raumbeschreibung und Handlungsmöglichkeiten
        {
            Console.WriteLine("Du betrittst Die Galerie.Du siehst einen Raum mit vier Vitrinen und ein paar Plakate mit Beschreibungen zu den Ausstellungsstücken.\n" +
                "Von hier aus gelangt man in den Shop, in die Sonderausstellung oder zurück in den Innenhof.\n" +
                " 1. Schwertgriff eines Königs\n" +
                " 2. Dolch eines berühmten Killers\n" +
                " 3. Gehstock eines Wanderers\n" +
                " 4. Ein schwarzer Ring eines Reiters");
        }
        public void EndState()
        {
            Console.WriteLine("Du verlässt die Galerie.");
        }
    }
}
