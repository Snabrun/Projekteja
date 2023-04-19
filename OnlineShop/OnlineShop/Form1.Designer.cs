namespace OnlineShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.televisioBT = new System.Windows.Forms.Button();
            this.tietokoneBT = new System.Windows.Forms.Button();
            this.nappaimistoBT = new System.Windows.Forms.Button();
            this.pelikonsoliBT = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tuoteHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hintaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puhelimetBT = new System.Windows.Forms.Button();
            this.tilaaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.adminBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.editBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.hintaTB = new System.Windows.Forms.TextBox();
            this.hintaLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.yhteensaTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.naytaKaikkiBT = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // televisioBT
            // 
            this.televisioBT.BackColor = System.Drawing.Color.Coral;
            this.televisioBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.televisioBT.Location = new System.Drawing.Point(12, 135);
            this.televisioBT.Name = "televisioBT";
            this.televisioBT.Size = new System.Drawing.Size(172, 54);
            this.televisioBT.TabIndex = 1;
            this.televisioBT.Text = "Televisiot";
            this.televisioBT.UseVisualStyleBackColor = false;
            this.televisioBT.Click += new System.EventHandler(this.televisioBT_Click);
            // 
            // tietokoneBT
            // 
            this.tietokoneBT.BackColor = System.Drawing.Color.Coral;
            this.tietokoneBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tietokoneBT.Location = new System.Drawing.Point(190, 135);
            this.tietokoneBT.Name = "tietokoneBT";
            this.tietokoneBT.Size = new System.Drawing.Size(172, 54);
            this.tietokoneBT.TabIndex = 2;
            this.tietokoneBT.Text = "Tietokoneet";
            this.tietokoneBT.UseVisualStyleBackColor = false;
            this.tietokoneBT.Click += new System.EventHandler(this.tietokoneBT_Click);
            // 
            // nappaimistoBT
            // 
            this.nappaimistoBT.BackColor = System.Drawing.Color.Coral;
            this.nappaimistoBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nappaimistoBT.Location = new System.Drawing.Point(368, 134);
            this.nappaimistoBT.Name = "nappaimistoBT";
            this.nappaimistoBT.Size = new System.Drawing.Size(182, 54);
            this.nappaimistoBT.TabIndex = 3;
            this.nappaimistoBT.Text = "Hiiret ja Näppäimistöt\r\n";
            this.nappaimistoBT.UseVisualStyleBackColor = false;
            this.nappaimistoBT.Click += new System.EventHandler(this.nappaimistoBT_Click);
            // 
            // pelikonsoliBT
            // 
            this.pelikonsoliBT.BackColor = System.Drawing.Color.Coral;
            this.pelikonsoliBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelikonsoliBT.Location = new System.Drawing.Point(556, 134);
            this.pelikonsoliBT.Name = "pelikonsoliBT";
            this.pelikonsoliBT.Size = new System.Drawing.Size(182, 54);
            this.pelikonsoliBT.TabIndex = 4;
            this.pelikonsoliBT.Text = "Pelikonsolit";
            this.pelikonsoliBT.UseVisualStyleBackColor = false;
            this.pelikonsoliBT.Click += new System.EventHandler(this.pelikonsoliBT_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tuoteHD,
            this.hintaHD});
            this.listView1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1117, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 362);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tuoteHD
            // 
            this.tuoteHD.Text = "Tuote";
            this.tuoteHD.Width = 165;
            // 
            // hintaHD
            // 
            this.hintaHD.Text = "Hinta";
            this.hintaHD.Width = 134;
            // 
            // puhelimetBT
            // 
            this.puhelimetBT.BackColor = System.Drawing.Color.Coral;
            this.puhelimetBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelimetBT.Location = new System.Drawing.Point(744, 135);
            this.puhelimetBT.Name = "puhelimetBT";
            this.puhelimetBT.Size = new System.Drawing.Size(189, 54);
            this.puhelimetBT.TabIndex = 6;
            this.puhelimetBT.Text = "Puhelimet";
            this.puhelimetBT.UseVisualStyleBackColor = false;
            this.puhelimetBT.Click += new System.EventHandler(this.puhelimetBT_Click);
            // 
            // tilaaBT
            // 
            this.tilaaBT.BackColor = System.Drawing.Color.Coral;
            this.tilaaBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilaaBT.Location = new System.Drawing.Point(1117, 655);
            this.tilaaBT.Name = "tilaaBT";
            this.tilaaBT.Size = new System.Drawing.Size(257, 45);
            this.tilaaBT.TabIndex = 8;
            this.tilaaBT.Text = "Tilaa";
            this.tilaaBT.UseVisualStyleBackColor = false;
            this.tilaaBT.Click += new System.EventHandler(this.tilaaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.BackColor = System.Drawing.Color.Coral;
            this.tyhjennaBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(1117, 706);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(257, 40);
            this.tyhjennaBT.TabIndex = 9;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = false;
            // 
            // adminBT
            // 
            this.adminBT.BackColor = System.Drawing.Color.Coral;
            this.adminBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBT.ForeColor = System.Drawing.Color.ForestGreen;
            this.adminBT.Location = new System.Drawing.Point(1244, 135);
            this.adminBT.Name = "adminBT";
            this.adminBT.Size = new System.Drawing.Size(130, 54);
            this.adminBT.TabIndex = 10;
            this.adminBT.Text = "Admin LogIn";
            this.adminBT.UseVisualStyleBackColor = false;
            this.adminBT.Click += new System.EventHandler(this.adminBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 100);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Ink Free", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(297, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Egorin ja Petjan Kodinkoneet";
            // 
            // logOutBT
            // 
            this.logOutBT.BackColor = System.Drawing.Color.OrangeRed;
            this.logOutBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold);
            this.logOutBT.Location = new System.Drawing.Point(1257, 135);
            this.logOutBT.Name = "logOutBT";
            this.logOutBT.Size = new System.Drawing.Size(91, 54);
            this.logOutBT.TabIndex = 13;
            this.logOutBT.Text = "Admin LogOut";
            this.logOutBT.UseVisualStyleBackColor = false;
            this.logOutBT.Click += new System.EventHandler(this.logOutBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 483);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.Linen;
            this.adminPanel.Controls.Add(this.editBT);
            this.adminPanel.Controls.Add(this.label6);
            this.adminPanel.Controls.Add(this.idTB);
            this.adminPanel.Controls.Add(this.hintaTB);
            this.adminPanel.Controls.Add(this.hintaLB);
            this.adminPanel.Controls.Add(this.label3);
            this.adminPanel.Controls.Add(this.label2);
            this.adminPanel.Controls.Add(this.descriptionTextBox);
            this.adminPanel.Controls.Add(this.SelectImageButton);
            this.adminPanel.Controls.Add(this.DeleteProductButton);
            this.adminPanel.Controls.Add(this.AddProductButton);
            this.adminPanel.Controls.Add(this.nameTextBox);
            this.adminPanel.Controls.Add(this.pictureBox1);
            this.adminPanel.Location = new System.Drawing.Point(1117, 203);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(248, 357);
            this.adminPanel.TabIndex = 16;
            // 
            // editBT
            // 
            this.editBT.BackColor = System.Drawing.Color.Linen;
            this.editBT.Location = new System.Drawing.Point(206, 331);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(34, 23);
            this.editBT.TabIndex = 12;
            this.editBT.Text = "Edit";
            this.editBT.UseVisualStyleBackColor = false;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id:";
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.SystemColors.Window;
            this.idTB.Enabled = false;
            this.idTB.Location = new System.Drawing.Point(204, 251);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(36, 20);
            this.idTB.TabIndex = 10;
            // 
            // hintaTB
            // 
            this.hintaTB.BackColor = System.Drawing.SystemColors.Window;
            this.hintaTB.Location = new System.Drawing.Point(84, 302);
            this.hintaTB.Name = "hintaTB";
            this.hintaTB.Size = new System.Drawing.Size(156, 20);
            this.hintaTB.TabIndex = 9;
            // 
            // hintaLB
            // 
            this.hintaLB.AutoSize = true;
            this.hintaLB.Location = new System.Drawing.Point(5, 305);
            this.hintaLB.Name = "hintaLB";
            this.hintaLB.Size = new System.Drawing.Size(35, 13);
            this.hintaLB.TabIndex = 8;
            this.hintaLB.Text = "Hinta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tuotekuvaus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tuotenimi:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.Location = new System.Drawing.Point(84, 277);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(156, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.BackColor = System.Drawing.Color.Linen;
            this.SelectImageButton.BackgroundImage = global::OnlineShop.Properties.Resources._124506;
            this.SelectImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectImageButton.Location = new System.Drawing.Point(165, 330);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(35, 23);
            this.SelectImageButton.TabIndex = 4;
            this.SelectImageButton.UseVisualStyleBackColor = false;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.Linen;
            this.DeleteProductButton.Location = new System.Drawing.Point(84, 330);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProductButton.TabIndex = 3;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.Linen;
            this.AddProductButton.Location = new System.Drawing.Point(3, 330);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProductButton.TabIndex = 2;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Location = new System.Drawing.Point(84, 251);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(91, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lisaaBT
            // 
            this.lisaaBT.BackColor = System.Drawing.Color.Coral;
            this.lisaaBT.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaBT.Location = new System.Drawing.Point(12, 684);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(1099, 62);
            this.lisaaBT.TabIndex = 17;
            this.lisaaBT.Text = "Lisää ostoskoriin\r\n";
            this.lisaaBT.UseVisualStyleBackColor = false;
            this.lisaaBT.Click += new System.EventHandler(this.lisaaBT_Click);
            // 
            // yhteensaTB
            // 
            this.yhteensaTB.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yhteensaTB.Location = new System.Drawing.Point(1117, 618);
            this.yhteensaTB.Name = "yhteensaTB";
            this.yhteensaTB.Size = new System.Drawing.Size(257, 31);
            this.yhteensaTB.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(1118, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 46);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(44, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 43);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yhteensä:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1118, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yhteensä:";
            // 
            // naytaKaikkiBT
            // 
            this.naytaKaikkiBT.BackColor = System.Drawing.Color.Coral;
            this.naytaKaikkiBT.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naytaKaikkiBT.Location = new System.Drawing.Point(939, 134);
            this.naytaKaikkiBT.Name = "naytaKaikkiBT";
            this.naytaKaikkiBT.Size = new System.Drawing.Size(172, 54);
            this.naytaKaikkiBT.TabIndex = 20;
            this.naytaKaikkiBT.Text = "Näytä kaikki";
            this.naytaKaikkiBT.UseVisualStyleBackColor = false;
            this.naytaKaikkiBT.Click += new System.EventHandler(this.naytaKaikkiBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1394, 758);
            this.Controls.Add(this.naytaKaikkiBT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yhteensaTB);
            this.Controls.Add(this.lisaaBT);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutBT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.adminBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.tilaaBT);
            this.Controls.Add(this.puhelimetBT);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pelikonsoliBT);
            this.Controls.Add(this.nappaimistoBT);
            this.Controls.Add(this.tietokoneBT);
            this.Controls.Add(this.televisioBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button televisioBT;
        private System.Windows.Forms.Button tietokoneBT;
        private System.Windows.Forms.Button nappaimistoBT;
        private System.Windows.Forms.Button pelikonsoliBT;
        private System.Windows.Forms.Button puhelimetBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button logOutBT;
        public System.Windows.Forms.Button adminBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Button tilaaBT;
        public System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lisaaBT;
        private System.Windows.Forms.ColumnHeader tuoteHD;
        private System.Windows.Forms.ColumnHeader hintaHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox yhteensaTB;
        private System.Windows.Forms.TextBox hintaTB;
        private System.Windows.Forms.Label hintaLB;
        private System.Windows.Forms.Button naytaKaikkiBT;
        public System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button editBT;
    }
}

