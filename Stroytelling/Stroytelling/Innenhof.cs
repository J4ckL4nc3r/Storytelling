using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class Innenhof : IState
    {
        // Static bool (Gibt an ob Spieler den Schlüssel hat)
        public static bool hasKey = false;

        public void Update()
        {
            Console.WriteLine("Galerie");
            Console.WriteLine("Ausstellung");
        }
        public IState Check()
        {
            if (Console.ReadLine() == "Galerie")
            {
                return new Gallerie();
            }
            else if(Console.ReadLine() == "Ausstellung")
            {
                if (hasKey)
                {
                    return new Ausstellungsraum();
                }
                else
                {
                    Console.WriteLine("Die Tür ist verschlossen! Eventuell brauchst du einen Schlüssel?");
                }
            }
            return null;
        }

        public void StartState()
        {
            // Story Einleitung
            Console.WriteLine("Dein Einbruch ist geglückt, du hast es bis in den Innenhof geschafft! Dein Ziel ist eine neu angelieferte Maya-Statue.\n" +
                "Die Statue soll einen alten Gott darstellen und besteht aus purem Gold. Nach deinen Informationen befindet sich die Statue in der\n" +
                "Sonderausstellung in einer eigens dafür eingerichteten Vitrine.");

            // Raumbeschreibung
            Console.WriteLine("Der Innenhof hat die Form eines Oktogons und ist mit Ziegeln gepflastert. An den Wänden in der Ecke stehen\n" +
                "sonderbare Pflanzen, welche du noch nie zuvor gesehen hast. In der Mitte befindet sich eine Säule mit Eingravierungen\n" +
                "welche für dich keinen Sinn zu ergeben scheinen. Um die Säule herum befinden sich Sitzbänke welche bereits sehr heruntergekommen aussehen, manche\n" +
                "davon scheinen sogar nicht mehr zu gebrauchen zu sein. Die Wände sind vollgeschmiert mit irgendwelchem Schmodder den der Regen von den\n" +
                "Dächern die Wänder runtergespült hat.");

            // Tür Beschreibungen
            Console.WriteLine("Rechts hinter dir befindet sich eine schwarze Tür mit der Aufschrift 'Ausstellungsraum'. Die Tür scheint jedoch verschlossen zu sein\n" +
                "Links vor dir befindet sich eine weitere, rote Tür. Die Tür hat die Aufschrift 'Gallerie' und durch den Türspalt kannst du ein\n" +
                "leichtes Licht sehen. Die Tür scheint offen zu sein.");
        }
        public void EndState()
        {
            Console.WriteLine("Du verlässt den Innenhof!");
        }
    }
}
