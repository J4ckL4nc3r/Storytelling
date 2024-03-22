using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class Sonderausstellung : IState
    {
        public IState Check()
        {
            string input = Console.ReadLine();
            
            if (input == "WC")
            {
                return new WC();
            }
            else if (input == "Galerie")
            {
                return new Gallerie();
            }
            else if (input == "Ausstellungsraum")
            {
                return new Ausstellungsraum();
            }
            return null;
        }

        public void StartState()
        {
            Console.WriteLine("Du betrittst die Sonderausstellung." +
                "\nDieser große Raum ist gepflastert von Marmor und seine Kuppeldecke erstreckt sich bis zu 6 Meter in die Höhe." +
                "\nAn den weißen, unnatürlich sauberen Wänden sind meterlange Banner befestigt, welche alle ein und das selbe Objekt in verschiedenen Ansichten darstellen... Ein goldenes Götzenbild." +
                "\nDieses Kunstobjekt siehst du direkt vor dir, in der Mitte des großen Raums. Es ist gut von allen Seiten beleuchtet, so dass das Augenmerkt gar nicht anders kann als darauf gelenkt zu werden." +
                "\nDies ist dein Ziel, das Objekt deiner Begierde. Alles was dich daran hindert, es zu erlangen, ist eine simple Glasvitrine... und natürlich die Alarmanlage.");
        }

        public void Update()
        {
            Console.WriteLine("Von der Sonderausstellung kannst du in drei Richtungen gehen:" +
                "\n1. Im Westen geht es zur Galerie." +
                "\n2. In Süden geht es Richtung Ausstellungsraum." +
                "\n3. Im Osten befindet sich das WC.");
        }

        public void EndState()
        {
            Console.WriteLine("Du verlässt die Sonderausstellung.");
        }
    }
}
