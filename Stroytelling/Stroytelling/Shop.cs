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
            Console.WriteLine("");
        }
        public IState Check()
        {
            if (Console.ReadLine() == "Eingang")
            {
                return new Eingang();
            }
            else if (Console.ReadLine() == "Gallerie")
            {
                return new Gallerie();
            }
            return null;
        }

        public void StartState()
        {
            Console.WriteLine("");
        }
        public void EndState()
        {
            Console.WriteLine("");
        }
    }
}
