using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower.Implementations
{
    public class LoadedD20 : AbstractDice
    {
        public override int Throw()
        {
            int result = GenerateRandomNumber(100);

            if (result < 21)
            {
                return result;
            }
            else
            {
                return 20;
            }
        }
    }
}
