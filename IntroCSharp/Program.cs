using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> Studentss = new List<Students>();
            char input = '0';
            //Students Joe = new Students();
            //Students Bill = new Students();
            //Students Tony = new Students();
            //Students Yuh = new Students();
            //Students OP = new Students();
            //Students KaibaMan = new Students();
            //Students Rayman = new Students();
            //Students Nicholas = new Students();
            //Students Matt = new Students();
            //Students Zyron = new Students();
            //Students s = new Students();
            //Studentss.Add(Joe);
            //Studentss.Add(Bill);
            //Studentss.Add(Tony);
            //Studentss.Add(Yuh);
            //Studentss.Add(OP);
            //Studentss.Add(KaibaMan);
            //Studentss.Add(Rayman);
            //Studentss.Add(Nicholas);
            //Studentss.Add(Matt);
            //Studentss.Add(Zyron);

            //Enemy orc = new Enemy();

            //string Word = "Dogs";
            //string Wurd = "Cars";
            //Word += Wurd;

            //Console.WriteLine(Word);

            //Student s = new IntroCSharp.Student();
            //int m_Age;
            //Console.WriteLine(s.Age);

            while (input != 'q')
            {
                Console.WriteLine("Type something, anything for that matter. \n");
                string words = Console.ReadLine();
                Console.WriteLine("Input is " + words);
            }


            ////String words = "Hello World";
            //Console.Write("Hello World");
            Console.ReadLine();
        }
    }

    class Enemy
    {
        public Enemy() { }

        private int health = 4;
        private int dmg;
        private string name;
        public void Attack() { }
    }

    class Weapon
    {
        public string name;
        public float damage;
    }

    class Students
    {
        public Students() { }
        public Students(int id) { }
        private int id;
    }


    class Student
    {
        public Student() { }
        private int m_age = 5;
        public int Age
        {
            get { return m_age + 7; }
        }
    }


    class Entity
    {
        Entity() { }
        Entity(int health, int attack) { }
        protected int Health;
        private int health;
        protected int AttackPower;
        private int attackpower;
        public virtual bool Attack(Entity entity) { return true; }
    }
    
    class Zombie
    {
        Zombie() { }
        public Zombie(int health, int attack) { }
        public bool Attack(Entity zombie) { return true; }
    }

    class Player
    {
        Player() { }
        public Player(int health, int attack) { }
        public bool Attack(Entity player) { return true; }
        public bool Defend() { return true; }
    }

    class Functions
    {
        int Fight(Player p, Zombie z)
        {
            
            return 1;
        }

        int Fightt(Player p, Zombie z)
        {

            return 1;
        }
    }

}