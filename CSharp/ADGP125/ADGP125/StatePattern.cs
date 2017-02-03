using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    class StatePattern
    {
        public float Damage;
        public float Heal;

        public PlayerState playerState;

        private void Awake()
        {
            playerState = new PlayerState(this);
        }

    }
}
