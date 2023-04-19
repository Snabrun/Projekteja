    using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    internal class LISAYS
    {
        Yhdista yhteys = new Yhdista();

        public DataTable tuotteetLista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * from tuotteet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        public bool lisaaVaraus(string nimi, string tieto, string kuva)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT into `tuotteet`" + "(NameColumn, DescriptionColumn, ImageColumn)" +
                                  "VALUES (@nimi, @tieto, @kuva); ";

            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();


           //@nimi @tieto @kuva
            komento.Parameters.Add("@nimi", MySqlDbType.VarChar).Value = nimi;
            komento.Parameters.Add("@tieto", MySqlDbType.VarChar).Value = tieto;
            komento.Parameters.Add("@kuva", MySqlDbType.VarChar).Value = kuva;
           
            yhteys.avaaYhteys();
            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
                return true;
            }

        }
        public DataTable haeTuotteet()
        {
            MySqlCommand komento = new MySqlCommand("SELECT nimi, tieto, kuva FROM tuotteet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
        public bool muokkaaTuote(string nimi, string tieto, string kuva)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `tuotteet` SET `nimi` = @nimi,`tieto` = @tieto, `kuva` = @kuva";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            //@nimi @tieto @kuva
            komento.Parameters.Add("@nimi", MySqlDbType.VarChar).Value = nimi;
            komento.Parameters.Add("@tieto", MySqlDbType.VarChar).Value = tieto;
            komento.Parameters.Add("@kuva", MySqlDbType.VarChar).Value = kuva;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
