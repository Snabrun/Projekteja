using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace Pizzatilaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            vehnaRB.Checked = true;
            pieniRB.Checked = true;
            lahetaTilausBT.Enabled= false;
            maksuTapaCB.Items.Add("Käteinen");
            maksuTapaCB.Items.Add("Kortti");
            maksuTapaCB.Items.Add("Lounas-seteli");
            maksuTapaCB.SelectedIndex = 1;

        }

        private void tilaaBT_Click(object sender, EventArgs e)
        // Pizzan koko ja pohja valinta
        {
            if (pieniRB.Checked == true)
            {
                if (vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Pieni pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("5,0");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Pieni pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("5,0");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Pieni pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("5,0");
                    listView1.Items.Add(tuote);
                }
            }
            else if (normaaliRB.Checked == true)
            {
                if (vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Normaali pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("8,00");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Normaali pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("8,00");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Normaali pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("8,00");
                    listView1.Items.Add(tuote);
                }
            }
            else if (suuriRB.Checked == true)
            {
                if(vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Suuri pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("14,00");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Suuri pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("14,00");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Suuri pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("14,00");
                    listView1.Items.Add(tuote);
                }
            }
            else if (perheRB.Checked == true)
            {
                if(vehnaRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vehnä pohja Perhe pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("20,00");
                    listView1.Items.Add(tuote);
                }
                else if (ruisRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Ruis pohja Perhe pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("20,00");
                    listView1.Items.Add(tuote);
                }
                else if (ketoRB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Keto pohja Perhe pizza");
                    tuote.SubItems.Add("1");
                    tuote.SubItems.Add("20,00");
                    listView1.Items.Add(tuote);
                }
            }
            // Täytteiden valinta
            if(aurajuustoCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Aurajuusto");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(bbqCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("BBQ-soosi");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(fetaCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Fetajuusto");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(herkkusieniCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Herkkusieni");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(jalapenoCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Jalapeno");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(jauhelihaCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Jauheliha");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(kanaCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Kana");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(kaprisCB.Checked == true) 
            {
                ListViewItem tuote = new ListViewItem("Kapris");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(KatkarapuCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Katkarapu");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(kebabCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Kebab");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(kinkkuCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Kinkku");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(maustekurkkuCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Maustekurkku");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(mozzarellaCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Mozzarella");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(oliiviCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Oliivi");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(paprikaCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Paprika");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(pekoniCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Pekoni");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(pepperoniCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Pepperoni");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(punasipuliCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Punasipuli");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(salamiCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Salami");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(smetanaCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Smetana");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(tomaattiCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Tomaati");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(tonnikalaCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Tonnikala");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(tuplajuustoCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Tuplajuusto");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            if(valkosipuliCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Valkosipuli");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("1,0");
                listView1.Items.Add(tuote);
            }
            //Juomien valinta
            try
            {
                if (cocacolaCB.Checked == true)
                {                     
                    ListViewItem tuote = new ListViewItem("Coca-Cola");
                    tuote.SubItems.Add(cocacolaTB.Text);
                    int kpl = Convert.ToInt32(cocacolaTB.Text);
                    double hinta = kpl * 2.0;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);
                    
                }
                else
                {
                    cocacolaTB.Text = "";
                }
                if (cocacolazeroCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Coca-Cola Zero");
                    tuote.SubItems.Add(cocacolazeroTB.Text);
                    int kpl = Convert.ToInt32(cocacolazeroTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);

                }
                else
                {
                    cocacolazeroTB.Text = "";
                }
                if (drpepperCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Dr.Pepper");
                    tuote.SubItems.Add(drpepperTB.Text);
                    int kpl = Convert.ToInt32(drpepperTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);

                }
                else
                {
                    drpepperTB.Text = "";
                }
                if (drpepperzeroCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Dr.Pepper Zero");
                    tuote.SubItems.Add(drpepperzeroTB.Text);
                    int kpl = Convert.ToInt32(drpepperzeroTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);

                }
                else
                {
                    drpepperzeroTB.Text = "";
                }
                if (fantaCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Fanta");
                    tuote.SubItems.Add(fantaTB.Text);
                    int kpl = Convert.ToInt32(fantaTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);

                }
                else
                {
                    fantaTB.Text = "";
                }
                if (fantazeroCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Fanta Zero");
                    tuote.SubItems.Add(fantazeroTB.Text);
                    int kpl = Convert.ToInt32(fantazeroTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);

                }
                else
                {
                    fantazeroTB.Text = "";
                }
                if (spriteCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Sprite");
                    tuote.SubItems.Add(spriteTB.Text);
                    int kpl = Convert.ToInt32(spriteTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);

                }
                else
                {
                    spriteTB.Text = "";
                }
                if (spritezeroCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Sprite Zero");
                    tuote.SubItems.Add(spritezeroTB.Text);
                    int kpl = Convert.ToInt32(spritezeroTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);

                }
                else
                {
                    spritezeroTB.Text = "";
                }
                if (vichyCB.Checked == true)
                {
                    ListViewItem tuote = new ListViewItem("Vichy");
                    tuote.SubItems.Add(vichyTB.Text);
                    int kpl = Convert.ToInt32(vichyTB.Text);
                    double hinta = kpl * 2.00;
                    string kokohinta = hinta.ToString();
                    tuote.SubItems.Add(kokohinta);
                    listView1.Items.Add(tuote);


                }

                else
                {
                    vichyTB.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Valitse ainakin yksi juoma", "Juoma", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Lisukkeiden valinta
            if (hotwingsCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Hot Wings");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("2,50");
                listView1.Items.Add(tuote);
            }
            if (sipulirenkaatCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Sipulirenkaat");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("2,50");
                listView1.Items.Add(tuote);
            }
            if (ranskalaisetCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Ranskalaiset");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("2,50");
                listView1.Items.Add(tuote);
            }
            if(chiliranskalaisetCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Chili Ranskalaiset");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("2,50");
                listView1.Items.Add(tuote);
            }
            if (yrttivoipatonkiCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Yrttivoi Patonki");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("2,50");
                listView1.Items.Add(tuote);
            }
            if (valkosipulidippiCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("Valkosipuli Dippi");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("2,50");
                listView1.Items.Add(tuote);
            }
            if (bbqdippiCB.Checked == true)
            {
                ListViewItem tuote = new ListViewItem("BBQ Dippi");
                tuote.SubItems.Add("");
                tuote.SubItems.Add("2,50");
                listView1.Items.Add(tuote);
            }

            /*
             * 
             *  Kokonaissumman ja veron laskeminen
             *
             */

            double yhteensa = 0;
            double vero = 0;
            double kokonaishinta = 0;

            foreach (ListViewItem tuote in listView1.Items)
            {
                yhteensa += Convert.ToDouble(tuote.SubItems[2].Text);
            }

            vero = yhteensa * 0.14;
            kokonaishinta = yhteensa + vero;

            ilmanVeroaTB.Text = yhteensa.ToString("c2");
            arvoLisaveroTB.Text = vero.ToString("c2");
            kokonaisHintaTB.Text = kokonaishinta.ToString("c2");

            tabcontrol.SelectTab("vahvistaTAB");
        }

        // tyhjennä tilaus


        private void tyhjennaTilausBT_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ilmanVeroaTB.Text = "";
            arvoLisaveroTB.Text = "";
            kokonaisHintaTB.Text = "";

        }

        private void tyhjennaBT_Click(object sender, EventArgs e)// Tilaus-sivun tyhjennys
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Form1_Load(sender, e);



        }

        private void cocacolaCB_CheckedChanged(object sender, EventArgs e)
        {
            if(cocacolaCB.Checked)
            {
                if (cocacolaTB.Text == "")
                {
                    cocacolaTB.Text = "1";
                }
            }
            else if (cocacolaCB.Checked == false)
            {
                cocacolaTB.Text = "";
            }
        }

        private void cocacolazeroCB_CheckedChanged(object sender, EventArgs e)
        {
            if(cocacolazeroCB.Checked)
            {
                if (cocacolazeroTB.Text == "")
                {
                    cocacolazeroTB.Text = "1";
                }
            }
            else if (cocacolazeroCB.Checked == false)
            {
                cocacolazeroTB.Text = "";
            }
        }

        private void drpepperCB_CheckedChanged(object sender, EventArgs e)
        {
            if(drpepperCB.Checked)
            {
                if (drpepperTB.Text == "")
                {
                    drpepperTB.Text = "1";
                }
            }
            else if (drpepperCB.Checked == false)
            {
                drpepperTB.Text = "";
            }
        }

        private void drpepperzeroCB_CheckedChanged(object sender, EventArgs e)
        {
            if(drpepperzeroCB.Checked)
            {
                if (drpepperzeroTB.Text == "")
                {
                    drpepperzeroTB.Text = "1";
                }
            }
            else if (drpepperzeroCB.Checked == false)
            {
                drpepperzeroTB.Text = "";
            }
        }

        private void fantaCB_CheckedChanged(object sender, EventArgs e)
        {
            if(fantaCB.Checked)
            {
                if (fantaTB.Text == "")
                {
                    fantaTB.Text = "1";
                }
            }
            else if (fantaCB.Checked == false)
            {
                fantaTB.Text = "";
            }
        }

        private void fantazeroCB_CheckedChanged(object sender, EventArgs e)
        {
            if(fantazeroCB.Checked)
            {
                if (fantazeroTB.Text == "")
                {
                    fantazeroTB.Text = "1";
                }
            }
            else if (fantazeroCB.Checked == false)
            {
                fantazeroTB.Text = "";
            }
        }

        private void spriteCB_CheckedChanged(object sender, EventArgs e)
        {
            if(spriteCB.Checked)
            {
                if (spriteTB.Text == "")
                {
                    spriteTB.Text = "1";
                }
            }
            else if (spriteCB.Checked == false)
            {
                spriteTB.Text = "";
            }
        }

        private void spritezeroCB_CheckedChanged(object sender, EventArgs e)
        {
            if(spritezeroCB.Checked)
            {
                if (spritezeroTB.Text == "")
                {
                    spritezeroTB.Text = "1";
                }
            }
            else if (spritezeroCB.Checked == false)
            {
                spritezeroTB.Text = "";
            }
        }

        private void vichyCB_CheckedChanged(object sender, EventArgs e)
        {
            if(vichyCB.Checked)
            {
                if (vichyTB.Text == "")
                {
                    vichyTB.Text = "1";
                }
            }
            else if (vichyCB.Checked == false)
            {
                vichyTB.Text = "";
            }
        }
        

        private void cocacolaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void cocacolazeroTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void drpepperTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void drpepperzeroTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void fantaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void fantazeroTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void spriteTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void spritezeroTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void vichyTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void siirryMaksuunBT_Click(object sender, EventArgs e)
        {
            loppuSummaTB.Text = kokonaisHintaTB.Text;
            tabcontrol.SelectTab(2);
            maksettuTB.Text = "0";

        }

        private void maksuTapaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(maksuTapaCB.SelectedIndex == 0 || maksuTapaCB.SelectedIndex == 2)
            {
                kortinNumeroTB.Enabled = false;
            }
            else
            {
                kortinNumeroTB.Enabled=true;
            }

            if(maksuTapaCB.SelectedIndex == 0 || maksuTapaCB.SelectedIndex == 2)

            {
                lahetaTilausBT.Enabled = true;
            }
            else
            {
                lahetaTilausBT.Enabled = false;
            }
        }

        private void maksuBT_Click(object sender, EventArgs e)
        {
            char[] euro = { '€' };
            double maksettu =Convert.ToDouble(maksettuTB.Text);
            double kokosumma = Convert.ToDouble(loppuSummaTB.Text.TrimEnd(euro));
            double vaihtoraha = 0;
            if(maksettu < kokosumma)
            {
                MessageBox.Show("Maksa koko summa kiitos!", "Makseminen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if( etuNimiTB.Text == "" || sukuNimiTB.Text == "" || osoiteTB.Text == "" || pNumeroTB.Text == "" || maksettuTB.Text == "")
            {
                MessageBox.Show("Vaaditut tiedot puuttuvat!", "Tiedot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                vaihtoraha = maksettu - kokosumma;
                vaihtoRahaTB.Text = Convert.ToString(vaihtoraha.ToString("c2"));
                lahetaTilausBT.Enabled= true;
            }


        }

        private void lahetaTilausBT_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Kiitos tilauksestasi meiltä! Tilauksesi on matkalla ja saapuu noin 30 minuutissa. Haluatko tilata lisää?", "Kiitos!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {

                //Clearing all data
               

                listView1.Items.Clear();
                

                tabcontrol.SelectTab(0);
                tyhjennaBT_Click(sender, e);


            }

            else if (dialog == DialogResult.No)
            {
                this.Close();
            }
        }

        private void poistuBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kortinNumeroTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pNumeroTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
