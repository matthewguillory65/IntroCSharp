using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfaces.Damagable;

namespace Interfaces
{
    class Zombie : IDamagable, IDamager
    {
        int power = 30;
        int health = 200;
    }
}
