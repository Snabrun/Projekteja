using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Yhdista yhteys = new Yhdista();



        private void adminBT_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.ParentForm = this;
            admin.Show();
        }

            /*
             * *
             * Tietojen lataaminen SQL-tietokannasta
             * *
             */

        public DataTable haeTuottet()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Kuva", typeof(Image));
            table.Columns.Add("Nimi", typeof(string));
            table.Columns.Add("Tieto", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Id", typeof(int));

            yhteys.avaaYhteys();

            MySqlCommand command = new MySqlCommand("SELECT `Nimi`, `Tieto`, `Price`, `Kuva`, `Id`  FROM `Products`", yhteys.otaYhteys());

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nimi = reader.GetString("Nimi");
                    string tieto = reader.GetString("Tieto");
                    decimal price = reader.GetDecimal("Price");
                    int id = reader.GetInt32("Id");

                    /*
                     * *
                     * Muunnos tavuksi kuvaksi
                     * *
                     */

                    byte[] imageData = (byte[])reader["Kuva"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        table.Rows.Add(image, nimi, tieto, price, id);
                    }
                }
            }

            yhteys.suljeYhteys();

            return table;
        }
   

        private void Form1_Load(object sender, EventArgs e)
        {
            logOutBT.Visible = false;
            adminPanel.Visible = false;
            dataGridView1.DataSource = haeTuottet();
            dataGridView1.Columns["Id"].Width = 0;
            AddProductButton.Enabled = false;


            /*
             * *
             * Rivien lisäämisen määrittäminen
             * *
             */

            // dataGridView1.BackgroundColor = Color.Transparent;
            dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Transparent;
            //dataGridView1.DefaultCellStyle.BackColor = Color.Transparent;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;


            //  dataGridView1.ColumnCount = 3;

            /*
             * *
             * Kuvien solun koko
             * *
             */

            dataGridView1.Columns["Kuva"].Width = 100;
            ((DataGridViewImageColumn)dataGridView1.Columns["Kuva"]).ImageLayout = DataGridViewImageCellLayout.Zoom;   



        }

        private void logOutBT_Click(object sender, EventArgs e)
        {
            logOutBT.Visible = false;
            adminBT.Visible = true;
            listView1.Visible = true;
            tilaaBT.Visible = true;
            tyhjennaBT.Visible = true;
            adminPanel.Visible = false;
        }



        /*
         * *
         * Järjestelmänvalvojan tuotteiden ohjauspaneeli. Toistaiseksi paikallisen muistin kautta, mutta sitten meidän on tallennettava se SQL-tietokantaan
         * *
         */

        private void AddProductButton_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = yhteys.otaYhteys();
            connection.Open();
            MySqlCommand komento = new MySqlCommand();
            komento.Connection = connection;
            string lisayskysely = "INSERT INTO Products (Nimi, Tieto, Price, Kuva) VALUES (@Nimi, @Tieto, @Price, @Kuva)";
            komento.CommandText = lisayskysely;
            komento.Parameters.AddWithValue("@Nimi", nameTextBox.Text);
            komento.Parameters.AddWithValue("@Tieto", descriptionTextBox.Text);
            komento.Parameters.AddWithValue("@Price", hintaTB.Text);
            if (pictureBox1.Image != null)
            {
                ImageConverter converter = new ImageConverter();
                byte[] imageBytes = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                komento.Parameters.AddWithValue("@Kuva", imageBytes);
            }
            else
            {
                komento.Parameters.AddWithValue("@Kuva", DBNull.Value);
            }
            komento.ExecuteNonQuery();

            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            hintaTB.Text = "";
            pictureBox1.Image = null;
            AddProductButton.Enabled= false;

            dataGridView1.DataSource= haeTuottet();

            ListViewItem tuote = new ListViewItem();
           
        }


        private void SelectImageButton_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.png, *.jpg, *.jpeg, *.gif) | *.png; *.jpg; *.jpeg; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox1.Image = Image.FromFile(dialog.FileName);
                AddProductButton.Enabled= true;
            }
        }


        private void lisaaBT_Click(object sender, EventArgs e)
        {   // Ostoskorin tietojen haku.
            if (dataGridView1.CurrentRow != null)
            {
                string cell1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string cell2 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string cell3 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                ListViewItem tuote = new ListViewItem(new[] { cell1, cell2, cell3 });
                listView1.Items.Add(tuote);

            }

            double yhteensa = 0;
            foreach (ListViewItem tuote in listView1.Items)
            {
                yhteensa += Convert.ToDouble(tuote.SubItems[1].Text);
            }

           yhteensaTB.Text = yhteensa.ToString();
          
        }
        public static string sendtext = "";
        private void tilaaBT_Click(object sender, EventArgs e)
        {
            // yhteensaTB tiedon lähetys tilausFormiin.
            sendtext = yhteensaTB.Text;
            tilausFORM frm = new tilausFORM();
            frm.Show();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                MySqlConnection connection = yhteys.otaYhteys();
                connection.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM `Products` WHERE `Id` = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connection.Close();
                dataGridView1.DataSource = haeTuottet();
                nameTextBox.Text = "";
                descriptionTextBox.Text = "";
                hintaTB.Text = "";
                pictureBox1.Image = null;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Image image = dataGridView1.CurrentRow.Cells[0].FormattedValue as Image;
            pictureBox1.Image = image;
            nameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            descriptionTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hintaTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            idTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = yhteys.otaYhteys();
            connection.Open();
            MySqlCommand komento = new MySqlCommand("UPDATE `Products` SET `Nimi` = @nimi, `Tieto` =@tieto, `Price` =@hinta, `Kuva` =@Kuva  WHERE `Id` =@id", connection);
            ImageConverter converter = new ImageConverter();
            byte[] imageBytes = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            komento.Parameters.AddWithValue("@Kuva", imageBytes);
            komento.Parameters.Add("@Id", MySqlDbType.Int32).Value = idTB.Text;
            komento.Parameters.Add("@hinta", MySqlDbType.Double).Value = hintaTB.Text;
            komento.Parameters.Add("@Tieto", MySqlDbType.VarChar).Value = descriptionTextBox.Text;
            komento.Parameters.Add("@Nimi", MySqlDbType.VarChar).Value = nameTextBox.Text;

            komento.ExecuteNonQuery();
            connection.Close();
            dataGridView1.DataSource = haeTuottet();
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            hintaTB.Text = "";
            pictureBox1.Image = null;
        }


        private void televisioBT_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Nimi = 'TELEVISIO'";
        }

        private void tietokoneBT_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Nimi = 'TIETOKONE'";
        }

        private void nappaimistoBT_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Nimi = 'Hiiri' OR Nimi = 'Näppäimistö'";
        }

        private void pelikonsoliBT_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Nimi = 'Konsoli'";
        }

        private void puhelimetBT_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Nimi = 'Puhelin'";
        }

        private void naytaKaikkiBT_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "";
        }

    }
}
