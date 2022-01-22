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

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RecetteTb.Text + "Total HT : " + TotalHTlbl.Text + "    Taxe : " + Taxelbl.Text + "    Total TTC : " + TotalTTClbl.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void ImprimerBt_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        double cocaup = 1500, eauup = 500, theup = 1000, orangeup = 1000, glaceup = 1000, crepeup = 1000, chocolatup = 1000;

        //Déclaration des variables des prix total des boissons et repas
        double fritetp, saladetp, hamburgertp, poulettp, sandwichtp, beignettp, pizzatp;
        double cocatp, eautp, thetp, orangetp, glacetp, crepetp, chocolattp;

        double totalht = 0, taxe, totalttc;



        private void ReinitialiserBt_Click(object sender, EventArgs e)
        {
            RecetteTb.Clear();
            NumTabTb.Text = "";
            TotalHTlbl.Text = "---Frs";
            Taxelbl.Text = "---Frs";
            TotalTTClbl.Text = "---Frs";

            FriteCb.Checked = false;
            HamburgerCb.Checked = false;
            SaladeCb.Checked = false;
            PouletCb.Checked = false;
            SandwichCb.Checked = false;
            BeignetCb.Checked = false;
            PizzaCb.Checked = false;
            TheCb.Checked = false;
            CocaCb.Checked = false;
            GlaceCb.Checked = false;
            EauCb.Checked = false;
            ChocolatCb.Checked = false;
            OrangeCb.Checked = false;
            CrepeCb.Checked = false;
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
            RecetteTb.AppendText("\tN° table :  "+NumTabTb.Text+"\t\t\t Date et Heure : "+ DateTime.Now + Environment.NewLine);

            //Compteur
            int i = 1;

            if(FriteCb.Checked == true)
            {
                RecetteTb.AppendText("\t"+i+"-\tFrite (x"+FriteTb.Text+") : \t\t"+fritetp+"Frs"+Environment.NewLine);
                totalht += fritetp;
                TotalHTlbl.Text = "" + totalht+"Frs";
                i++;
            }
            if (HamburgerCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tHamburger (x" + HamburgerTb.Text + ") : \t" + hamburgertp + "Frs" + Environment.NewLine);
                totalht += hamburgertp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (SaladeCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tSalade (x" + SaladeTb.Text + ") : \t\t" + saladetp + "Frs" + Environment.NewLine);
                totalht += saladetp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (PouletCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tPoulet (x" + PouletTb.Text + ") : \t\t" + poulettp + "Frs" + Environment.NewLine);
                totalht += poulettp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (SandwichCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tSandwich (x" + SandwichTb.Text + ") : \t" + sandwichtp + "Frs" + Environment.NewLine);
                totalht += sandwichtp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (BeignetCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tBeignet (x" + BeignetTb.Text + ") : \t\t" + beignettp + "Frs" + Environment.NewLine);
                totalht += beignettp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (PizzaCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tPizza (x" + PizzaTb.Text + ") : \t\t" + pizzatp + "Frs" + Environment.NewLine);
                totalht += pizzatp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (TheCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tThe (x" + TheTb.Text + ") : \t\t" + thetp + "Frs" + Environment.NewLine);
                totalht += thetp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (CocaCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tCoca-Cola (x" + CocaTb.Text + ") : \t" + cocatp + "Frs" + Environment.NewLine);
                totalht += cocatp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (GlaceCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tGrème Glacée (x" + GlaceTb.Text + ") : \t" + glacetp + "Frs" + Environment.NewLine);
                totalht += glacetp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (EauCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tEau (x" + EauTb.Text + ") : \t\t" + eautp + "Frs" + Environment.NewLine);
                totalht += eautp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (ChocolatCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tChocolat (x" + ChocolatTb.Text + ") : \t" + chocolattp + "Frs" + Environment.NewLine);
                totalht += chocolattp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (OrangeCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tOrange (x" + OrangeTb.Text + ") : \t\t" + orangetp + "Frs" + Environment.NewLine);
                totalht += orangetp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }
            if (CrepeCb.Checked == true)
            {
                RecetteTb.AppendText("\t" + i + "-\tCrêpe (x" + CrepeTb.Text + ") : \t\t" + crepetp + "Frs" + Environment.NewLine);
                totalht += crepetp;
                TotalHTlbl.Text = "" + totalht + "Frs";
                i++;
            }

            taxe = totalht * 0.1925;
            Taxelbl.Text = "" + taxe + "Frs";
            totalttc = totalht + taxe;
            TotalTTClbl.Text = "" + totalttc + "Frs";
            
        }
    }
}
