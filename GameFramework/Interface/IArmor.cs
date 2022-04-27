using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interface
{
    public interface IArmor
    {
        /// <summary>
        /// Interface for all defense type items
        /// </summary>
        public int ReduceDamage { get; }
    }
}
