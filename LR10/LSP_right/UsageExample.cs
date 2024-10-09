using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.LSP_right
{
    public class UsageExample
    {
        public void Main()
        {
            Sparrow sparrow = new Sparrow { Name = "Jack" };
            Penguin penguin = new Penguin { Name = "Pingu" };

            LetBirdFly(sparrow);
            // LetBirdFly(penguin); // Это вызовет ошибку компиляции, потому что пингвин не летает
        }

        static void LetBirdFly(IFlyingBird bird)
        {
            bird.Fly();
        }
    }
}
