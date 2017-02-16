using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment._4
{
    public partial class Form1 : Form
    {
        public List<Heros> Hoomans;
        public List<Enemy> Droogons;
        public Enemy ActiveDroogon;
        public Heros ActiveHooman;
        public Heros ActiveHooman2;
        public Random Rand;
        public int currentDroogon;
        public int currentHooman;
        public Form1()
        {
            InitializeComponent();

            currentDroogon = 0;

            Heros Defender = new Heros(10, 200, true);
            Heros Archer = new Heros(160, 140, true);
            Heros Warrior = new Heros(180, 120, true);

            Enemy LavaDragon = new Enemy(300, 180, true);
            Enemy RockDragon = new Enemy(280, 210, true);
            Enemy VolticDragon = new Enemy(190, 300, true);
            Enemy ArmoredDragon = new Enemy(200, 270, true);
            Enemy SkeleDragon = new Enemy(240, 160, true);
            Enemy WaterDragon = new Enemy(140, 260, true);

            Hoomans = new List<Heros>();
            Hoomans.Add(Defender);
            Hoomans.Add(Archer);
            Hoomans.Add(Warrior);

            Droogons = new List<Enemy>();
            Droogons.Add(LavaDragon);
            Droogons.Add(RockDragon);
            Droogons.Add(VolticDragon);
            Droogons.Add(ArmoredDragon);
            Droogons.Add(SkeleDragon);
            Droogons.Add(WaterDragon);

            Rand = new Random();

            ActiveDroogon = Droogons[currentDroogon];
        }

        public void Attacking(Heros H1, Heros H2, Enemy Dragon)
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
        public void Defending(Heros H1, Heros H2, Enemy Dragon)
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

        public void StartTurn()
        {

        }

        public void ThaUpdate()
        {
            if(ActiveDroogon.Alive == false)
            {
                currentDroogon++;
            }

            if(ActiveHooman.Alive == false)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attacking(comboBox1_SelectedIndexChanged, comboBox2_SelectedIndexChanged_1, ActiveDroogon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Defending(comboBox1_SelectedIndexChanged, comboBox2_SelectedIndexChanged_1, ActiveDroogon);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveHooman = currentHooman;
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = ActiveDroogon;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = ActiveDroogon.Attack.ToString;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = ActiveDroogon.Defense.ToString;
        }
    }
}
