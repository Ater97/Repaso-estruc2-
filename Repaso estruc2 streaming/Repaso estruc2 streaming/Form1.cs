using Repaso_estruc2_streaming.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using WMPLib;

namespace Repaso_estruc2_streaming
{
    public partial class la : Form
    {
        public la()
        {
            InitializeComponent();
            Playlists.Add("Canciones", new List<Song>());
            k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            k.FlatAppearance.BorderSize = 0;
            k.FlatAppearance.MouseDownBackColor = Color.Transparent;
            k.FlatAppearance.MouseOverBackColor = Color.Transparent;
            k.BackColor = Color.Transparent;
            plsgbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            plsgbtn.FlatAppearance.BorderSize = 0;
            plsgbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            plsgbtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            plsgbtn.BackColor = Color.Transparent;
            Previoussong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Previoussong.FlatAppearance.BorderSize = 0;
            Previoussong.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Previoussong.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Previoussong.BackColor = Color.Transparent;
        }
        Dictionary<string, List<Song>> Playlists = new Dictionary<string, List<Song>>();
        string PathSong, playlistName; //song to play
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<string> err = new List<string>(); //lst for errors
        BindingSource bindingSource = new BindingSource();
        BindingSource bindingSourcelst = new BindingSource();
        int p = 0, l = 0;
        List<Song> tmlts; //lst for everything
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Create_Song_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            Playlists.TryGetValue("Canciones", out tmlts);
            bindingSource.DataSource = tmlts;
            dataGridView1.DataSource = bindingSource;
            groupBox2.Enabled = true;
            groupBox2.Visible = true;
        }

        private void Create_Playlist_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
                Create_Song.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione por lo menos una cancion");
            }
        }
        private void CreatePlaylist()
        {
            try
            {
                bindingSourcelst = new BindingSource();
                List<Song> tmp = new List<Song>();
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    if (tmp.Any(item => item.Name == tmlts[r.Index].Name))
                    {
                        err.Add(tmlts[r.Index].Name);
                        break;
                    }
                    tmp.Add(tmlts[r.Index]);
                }
                if (err.Count > 0)
                {
                    var message = string.Join(Environment.NewLine, err);
                    MessageBox.Show("Las siguientes canciones ya se encuentrar en la playlist: " + Environment.NewLine + message);
                    err = new List<string>();
                }
                Playlists.Add(playlistName, tmp);
                bindingSourcelst.DataSource = Playlists.Keys;
                listBox1.DataSource = bindingSourcelst;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, intente de nuevo");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uploadbtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Multiselect = true;
                openFileDialog1.Filter = "Cursor Files|*.mp3";

                string[] files, paths;
                string artist, album, title;
                int year;
                TimeSpan length;
                Song song;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    files = openFileDialog1.SafeFileNames;
                    paths = openFileDialog1.FileNames;
                    for (int i = 0; i < files.Length; i++)
                    {
                        try
                        {
                            TagLib.File tagFile = TagLib.File.Create(paths[i]);

                            album = tagFile.Tag.Album;
                            title = tagFile.Tag.Title;
                            artist = tagFile.Tag.FirstArtist;
                            year = int.Parse(tagFile.Tag.Year.ToString());
                            length = tagFile.Properties.Duration;

                            song = new Song(title, length, year, artist, album, paths[i], files[i]);

                            if (Playlists["Canciones"].Any(item => item.Name == title))
                            {
                                err.Add(paths[i]);
                            }
                            else
                                Playlists["Canciones"].Add(song);
                        }
                        catch
                        {
                            err.Add(paths[i]);
                        }
                    }
                    if (err.Count > 0)
                    {
                        var message = string.Join(Environment.NewLine, err);
                        message = "Las siguientes canciones no se cargaron por uno de los siguietes motivos: " + Environment.NewLine +
                        "*Ya sencontraban cargadas " + Environment.NewLine + "*Ocurrio un error al cargarlas" + Environment.NewLine +
                        "*El archivo no es compatible" + Environment.NewLine + Environment.NewLine + message;
                        MessageBox.Show(message);

                        err = new List<string>();
                    }
                }
                bindingSourcelst = new BindingSource();
                Playlists.TryGetValue("Canciones", out tmlts);
                PathSong = tmlts[0].getPath();
                bindingSourcelst.DataSource = Playlists.Keys;
              
                //plsgbtn.ImageList = imageList1;
                //plsgbtn.ImageIndex = 1;
                //plsgbtn.BackgroundImage = plsgbtn.Image;
              //  plsgbtn.BackgroundImageLayout = ImageLayout.Stretch;

                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton3.Checked = true;
                radioButton1.Checked = true;
                Allsongs.Enabled = true;
                Create_Playlist.Enabled = true;
                k.Enabled = true;
                plsgbtn.Enabled = true;
                Previoussong.Enabled = true;
                Search.Enabled = true;
                listBox1.DataSource = bindingSourcelst;
                bindingSource = new BindingSource();
                Playlists.TryGetValue("Canciones", out tmlts);
                bindingSource.DataSource = tmlts;
                dataGridView1.DataSource = bindingSource;
                label3.Text = ("PLaylist actual:" + Environment.NewLine + "Canciones");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void plsgbtn_Click(object sender, EventArgs e)
        {
            if (p == 0)
            {
                PlayFile(PathSong);
            }
            else
            {
                player.controls.pause();
                //plsgbtn.BackgroundImage = imageList1.Images[0];
                //plsgbtn.BackgroundImageLayout = ImageLayout.Stretch;
                p = 0;
            }
        }

        public void PlayFile(string path)
        {
            try
            {
                player.URL = path;
                player.controls.play();
                double i = player.currentMedia.duration;
                //plsgbtn.BackgroundImage = imageList1.Images[1];
                //plsgbtn.BackgroundImageLayout = ImageLayout.Stretch;
                p = 1;
            }
            catch
            {
                MessageBox.Show("Seleccione un cancion, doble click.");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                Song S;
                Playlists.TryGetValue(playlistName, out tmlts);
                if (tmlts.Any(item => item.Name.ToUpper() == textBox1.Text.ToUpper()))
                {
                    S = tmlts.Find(i => i.Name.ToUpper() == textBox1.Text.ToUpper());

                    bindingSource = new BindingSource();
                    bindingSource.DataSource = S;
                    dataGridView1.DataSource = bindingSource;
                }
                else
                {
                    Playlists.TryGetValue("Canciones", out tmlts);
                    if (tmlts.Any(item => item.Name.ToUpper() == textBox1.Text.ToUpper()))
                    {
                        S = tmlts.Find(i => i.Name.ToUpper() == textBox1.Text.ToUpper());

                        bindingSource = new BindingSource();
                        bindingSource.DataSource = S;
                        dataGridView1.DataSource = bindingSource;
                        MessageBox.Show("La cancion no se encuentra en la playlist " + playlistName + Environment.NewLine + ", pero se encuentra en Todas las canciones :)");
                    }
                    else
                    {
                        MessageBox.Show("La cancion no se encuentra");
                    }
                }
            }
            catch
            {
                MessageBox.Show("La cancion no se encuentra");
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                playlistName = listBox1.GetItemText(listBox1.SelectedItem);
                dataGridView1.DataSource = tmlts = Playlists[playlistName];
                PathSong = tmlts[0].getPath();
                p = 0;
                label3.Text = ("PLaylist actual:" + Environment.NewLine + playlistName);
                if (playlistName == "Canciones")
                {
                    groupBox2.Enabled = false;
                    groupBox2.Visible = false;
                    Create_Song.Enabled = false;
                }
                else
                {
                    Create_Song.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Error: carga playlist");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Cut"));
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            l = e.RowIndex;
            PathSong = tmlts[l].getPath();
            PlayFile(PathSong);
            p = 1;
        }

        private void Previoussong_Click(object sender, EventArgs e)
        {
            try
            {
                l = l - 1;
                PlayFile(tmlts[l].getPath());
            }
            catch
            {
                MessageBox.Show("Final de la lista");
            }
        }

        private void Allsongs_Click(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            Playlists.TryGetValue("Canciones", out tmlts);
            bindingSource.DataSource = tmlts;
            dataGridView1.DataSource = bindingSource;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetDatagrid();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetDatagrid();
        }

        private void k_Click(object sender, EventArgs e)
        {
            try
            {
                l = l + 1;
                PlayFile(tmlts[l].getPath());
            }
            catch
            {
                MessageBox.Show("Final de la lista");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetDatagrid();
        }

        private void Addplaylst_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    if (Playlists[playlistName].Any(item => item.Name == tmlts[r.Index].Name))
                    {
                        err.Add(tmlts[r.Index].Name);
                    }
                    else
                        Playlists[playlistName].Add(tmlts[r.Index]);
                }
                if (err.Count > 0)
                {
                    var message = string.Join(Environment.NewLine, err);
                    MessageBox.Show("Las siguientes canciones ya se encuentrar en la playlist: " + Environment.NewLine + message);
                    err = new List<string>();
                }

            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void DeletePlaylst_Click(object sender, EventArgs e)
        {
            try
            {
                List<Song> tmp = new List<Song>();
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    if (Playlists[playlistName].Any(item => item.Name == tmlts[r.Index].Name))
                    {

                        tmp.Add(tmlts[r.Index]);
                    }
                    else
                        err.Add(tmlts[r.Index].Name);
                }
                if (err.Count > 0)
                {
                    var message = string.Join(Environment.NewLine, err);
                    MessageBox.Show("Las siguientes canciones no se encontraban en la playlist: " + Environment.NewLine + message);
                    err = new List<string>();
                }
                Playlists[playlistName] = Playlists[playlistName].Except(tmp).ToList();
                Playlists.TryGetValue(playlistName, out tmlts);
                if (tmlts.Count == 0)
                {
                    DeletePlaylist(playlistName);
                }
                else
                {
                    bindingSource.DataSource = tmlts;
                    dataGridView1.DataSource = bindingSource;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error, intente de nuevo");
            }
        }
        private void DeletePlaylist(string playlistname)
        {
            Playlists.Remove(playlistName);
            bindingSourcelst = new BindingSource();
            bindingSourcelst.DataSource = Playlists.Keys;
            listBox1.DataSource = bindingSourcelst;
            bindingSource = new BindingSource();
            Playlists.TryGetValue("Canciones", out tmlts);
            bindingSource.DataSource = tmlts;
            dataGridView1.DataSource = bindingSource;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DeletePlaylist(playlistName);
            }
            catch
            {
                MessageBox.Show("No se logro eliminar la playlist");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SetDatagrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Playlists.Keys.Contains(textBox2.Text))
                {
                    if (textBox2.Text.Trim() != "")
                    {
                        groupBox1.Enabled = false;
                        groupBox1.Visible = false;
                        playlistName = textBox2.Text;
                        CreatePlaylist();
                        bindingSource = new BindingSource();
                        Playlists.TryGetValue(playlistName, out tmlts);
                        bindingSource.DataSource = tmlts;
                        dataGridView1.DataSource = bindingSource;
                    }
                    else
                        MessageBox.Show("Ingrese un nombre");
                }
                else
                    MessageBox.Show("Ya existe una playlist con ese nombre");

                textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void SetDatagrid()
        {
            try
            {
                bindingSource = new BindingSource();
                List<Song> SortedList = new List<Song>();
                if (radioButton1.Checked)
                {
                    if (radioButton3.Checked)
                    {
                        SortedList = tmlts.OrderBy(i => i.Name).ToList<Song>();
                    }
                    else
                    {
                        SortedList = tmlts.OrderByDescending(i => i.Name).ToList<Song>();
                    }
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        SortedList = tmlts.OrderBy(i => i.Length).ToList<Song>();
                    }
                    else
                    {
                        SortedList = tmlts.OrderByDescending(i => i.Length).ToList<Song>();
                    }
                }
                bindingSource.DataSource = SortedList;
                tmlts = SortedList;
                dataGridView1.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show("Verifique las canciones cargadas");
            }
        }
    }
}
