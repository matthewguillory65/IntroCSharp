using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment._4
{

    class Characters
    {
    }

    public class Heros
    {
        int m_Attack;
        int m_Defense;
        bool m_Alive;
        public int Attack { get { return m_Attack; } set { m_Attack = value; } }
        public int Defense { get { return m_Defense; } set { m_Defense = value; } }
        public bool Alive { get { return m_Alive; } set { m_Alive = value; } }
        public Heros(int Atk, int Def, bool Alv) { }
    }

    public class Enemy
    {
        public int Attack { get { return m_Attack; } set { m_Attack = value; } }
        public int Defense { get { return m_Defense; } set { m_Defense = value; } }
        public bool Alive { get { return m_Alive; } set { m_Alive = value; } }
        public Enemy(int Atk, int Def, bool Alv) { }
        int m_Attack;
        int m_Defense;
        bool m_Alive;

        public static implicit operator string(Enemy v)
        {
            throw new NotImplementedException();
        }
    }

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