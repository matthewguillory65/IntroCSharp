using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADGP125
{
    public partial class Form1 : Form
    {
        FSM fsm;
        
        public Form1()
        {
            InitializeComponent();
            //initialize all assets

            fsm = new FSM();
            

            fsm.Start();
            

            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }
        public void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.ForestGreen;
        }
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Yellow;
        }
    }
}
