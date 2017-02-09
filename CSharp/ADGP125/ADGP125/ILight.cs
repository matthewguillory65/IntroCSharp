using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    public interface ILight
    {
        void Update();
        bool Exit(ILight currentState);
        void Enter();
    }
}
