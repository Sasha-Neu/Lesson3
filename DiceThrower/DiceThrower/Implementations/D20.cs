using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower.Implementations
{
    public class D20 : AbstractDice
    {
        public override int Throw()
        {
            return GenerateRandomNumber(20);
        }
    }
}
