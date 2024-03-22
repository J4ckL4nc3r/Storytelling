using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class Eingang : IState
    {
        public void Update()
        {
            Console.WriteLine("Sleeping");
        }
        public IState Check()
        {
            if (Console.ReadLine() == "Gallerie")
            {
                return new Gallerie();
            }
            else if(Console.ReadLine() == "Schreibtisch")
            {
                if (!Innenhof.hasKey)
                {
                    Innenhof.hasKey = true;
                    Console.WriteLine("Du hast den Schreibtisch des Wärters durchsucht und einen Universalschlüssel gefunden!");
                }
                else
                {
                    Console.WriteLine("Der Schreibtisch ist leer. Du hast den Schlüssel bereits gefunden.");
                }
                
            }
            else if(Console.ReadLine() == "Haupteingang")
            {
                Console.WriteLine("Die Tür ist verschlossen. Warum willst du schon gehen?");
            }
            return null;
        }

        public void StartState()
        {
            // Raumbeschreibung
            Console.WriteLine("Du hast den Eingang betreten. Davor stehen viele verschiedene Regale, in denen unterschiedliche Zeitschriften\n" +
                "zu sehen sind. An der Wand hängt ein großes Plakat mit der Maya-Statue und der Aufschrift 'Jetzt neu in der Hauptausstellung'.\n" +
                "Vor dem Haupteingang befindet sich ein Pult. Das Pult scheint als Rezeption zu dienen. Hinter dem Pult befindet\n" +
                "sich ein kleiner Schreibtisch, der einem Wachmann zu gehören scheint.");

            // Türen & Objekte
            Console.WriteLine("Hinter dir ist die Tür, die wieder in die Gallerie führt. Davor stehen das Pult und der Schreibtisch des Wärters.\n" +
                "Vor dem Pult, auf der anderen Seite des Eingangs, befindet sich der Haupteingang, der nach draußen führt.");
        }
        public void EndState()
        {
            Console.WriteLine("Waking up");
        }
    }
}
