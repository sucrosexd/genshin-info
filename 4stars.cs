using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yes
{
    public partial class _4stars : Form
    {
        public _4stars()
        {
            InitializeComponent();
        }

        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Белая_тень.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Белая_тень_Возв.png");
        }

        private bool button2WasClicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Гроза_драконов.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Гроза_драконов_Возв.png");
        }

        private bool button3WasClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Киноварное_веретено.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Киноварное_веретено_Возв.png");
        }

        private bool button4WasClicked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Песнь_странника.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Песнь_странника_Возв.png");
        }

        private bool button5WasClicked = false;
        private void button5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Улов.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Улов_Возв.png");
        }

        private bool button6WasClicked = false;
        private void button6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Хамаюми.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Хамаюми_Возв.png");
        }

        private bool button7WasClicked = false;
        private void button7_Click(object sender, EventArgs e)
        {
            button7WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Церемониальные_мемуары.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Церемониальные_мемуары_Возв.png");
        }

        private bool button8WasClicked = false;
        private void button8_Click(object sender, EventArgs e)
        {
            button8WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/4stars/Церемониальный_меч.png");
            pictureBox2.Load("Pictures/Weapons/4stars/Церемониальный_меч_Возв.png");
        }
    }
}
