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
    public partial class Artifacts : Form
    {
        public Artifacts()
        {
            InitializeComponent();
        }

        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            pictureBox1.Load("../../Pictures/Artifacts/Искатель_приключений.png");
            label1.Text = "2 предмета: Увеличивает макс. HP на 1000 ед.";
            label2.Text = "4 предмета: В течение 5 сек. после открытия любого \n сундука восстанавливает 30% HP.";
        }

        private bool button2WasClicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;
            pictureBox1.Load("../../Pictures/Artifacts/Везунчик.png");
            label1.Text = "2 предмета: Увеличивает защиту на 100 ед.";
            label2.Text = "4 предмета: Поднятие монет восстанавливает 300 HP.";
        }

        private bool button3WasClicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            pictureBox1.Load("../../Pictures/Artifacts/Целитель.png");
            label1.Text = "2 предмета: Увеличивает получаемое Лечение на 20%.";
            label2.Text = "4 предмета: Использование взрыва стихии \n восстанавливает 20% HP.";
        }

        private bool button4WasClicked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            pictureBox1.Load("../../Pictures/Artifacts/Инструктор.png");
            label1.Text = "2 предмета: Увеличивает мастерство стихий на 80 ед.";
            label2.Text = "4 предмета: Вызов элементальной реакции \n увеличивает мастерство стихий \n всех членов отряда на 120 ед. в течение 8 сек.";
        }

        private bool button5WasClicked = false;
        private void button5_Click(object sender, EventArgs e)
        {
            button5WasClicked = true;
            pictureBox1.Load("../../Pictures/Artifacts/Берсерк.png");
            label1.Text = "2 предмета: Увеличивает шанс крит. попадания на 12%.";
            label2.Text = "4 предмета: Увеличивает шанс крит. попадания на 24% \n при HP ниже 70%.";
        }

        private bool button6WasClicked = false;
        private void button6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            pictureBox1.Load("../../Pictures/Artifacts/Изгнанник.png");
            label1.Text = "2 предмета: Увеличивает скорость восстановления энергии \n на 20%.";
            label2.Text = "4 предмета: Использование взрыва стихии \n восстанавливает 2 ед. энергии остальным членам отряда \n (но не выбранному персонажу) \n каждые 2 сек. в течение 6 сек. \n Эффект не может складываться.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%90%D1%80%D1%82%D0%B5%D1%84%D0%B0%D0%BA%D1%82%D1%8B#.D0.A2.D0.B0.D0.B1.D0.BB.D0.B8.D1.86.D0.B0_.D0.BE.D0.BF.D1.8B.D1.82.D0.B0_.D0.B0.D1.80.D1.82.D0.B5.D1.84.D0.B0.D0.BA.D1.82.D0.BE.D0.B2");
        }
    }
}
