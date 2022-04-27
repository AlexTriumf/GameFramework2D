using GameFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interface
{
    /// <summary>
    /// Interface for creatures
    /// </summary>
    public interface ICreature
    {

       string Name { get; set; }
       string Description { get; set; }
       bool isAlive { get; set; }
       int HitPoints { get; set; }


    }
}
