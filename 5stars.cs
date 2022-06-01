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
    public partial class _5stars : Form
    {
        public _5stars()
        {
            InitializeComponent();
        }

        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Драгоценный_омут.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Драгоценный_омут_Возв.png");
        }

        private bool button2WasClicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Краснорогий_камнеруб.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Краснорогий_камнеруб_Возв.png");
        }

        private bool button3WasClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Лук_Амоса.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Лук_Амоса_Возв.png");
        }

        private bool button4WasClicked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Молитва_святым_ветрам.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Молитва_святым_ветрам_Возв.png");
        }

        private bool button5WasClicked = false;
        private void button5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Небесное_крыло.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Небесное_крыло_Возв.png");
        }

        private bool button6WasClicked = false;
        private void button6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Посох_Хомы.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Посох_Хомы_Возв.png");
        }

        private bool button7WasClicked = false;
        private void button7_Click(object sender, EventArgs e)
        {
            button7WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Рассекающий_туман.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Рассекающий_туман_Возв.png");
        }

        private bool button8WasClicked = false;
        private void button8_Click(object sender, EventArgs e)
        {
            button8WasClicked = true;
            pictureBox1.Load("../../Pictures/Weapons/5stars/Сияющая_жатва.png");
            pictureBox2.Load("../../Pictures/Weapons/5stars/Сияющая_жатва_Возв.png");
        }
    }
}
