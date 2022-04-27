using GameFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interface
{
    public interface IWeaponFactory
    {
        public IItem ForgeWeapon(ItemCategory category);
    }
}
