using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatFSM
{
    class Combat
    {
        public enum CombatState
        {
            INIT = 0,
            ATTACK = 1,
            DEFEND = 2,
        }
        public Combat() { }
        public void EndofTurn() { }

        public void Attack() { }

        public void Defend() { }

        //public void SetState(State state)
        //{
        //    switch (state)
        //    {
        //        case State.ATTACK:
        //            {
        //                combat.Attack();
        //                break;
        //            }
        //        case State.DEFEND:
        //            {
        //                combat.Defend();
        //                break;
        //            }
        //        case State.INIT:
        //            {
        //                combat.EndofTurn();
        //                break;
        //            }
        //    }
        //}
    }


   





    public class Party
    {
        public List<Player> Players = new List<Player>();
        /// <summary>
        /// Constructor
        /// </summary>
        public Party() { }
        public void AddPlayer(Player p)
        {
            Players.Add(p);
        }

        public delegate void Nextplayer();

        public Nextplayer nextPlayer;

        /// <summary>
        /// Switches to the Next Player
        /// </summary>
        /// <returns></returns>
        public bool NextPlayer()
        {
            if (nextPlayer != null)
            {
                nextPlayer.Invoke();
            }
            return true;
        }
    }

    public class Player
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Player() { }

        public delegate void OnEndTurn();

        public OnEndTurn onEndTurn;

        /// <summary>
        /// Ends the turn
        /// </summary>
        public void EndTurn()
        {
            if (onEndTurn != null)
            {
                onEndTurn.Invoke();
            }
        }

        public delegate void OnPartyEnd();

        public OnPartyEnd onPartyEnd;

        /// <summary>
        /// Ending the party
        /// </summary>
        public void EndParty()
        {
            if (onPartyEnd != null)
            {
                onPartyEnd.Invoke();
            }
        }
    }
}
