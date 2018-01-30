using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Iweapon
{
    int AttackPoints { get; set; }

    int DurabilityPoints { get; set; }

    void Attack(ITarget target);
}

