using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineShop
{
    public partial class tilausFORM : Form
    {
        public tilausFORM()
        {
            InitializeComponent();
            
        }

        private void tilausFORM_Load(object sender, EventArgs e)
        {
            maksuTapaCB.Items.Add("Käteinen");
            maksuTapaCB.Items.Add("Kortti");
            maksuTapaCB.SelectedIndex = 1;
            loppusummaTB.Text = Form1.sendtext; // Hakee tiedon yhteensaTB Form1:stä
            maksuTB.Text = "0";
            
        }

        private void maksuTapaCB_SelectedIndexChanged(object sender, EventArgs e)
        {   // Maksutavan valinta ja lähetä tilaus napin toiminta maksutapaa valittaessa.
            if (maksuTapaCB.SelectedIndex == 0 || maksuTapaCB.SelectedIndex == 2)
            {
                kortinNroTB.Enabled = false;
            }
            else
            {
                kortinNroTB.Enabled = true;
            }

            if (maksuTapaCB.SelectedIndex == 0 || maksuTapaCB.SelectedIndex == 2)

            {
                lahetatilausBT.Enabled = true;
            }
            else
            {
                lahetatilausBT.Enabled = false;
            }
        }

        private void kortinNroTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maksuBT_Click(object sender, EventArgs e)
        {

            char[] euro = { '€' };
            double maksettu = Convert.ToDouble(maksuTB.Text);
            double kokosumma = Convert.ToDouble(loppusummaTB.Text.TrimEnd(euro));
            double vaihtoraha = 0;
            if (maksettu < kokosumma)
            {
                MessageBox.Show("Maksa koko summa kiitos!", "Maksu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (etunimiTB.Text == "" || sukunimiTB.Text == "" || osoiteTB.Text == "" || postinumeroTB.Text == "" || postitoimipaikkaTB.Text == "" || puhelinTB.Text == "")
            {
                MessageBox.Show("Vaaditut tiedot puuttuvat!", "Tiedot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                vaihtoraha = maksettu - kokosumma;
                vaihtorahaTB.Text = Convert.ToString(vaihtoraha.ToString());
                lahetatilausBT.Enabled = true;
                
            }
        }

        private void lahetatilausBT_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Kiitos tilauksestasi! Pakettisi lähtee pikapuoliin kuljetusyhtiön kuljetettavaksi! Jos haluat tilata lisää paina Kyllä. Poistuaksesi Ei","Tilaus" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {

                // Tyhjennys, ja uusiksi avaus.
                this.Close();
                Application.Restart();
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);




            }

            else if (dialog == DialogResult.No)
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }

        }
    }
}
