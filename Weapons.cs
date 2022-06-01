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
    public partial class Weapons : Form
    {
        public Weapons()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Тупой_меч.png");
            pictureBox2.Load("Pictures/Weapons/Тупой_меч_Возв.png");
        }

        private bool button2WasClicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Двуручный_меч_богатыря.png");
            pictureBox2.Load("Pictures/Weapons/Двуручный_меч_богатыря_Возв.png");
        }

        private bool button3WasClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Записи_ученика.png");
            pictureBox2.Load("Pictures/Weapons/Записи_ученика_Возв.png");
        }

        private bool button4WasClicked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Лук_охотника.png");
            pictureBox2.Load("Pictures/Weapons/Лук_охотника_Возв.png");
        }

        private bool button5WasClicked = false;
        private void button5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Копье_новичка.png");
            pictureBox2.Load("Pictures/Weapons/Копьё_новичка_Возв.png");
        }

        private bool button6WasClicked = false;
        private void button6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Лучший_друг_наёмника.png");
            pictureBox2.Load("Pictures/Weapons/Лучший_друг_наёмника_Возв.png");
        }

        private bool button7WasClicked = false;
        private void button7_Click(object sender, EventArgs e)
        {
            button7WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Лук_опытного_охотника.png");
            pictureBox2.Load("Pictures/Weapons/Лук_опытного_охотника_Возв.png");
        }

        private bool button8WasClicked = false;
        private void button8_Click(object sender, EventArgs e)
        {
            button8WasClicked = true;
            pictureBox1.Load("Pictures/Weapons/Карманный_гримуар.png");
            pictureBox2.Load("Pictures/Weapons/Карманный_гримуар_Возв.png");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9E%D1%80%D1%83%D0%B6%D0%B8%D0%B5_3-%D0%B7%D0%B2%D0%B5%D0%B7%D0%B4%D1%8B");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel2.LinkVisited = true;

            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9E%D1%80%D1%83%D0%B6%D0%B8%D0%B5_4-%D0%B7%D0%B2%D0%B5%D0%B7%D0%B4%D1%8B");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel3.LinkVisited = true;

            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9E%D1%80%D1%83%D0%B6%D0%B8%D0%B5_5-%D0%B7%D0%B2%D1%91%D0%B7%D0%B4");
        }
    }
}
