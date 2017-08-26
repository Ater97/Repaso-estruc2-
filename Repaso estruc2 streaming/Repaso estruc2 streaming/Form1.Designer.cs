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
            this.SortNamerabtn = new System.Windows.Forms.RadioButton();
            this.SortLengthrbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.Button();
            this.Previoussong = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Create_Song.Location = new System.Drawing.Point(12, 41);
            this.Create_Song.Name = "Create_Song";
            this.Create_Song.Size = new System.Drawing.Size(91, 23);
            this.Create_Song.TabIndex = 1;
            this.Create_Song.Text = "Crear cancion";
            this.Create_Song.UseVisualStyleBackColor = true;
            this.Create_Song.Click += new System.EventHandler(this.Create_Song_Click);
            // 
            // Create_Playlist
            // 
            this.Create_Playlist.Location = new System.Drawing.Point(12, 99);
            this.Create_Playlist.Name = "Create_Playlist";
            this.Create_Playlist.Size = new System.Drawing.Size(91, 23);
            this.Create_Playlist.TabIndex = 2;
            this.Create_Playlist.Text = "Crear Playlist";
            this.Create_Playlist.UseVisualStyleBackColor = true;
            this.Create_Playlist.Click += new System.EventHandler(this.Create_Playlist_Click);
            // 
            // Search
            // 
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
            this.Allsongs.Location = new System.Drawing.Point(12, 70);
            this.Allsongs.Name = "Allsongs";
            this.Allsongs.Size = new System.Drawing.Size(91, 23);
            this.Allsongs.TabIndex = 8;
            this.Allsongs.Text = "Canciones";
            this.Allsongs.UseVisualStyleBackColor = true;
            // 
            // plsgbtn
            // 
            this.plsgbtn.Location = new System.Drawing.Point(232, 334);
            this.plsgbtn.Name = "plsgbtn";
            this.plsgbtn.Size = new System.Drawing.Size(75, 23);
            this.plsgbtn.TabIndex = 9;
            this.plsgbtn.Text = "Reproducir";
            this.plsgbtn.UseVisualStyleBackColor = true;
            this.plsgbtn.Click += new System.EventHandler(this.plsgbtn_Click);
            // 
            // SortNamerabtn
            // 
            this.SortNamerabtn.AutoSize = true;
            this.SortNamerabtn.Location = new System.Drawing.Point(501, 80);
            this.SortNamerabtn.Name = "SortNamerabtn";
            this.SortNamerabtn.Size = new System.Drawing.Size(62, 17);
            this.SortNamerabtn.TabIndex = 10;
            this.SortNamerabtn.TabStop = true;
            this.SortNamerabtn.Text = "Nombre";
            this.SortNamerabtn.UseVisualStyleBackColor = true;
            this.SortNamerabtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SortLengthrbtn
            // 
            this.SortLengthrbtn.AutoSize = true;
            this.SortLengthrbtn.Location = new System.Drawing.Point(569, 80);
            this.SortLengthrbtn.Name = "SortLengthrbtn";
            this.SortLengthrbtn.Size = new System.Drawing.Size(68, 17);
            this.SortLengthrbtn.TabIndex = 11;
            this.SortLengthrbtn.TabStop = true;
            this.SortLengthrbtn.Text = "Duracion";
            this.SortLengthrbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ordenar por:";
            // 
            // k
            // 
            this.k.Location = new System.Drawing.Point(313, 334);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(75, 23);
            this.k.TabIndex = 13;
            this.k.Text = "Siguiente";
            this.k.UseVisualStyleBackColor = true;
            // 
            // Previoussong
            // 
            this.Previoussong.Location = new System.Drawing.Point(151, 334);
            this.Previoussong.Name = "Previoussong";
            this.Previoussong.Size = new System.Drawing.Size(75, 23);
            this.Previoussong.TabIndex = 14;
            this.Previoussong.Text = "Amterior";
            this.Previoussong.UseVisualStyleBackColor = true;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Artista,
            this.Duracion,
            this.Año,
            this.Album});
            this.dataGridView1.Location = new System.Drawing.Point(151, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 198);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Artista
            // 
            this.Artista.HeaderText = "Artista";
            this.Artista.Name = "Artista";
            this.Artista.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // la
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Previoussong);
            this.Controls.Add(this.k);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SortLengthrbtn);
            this.Controls.Add(this.SortNamerabtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.RadioButton SortNamerabtn;
        private System.Windows.Forms.RadioButton SortLengthrbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button k;
        private System.Windows.Forms.Button Previoussong;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
    }
}

