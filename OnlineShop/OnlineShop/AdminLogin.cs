using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineShop
{
    public partial class AdminLogin : Form
    {
        public Form1 ParentForm { get; set; }
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click_1(object sender, EventArgs e)
        {
            // Käytetään itse luotua luokkaa
            Yhdista tietokantaan = new Yhdista();
            //Muuttujat yhdistämistä varten
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();

            MySqlCommand komento = new MySqlCommand();

            // Luodaan kysely
            String kysely = "SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @ktu AND salasana = @ssa";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.otaYhteys();

            // Lisätään lomakkeelta tiedot @kn ja @ss muuttujiin
            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajaTunnusTB.Text;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salaSanaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu); // Täyttää taulua


            // Tarkistetaan, että ovat salasana ja käyttäjätunnus tietokannassa.
            // Jos rivi tulee, niin nämä löytyivät tietokannasta

            if (taulu.Rows.Count > 0)
            {
                // Lomakkeen piiloitus ja avataan pääikkuna.
                ParentForm.logOutBT.Visible = true;
                ParentForm.adminBT.Visible = false;
                ParentForm.listView1.Visible = false;
                ParentForm.tilaaBT.Visible = false;
                ParentForm.tyhjennaBT.Visible = false;
                ParentForm.adminPanel.Visible = true;
                this.Close();



            }
            else  // Muussa tapauksessa tarkistetaan jos jompikumpi on tyhjä
            {
                if (kayttajaTunnusTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimesi kirjautuaksesi", "Käyttäjänimi on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (salaSanaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi", "Salasana on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else  // Jos kentät on täytetty, mutta yhdistelmää ei löydy tietokannasta
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
