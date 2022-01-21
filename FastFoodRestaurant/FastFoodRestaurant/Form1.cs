using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void FriteCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriteCb.Checked == true)
            {
                FriteTb.Enabled = true;
            }
            if(FriteCb.Checked == false)
            {
                FriteTb.Enabled = false;
                FriteTb.Text = "0";
            }
        }

        private void HamburgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HamburgerCb.Checked == true)
            {
                HamburgerTb.Enabled = true;
            }
            if (HamburgerCb.Checked == false)
            {
                HamburgerTb.Enabled = false;
                HamburgerTb.Text = "0";
            }
        }

        private void SaladeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SaladeCb.Checked == true)
            {
                SaladeTb.Enabled = true;
            }
            if (SaladeCb.Checked == false)
            {
                SaladeTb.Enabled = false;
                SaladeTb.Text = "0";
            }
        }

        private void PouletCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PouletCb.Checked == true)
            {
                PouletTb.Enabled = true;
            }
            if (PouletCb.Checked == false)
            {
                PouletTb.Enabled = false;
                PouletTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }
        
        private void BeignetCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BeignetCb.Checked == true)
            {
                BeignetTb.Enabled = true;
            }
            if (BeignetCb.Checked == false)
            {
                BeignetTb.Enabled = false;
                BeignetTb.Text = "0";
            }
        }

        private void PizzaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzaCb.Checked == true)
            {
                PizzaTb.Enabled = true;
            }
            if (PizzaCb.Checked == false)
            {
                PizzaTb.Enabled = false;
                PizzaTb.Text = "0";
            }
        }

        private void TheCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TheCb.Checked == true)
            {
                TheTb.Enabled = true;
            }
            if (TheCb.Checked == false)
            {
                TheTb.Enabled = false;
                TheTb.Text = "0";
            }
        }

        private void CocaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CocaCb.Checked == true)
            {
                CocaTb.Enabled = true;
            }
            if (CocaCb.Checked == false)
            {
                CocaTb.Enabled = false;
                CocaTb.Text = "0";
            }
        }

        private void GlaceCb_CheckedChanged(object sender, EventArgs e)
        {
            if (GlaceCb.Checked == true)
            {
                GlaceTb.Enabled = true;
            }
            if (GlaceCb.Checked == false)
            {
                GlaceTb.Enabled = false;
                GlaceTb.Text = "0";
            }
        }

        private void EauCb_CheckedChanged(object sender, EventArgs e)
        {
            if (EauCb.Checked == true)
            {
                EauTb.Enabled = true;
            }
            if (EauCb.Checked == false)
            {
                EauTb.Enabled = false;
                EauTb.Text = "0";
            }
        }

        private void ChocolatCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolatCb.Checked == true)
            {
                ChocolatTb.Enabled = true;
            }
            if (ChocolatCb.Checked == false)
            {
                ChocolatTb.Enabled = false;
                ChocolatTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void CrepeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CrepeCb.Checked == true)
            {
                CrepeTb.Enabled = true;
            }
            if (CrepeCb.Checked == false)
            {
                CrepeTb.Enabled = false;
                CrepeTb.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
