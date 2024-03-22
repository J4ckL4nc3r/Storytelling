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
            if (Console.ReadLine() == "s")
            {
                return new HERE_NEW_ROOM();
            }
            return null;
        }

        public void StartState()
        {
            Console.WriteLine("zZzZ");
        }
        public void EndState()
        {
            Console.WriteLine("Waking up");
        }
    }
}
