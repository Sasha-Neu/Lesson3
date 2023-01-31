using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower.Interfaces
{
    /// <summary>
    /// Dice interface
    /// </summary>
    public interface IDice
    {
        /// <summary>
        /// Throwing the dice
        /// </summary>
        /// <returns>The result</returns>
        int Throw();
    }
}
