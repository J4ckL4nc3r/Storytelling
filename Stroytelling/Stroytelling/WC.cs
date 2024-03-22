using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal class WC : IState
    {
        public void Update()
        {
            Console.WriteLine("Gebe Innenhof ein um von vorn zu Starten");
        }
        public IState Check()
        {
            string input = Console.ReadLine();
            if (input == "Innenhof")
            {
                return new Innenhof();
            }
            return null;
        }

        public void StartState()
        {
            Console.WriteLine("Du schaust vorsichtig in das WC.");
            Console.Write("");
            Console.WriteLine("Ein kalter Schauer läuft dem Dieb über den Rücken, als er einen kurzen Blick in das WC wirft.");
            Console.WriteLine("Statt der erhofften Leere erwartet ihn dort ein unerwartetes Bild:");
            Console.WriteLine("Der Wärter, ein bulliger Mann mit einem Gesicht wie ein Backstein, sitzt auf der Toilette und ist vollkommen versunken in sein Handy.");
            Console.Write("");
            Console.WriteLine("Den grimmigen Blick fest auf den Bildschirm gerichtet, tippte er mit seinen dicken Fingern auf das Display.");
            Console.WriteLine("Ein leises Summen und Piepen drang aus dem Gerät, unterbrochen von gelegentlichen Flüchen des Wärters.");
            Console.WriteLine("Mist! fluchte er gerade, als er seinen Clan im Spiel angegriffen sah.");
            Console.Write("");
            Console.WriteLine("Plötzlich hob er den Kopf und sah den Dieb mit seinen stechenden Augen an.");
            Console.WriteLine("Was machst du denn da? brüllte er. Hast du nichts Besseres zu tun, als mich beim Scheißen zu belästigen ?");
            Console.Write("");
        }
        public void EndState()
        {
            Console.WriteLine("Spiel wird neu gestartet.");
        }
    }
}
