using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Factory
{
    public abstract class CreatureFactory
    {
        /// <summary>
        /// Abstract Factory for Creatures
        /// </summary>
        /// <returns></returns>
        public abstract ICreature CreateCreature();

        
    
    }
}
