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
    public partial class _3star : Form
    {
        public _3star()
        {
            InitializeComponent();
        }

        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/3stars/Белая_кисть.png");
            pictureBox2.Load("../../Pictures/Weapons/3stars/Белая_кисть_Возв.png");
        }

        private bool button2WasClicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/3stars/Дубина_переговоров.png");
            pictureBox2.Load("../../Pictures/Weapons/3stars/Дубина_переговоров_Возв.png");
        }

        private bool button3WasClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/3stars/Клятва_стрелка.png");
            pictureBox2.Load("../../Pictures/Weapons/3stars/Клятва_стрелка_Возв.png");
        }

        private bool button4WasClicked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/3stars/Предвестник_зари.png");
            pictureBox2.Load("../../Pictures/Weapons/3stars/Предвестник_зари_Возв.png");
        }

        private bool button5WasClicked = false;
        private void button5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/3stars/Чёрная_кисть.png");
            pictureBox2.Load("../../Pictures/Weapons/3stars/Чёрная_кисть_Возв.png");
        }

        private bool button6WasClicked = false;
        private void button6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/3stars/Эпос_о_драконоборцах.png");
            pictureBox2.Load("../../Pictures/Weapons/3stars/Эпос_о_драконоборцах_Возв.png");
        }
    }
}