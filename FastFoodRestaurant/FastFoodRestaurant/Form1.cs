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
    public partial class FastFood : Form
    {
        public FastFood()
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

        private void CloseBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Déclaration des unités de prix des different boissons et repas
        double friteup = 1500, saladeup = 1500, hamburgerup = 2000, pouletup = 3500, sandwichup = 1500, beignetup = 1000, pizzaup = 5000;
        double cocaup = 1500, eauup = 500, theup = 1000, orangeup = 1000, glaceup = 1000, crepeup = 1000, chocolatup = 1000;

        //Déclaration des variables des prix total des boissons et repas
        double fritetp, saladetp, hamburgertp, poulettp, sandwichtp, beignettp, pizzatp;
        double cocatp, eautp, thetp, orangetp, glacetp, crepetp, chocolattp;

        double totalht = 0, taxe, totalttc;
        private void RecetteTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjouterBt_Click(object sender, EventArgs e)
        {
            fritetp = friteup * Convert.ToDouble(FriteTb.Text);
            saladetp = saladeup * Convert.ToDouble(SaladeTb.Text);
            hamburgertp = hamburgerup * Convert.ToDouble(HamburgerTb.Text);
            poulettp = pouletup * Convert.ToDouble(PouletTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            beignettp = beignetup * Convert.ToDouble(BeignetTb.Text);
            pizzatp = pizzaup * Convert.ToDouble(PizzaTb.Text);

            cocatp = cocaup * Convert.ToDouble(CocaTb.Text);
            eautp = eauup * Convert.ToDouble(EauTb.Text);
            thetp = theup * Convert.ToDouble(TheTb.Text);
            orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            glacetp = glaceup * Convert.ToDouble(GlaceTb.Text);
            crepetp = crepeup * Convert.ToDouble(CrepeTb.Text);
            chocolattp = chocolatup * Convert.ToDouble(ChocolatTb.Text);

            //Maintenant on ajoute la commde au tableau
            RecetteTb.Clear();
            RecetteTb.AppendText(Environment.NewLine);
            RecetteTb.AppendText("\t\t\t\t RESTAURANT DU CAMPUS" + Environment.NewLine);
            RecetteTb.AppendText("\t\t\t ************************************  " + Environment.NewLine);

            if(FriteCb.Checked == true)
            {
                RecetteTb.AppendText("\tFrite (x"+FriteTb.Text+") : \t"+fritetp+"Frs"+Environment.NewLine);
                totalht += fritetp;
                TotalHTlbl.Text = "" + totalht;
            }
            if (HamburgerCb.Checked == true)
            {
                
            }
            if (SaladeCb.Checked == true)
            {
                
            }
            if (PouletCb.Checked == true)
            {
                
            }
            if (SandwichCb.Checked == true)
            {
                
            }
            if (BeignetCb.Checked == true)
            {
                
            }
            if (PizzaCb.Checked == true)
            {
                
            }
            if (TheCb.Checked == true)
            {
                
            }
            if (CocaCb.Checked == true)
            {
                
            }
            if (GlaceCb.Checked == true)
            {
                
            }
            if (EauCb.Checked == true)
            {
                
            }
            if (ChocolatCb.Checked == true)
            {
                
            }
            if (OrangeCb.Checked == true)
            {
               
            }
            if (CrepeCb.Checked == true)
            {
                
            }
            
        }
    }
}
