using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.LSP_right
{
    public class Sparrow : Bird, IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("The sparrow is flying.");
        }
    }
}
