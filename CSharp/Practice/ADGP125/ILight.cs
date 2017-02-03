using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    public interface ILight {
        void Enter();
        void RedLightFunction();
        void GreenLightFunction();
        void YellowLightFunction();
        void Update();
        void Exit();
    }
}
