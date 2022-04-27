using GameFramework.Entity;
using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Creature
{
    public class Creature : ICreature
    {
        public int AttackDamge { get; set;  }
        public int DamageReduction { get; set ; } 
        public bool IsAlive { get; set; }
        public string Name { get;  set; } 

        public string Description { get; set; }
        public bool isAlive { get; set; }
        public int HitPoints { get; set; }

        public Position Position { get; set; }
        public List<WorldObject> Inventory { get; set; }

        public Creature(TraceSource ts)
        {
            ts.TraceEvent(TraceEventType.Information, 50, "Beast created");
        }

        public Creature(string name, int attackdamage, int damagereduction, string description, bool isalive, int hitpoints, Position pos, List<WorldObject> inventory)
        {
            Name = name;
            AttackDamge = attackdamage;
            DamageReduction = damagereduction;
            Description = description;
            IsAlive = isalive;
            HitPoints = hitpoints;
            Position = pos;
            Inventory = inventory;
        }

        public int Attack(int damagePoints)
        {
            return damagePoints;
        }

        public void RecieveDamage(int damagePoints, Creature creature)
        {
            AttackDamge = damagePoints;
            int ReductionAlgo = ((DamageReduction / 100) * damagePoints);
            creature.HitPoints = (damagePoints - ReductionAlgo);
            Console.WriteLine($"Damage: {ReductionAlgo}");
            if (creature.HitPoints <= 0)
            {
                Console.WriteLine($"The mighty {creature.Name} has fallen");
                creature.IsAlive = false;
            };
        }

        public void Loot(WorldObject wObj)
        {
            if (wObj.Lootable)
            {
            Inventory.Add(wObj);  
            }
        }
    }
}

