using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{
    public enum StateManager
    {
        START = 1,
        IDLE = 2,
        CHOOSECHARACTERS = 3,
        ATKORDEF = 4,
        BATTLE = 5,
        END = 6,
    }


    public class Heros 
    {
        public Heros() { }

        public int m_Attack;
        int m_Defense;
        bool m_Alive;
        public int Attack { get { return m_Attack; } set { m_Attack = value; } }
        public int Defense { get { return m_Defense; } set { m_Defense = value; } }
        public bool Alive { get { return m_Alive; } set { m_Alive = value; } }
        public Heros(int m_Attack, int m_Defense, bool m_Alive) { }
        
    }

    public class Enemy
    {
        public Enemy() { }
        public int Attack { get { return m_Attack; } set { m_Attack = value; } }
        public bool Alive { get { return m_Alive; } set { m_Alive = value; } }
        public Enemy(int m_Attack, bool m_Alive) { }
        int m_Attack;
        bool m_Alive;

        public Random Rand = new Random();

        void Attacking(Heros H1, Heros H2, Enemy Dragon)
        {
            if (H1.Attack + H2.Attack > Dragon.Attack)
            {
                Dragon.Alive = false;
            }
            if (H1.Attack + H2.Attack < Dragon.Attack)
            {
                H1.Alive = false; H2.Alive = false;
            }
        }

        void Defending(Heros H1, Heros H2, Enemy Dragon)
        {
            int NewAttack;
            int BothDefense;
            if (H1.Defense + H2.Defense > Dragon.Attack)
            {
                BothDefense = H1.Defense + H2.Defense;
                NewAttack = BothDefense - Dragon.Attack;
                Dragon.Attack = NewAttack;
            }
            if (H1.Defense + H2.Defense < Dragon.Attack)
            {
                H1.Alive = false; H2.Alive = false;
            }
        }

    }
}
