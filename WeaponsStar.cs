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
    public partial class WeaponsStar : Form
    {
        public WeaponsStar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _1_2star Weapon1_2star = new _1_2star();
            Weapon1_2star.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _3star Weapon3star = new _3star();
            Weapon3star.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _4stars Weapon4stars = new _4stars();
            Weapon4stars.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _5stars Weapon5stars = new _5stars();
            Weapon5stars.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://wiki.hoyolab.com/pc/genshin/aggregate/weapon");
        }


        private void label2_Click(object sender, EventArgs e)
        {

        } 
        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
