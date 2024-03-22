using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class Ausstellungsraum : IState
    {
        public void Update()
        {
            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("Bitte gib den Namen des Zielraums ein.");
        }
        public IState Check()
        {
            if (Console.ReadLine() == "Innenhof")
            {
                if (Innenhof.hasKey)
                {
                    return new Innenhof();
                }
                else
                {
                    Console.WriteLine("Die Tür ist verschlossen.");
                }
                
            }
            else if (Console.ReadLine() == "Sonderaustellung")
            {
                return new Sonderausstellung();
            }
            else if(Console.ReadLine() == "Eingang")
            {
                return new Eingang();
            }
            return null;
        }

        public void StartState()
        {
            Console.WriteLine("Du betrittst den Austellungsraum!");
            Console.WriteLine("Das erste was dir auffällt sind die Riesigen gehege welche im Raum verteilt sind.");
            Console.WriteLine("Die Gehege sind gefüllt mit phantastischen Tieren.");
            Console.WriteLine();
            Console.WriteLine("Zu deiner linken befidet sich der Weg zur Sonderausstellung, direkt zwischen dem Gehege einer Acromantula und dem Gehege eines Greif.");
            Console.WriteLine("Gegenüber von dir befindet sich eine Türe auf der Security steht.");
            Console.WriteLine("Zu deiner rechten befindet das Gehege in dem ein Irrwicht zu sehen ist.");
            Console.WriteLine("Neben dem Gehege des Irrwichts befindet sich der Weg zum Eingang des Museums.");
            Console.WriteLine("Der Rest des Ausstellungsraums ist gefüllt mit kleineren Gehegen für andere Tiere.");
            Console.WriteLine();
        }
        public void EndState()
        {
            Console.WriteLine("Du verlässt den Austellungsraum!");
        }
    }
}
