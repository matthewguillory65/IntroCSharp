using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment4
{
    class Players
    {
        public Players(int m_Health, int m_Speed, char m_Name) { }

        public int m_Health;
        public int m_Speed;
        public char m_Name;

        List<Players> Player1 = new List<Players>();
        List<Players> Player2 = new List<Players>();
        List<Players> Player3 = new List<Players>();
    }

    class Enemy
    {
        public Enemy(int m_health, int m_speed, char m_name) { }

        public int m_health;
        public int m_Speed;
        public char m_name;

        List<Enemy> Enemy1 = new List<Enemy>();
        List<Enemy> Enemy2 = new List<Enemy>();
        List<Enemy> Enemy3 = new List<Enemy>();
    }

}