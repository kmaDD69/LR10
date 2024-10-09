using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.LSP_wrong
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Penguins can't fly.");
        }
    }
}
