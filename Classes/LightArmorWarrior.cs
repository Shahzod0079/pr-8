using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LightArmorWarrior : Warrior
{
    public LightArmorWarrior(string name, int health) : base(name, health) { }
    public override void TakeDamage(int damage)
    {
        int reducedDamage = (int)(damage * 0.7);
        base.TakeDamage(reducedDamage);
    }
}