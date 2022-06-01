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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeaponsStar weapons = new WeaponsStar();
            weapons.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Artifacts artifacts = new Artifacts();
            artifacts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%92%D1%80%D0%B0%D0%B3%D0%B8_%D0%B8_%D0%BC%D0%BE%D0%BD%D1%81%D1%82%D1%80%D1%8B");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%A4%D0%B0%D1%83%D0%BD%D0%B0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArchonMissions arc_mis = new ArchonMissions();
            arc_mis.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%97%D0%B0%D0%B4%D0%B0%D0%BD%D0%B8%D1%8F_%D0%BB%D0%B5%D0%B3%D0%B5%D0%BD%D0%B4");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%9C%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D1%8B");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%95%D0%B4%D0%B0");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://genshin-impact.fandom.com/ru/wiki/%D0%98%D0%BD%D1%81%D1%82%D1%80%D1%83%D0%BC%D0%B5%D0%BD%D1%82%D1%8B");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Info Info = new Info();
            Info.Show();
        }
    }
}
