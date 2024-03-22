using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroytelling
{
    internal interface IState
    {
        public void Update();
        public IState Check();

        public void StartState();
        public void EndState();
    }
}
