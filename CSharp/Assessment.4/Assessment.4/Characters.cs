using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{



    public class Heros
    {
        public Heros()
        {

        }

        public int m_Attack = 50;
        int m_Defense = 50;
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
        public int Defense { get { return m_Defense; } set { m_Defense = value; } }
        public bool Alive { get { return m_Alive; } set { m_Alive = value; } }
        public Enemy(int m_Attack, int m_Defense, bool m_Alive) { }
        int m_Attack = 50;
        int m_Defense = 50;
        bool m_Alive;

        class Attacks
        {
            public Attacks() { }
            void Attack()
            {

            }
        }
        class Singleton
        {
            private static readonly Singleton instance = new Singleton();

            private Singleton() { }

            public static Singleton Instance
            {
                get
                {
                    return instance;
                }
            }
        }



    }
}
