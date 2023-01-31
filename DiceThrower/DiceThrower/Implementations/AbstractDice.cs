using DiceThrower.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower.Implementations
{
    public class AbstractDice : IDice
    {
        public virtual int Throw()
        {
            throw new NotImplementedException();
        }
    }
}
