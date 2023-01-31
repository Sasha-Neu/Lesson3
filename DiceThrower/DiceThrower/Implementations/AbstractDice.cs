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
        private Random _random;

        public AbstractDice()
        {
            _random = new Random();
        }

        public virtual int Throw()
        {
            throw new NotImplementedException();
        }

        protected int GenerateRandomNumber(int maxNumber)
        {
            return _random.Next(maxNumber + 1);
        }
    }
}
