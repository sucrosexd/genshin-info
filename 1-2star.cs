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
    public partial class _1_2star : Form
    {
        public _1_2star()
        {
            InitializeComponent();
        }

        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Тупой_меч.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Тупой_меч_Возв.png");
        }

        private bool button2WasClicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Двуручный_меч_богатыря.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Двуручный_меч_богатыря_Возв.png");
        }

        private bool button3WasClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Записи_ученика.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Записи_ученика_Возв.png");
        }

        private bool button4WasClicked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Лук_охотника.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Лук_охотника_Возв.png");
        }

        private bool button5WasClicked = false;
        private void button5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Копьё_новичка.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Копьё_новичка_Возв.png");

        }

        private bool button6WasClicked = false;
        private void button6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Лучший_друг_наёмника.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Лучший_друг_наёмника_Возв.png");
        }

        private bool button7WasClicked = false;
        private void button7_Click(object sender, EventArgs e)
        {
            button7WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Лук_опытного_охотника.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Лук_опытного_охотника_Возв.png");

        }

        private bool button8WasClicked = false;
        private void button8_Click(object sender, EventArgs e)
        {
            button8WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Карманный_гримуар.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Карманный_гримуар_Возв.png");

        }

        private bool button9WasClicked = false;
        private void button9_Click(object sender, EventArgs e)
        {
            button9WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Железный_наконечник.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Железный_наконечник_Возв.png");
        }

        private bool button10WasClicked = false;
        private void button10_Click(object sender, EventArgs e)
        {
            button10WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/12stars/Серебряный_меч.png");
            pictureBox2.Load("Pictures/Weapons/12stars/Серебряный_меч_Возв.png");
        }

        private void _1_2star_Load(object sender, EventArgs e)
        {

        }
    }
}
