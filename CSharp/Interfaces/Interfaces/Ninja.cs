using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfaces.Damagable;
using static Interfaces.Damager;

namespace Interfaces
{
    class Ninja : IDamagable, IDamager
    {
        int power = 15;
        int health = 150;
    }
}
