using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    public interface IPlayerTurn
    {
        void UpdatePlayerState();

        void MoveSelection();

        void BattleInitiation();

        void PlayerAttack();

        void OpponentsAttack();

        void SwitchTurn();

        void SwitchPokemon();
    }
}
