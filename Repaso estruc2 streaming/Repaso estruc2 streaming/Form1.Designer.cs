namespace Repaso_estruc2_streaming
{
    partial class la
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
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.Create_Song = new System.Windows.Forms.Button();
            this.Create_Playlist = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Allsongs = new System.Windows.Forms.Button();
            this.plsgbtn = new System.Windows.Forms.Button();
            this.k = new System.Windows.Forms.Button();
            this.Previoussong = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Addplaylst = new System.Windows.Forms.Button();
            this.DeletePlaylst = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(12, 12);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(91, 23);
            this.Uploadbtn.TabIndex = 0;
            this.Uploadbtn.Text = "Cargar Canciones";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // Create_Song
            // 
            this.Create_Song.Enabled = false;
            this.Create_Song.Location = new System.Drawing.Point(12, 99);
            this.Create_Song.Name = "Create_Song";
            this.Create_Song.Size = new System.Drawing.Size(91, 23);
            this.Create_Song.TabIndex = 1;
            this.Create_Song.Text = "Editar Playlist";
            this.Create_Song.UseVisualStyleBackColor = true;
            this.Create_Song.Click += new System.EventHandler(this.Create_Song_Click);
            // 
            // Create_Playlist
            // 
            this.Create_Playlist.Enabled = false;
            this.Create_Playlist.Location = new System.Drawing.Point(12, 70);
            this.Create_Playlist.Name = "Create_Playlist";
            this.Create_Playlist.Size = new System.Drawing.Size(91, 23);
            this.Create_Playlist.TabIndex = 2;
            this.Create_Playlist.Text = "Crear Playlist";
            this.Create_Playlist.UseVisualStyleBackColor = true;
            this.Create_Playlist.Click += new System.EventHandler(this.Create_Playlist_Click);
            // 
            // Search
            // 
            this.Search.Enabled = false;
            this.Search.Location = new System.Drawing.Point(151, 74);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(91, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Buscar";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Playlists:";
            // 
            // Allsongs
            // 
            this.Allsongs.Enabled = false;
            this.Allsongs.Location = new System.Drawing.Point(12, 41);
            this.Allsongs.Name = "Allsongs";
            this.Allsongs.Size = new System.Drawing.Size(91, 23);
            this.Allsongs.TabIndex = 8;
            this.Allsongs.Text = "Canciones";
            this.Allsongs.UseVisualStyleBackColor = true;
            this.Allsongs.Click += new System.EventHandler(this.Allsongs_Click);
            // 
            // plsgbtn
            // 
            this.plsgbtn.Enabled = false;
            this.plsgbtn.Location = new System.Drawing.Point(232, 307);
            this.plsgbtn.Name = "plsgbtn";
            this.plsgbtn.Size = new System.Drawing.Size(75, 23);
            this.plsgbtn.TabIndex = 9;
            this.plsgbtn.Text = "Reproducir";
            this.plsgbtn.UseVisualStyleBackColor = true;
            this.plsgbtn.Click += new System.EventHandler(this.plsgbtn_Click);
            // 
            // k
            // 
            this.k.Enabled = false;
            this.k.Location = new System.Drawing.Point(313, 307);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(75, 23);
            this.k.TabIndex = 13;
            this.k.Text = "Siguiente";
            this.k.UseVisualStyleBackColor = true;
            this.k.Click += new System.EventHandler(this.k_Click);
            // 
            // Previoussong
            // 
            this.Previoussong.Enabled = false;
            this.Previoussong.Location = new System.Drawing.Point(151, 307);
            this.Previoussong.Name = "Previoussong";
            this.Previoussong.Size = new System.Drawing.Size(75, 23);
            this.Previoussong.TabIndex = 14;
            this.Previoussong.Text = "Anterior";
            this.Previoussong.UseVisualStyleBackColor = true;
            this.Previoussong.Click += new System.EventHandler(this.Previoussong_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(531, 198);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(89, 35);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(92, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Descendente ";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(6, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ascendente";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(587, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Duracion";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(504, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(498, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 55);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ordenar por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(232, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 95);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre de la playlist:";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.DeletePlaylst);
            this.groupBox2.Controls.Add(this.Addplaylst);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(196, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 70);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar playlist";
            this.groupBox2.Visible = false;
            // 
            // Addplaylst
            // 
            this.Addplaylst.Location = new System.Drawing.Point(6, 15);
            this.Addplaylst.Name = "Addplaylst";
            this.Addplaylst.Size = new System.Drawing.Size(71, 45);
            this.Addplaylst.TabIndex = 0;
            this.Addplaylst.Text = "Agregar canciones";
            this.Addplaylst.UseVisualStyleBackColor = true;
            this.Addplaylst.Click += new System.EventHandler(this.Addplaylst_Click);
            // 
            // DeletePlaylst
            // 
            this.DeletePlaylst.Location = new System.Drawing.Point(83, 15);
            this.DeletePlaylst.Name = "DeletePlaylst";
            this.DeletePlaylst.Size = new System.Drawing.Size(73, 45);
            this.DeletePlaylst.TabIndex = 1;
            this.DeletePlaylst.Text = "Eliminar canciones";
            this.DeletePlaylst.UseVisualStyleBackColor = true;
            this.DeletePlaylst.Click += new System.EventHandler(this.DeletePlaylst_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar playlist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // la
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Previoussong);
            this.Controls.Add(this.k);
            this.Controls.Add(this.plsgbtn);
            this.Controls.Add(this.Allsongs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Create_Playlist);
            this.Controls.Add(this.Create_Song);
            this.Controls.Add(this.Uploadbtn);
            this.Name = "la";
            this.Text = "bb";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.Button Create_Song;
        private System.Windows.Forms.Button Create_Playlist;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Allsongs;
        private System.Windows.Forms.Button plsgbtn;
        private System.Windows.Forms.Button k;
        private System.Windows.Forms.Button Previoussong;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeletePlaylst;
        private System.Windows.Forms.Button Addplaylst;
        private System.Windows.Forms.Button button2;
    }
}

