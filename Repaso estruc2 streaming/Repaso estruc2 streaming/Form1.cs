using Repaso_estruc2_streaming.Class;
using System;
using System.Collections;
using System.Collections.Generic;
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
        }
        Dictionary<string, List<Song>> Playlists = new Dictionary<string, List<Song>>();
        string PathSong, playlistName; //song to play
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<string> err = new List<string>(); //lst for errors
        BindingSource bindingSource = new BindingSource();
        BindingSource bindingSourcelst = new BindingSource();
        int p = 0, l = 0, u = 0;
        List<Song> tmlts; //lst for everything
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Create_Song_Click(object sender, EventArgs e)
        {
        }

        private void Create_Playlist_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count != 0)
            {
                groupBox1.Enabled = true;
                groupBox1.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccione por lo menos una cancion");
            }
        }
        private void CreatePlaylist()
        {
            bindingSourcelst = new BindingSource();
            Playlists.Add(playlistName, new List<Song>());
            // foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {

            }
            bindingSourcelst.DataSource = Playlists.Keys;
            listBox1.DataSource = bindingSourcelst;
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
                    List<Song> Songs = new List<Song>();
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
                            Songs.Add(song);
                        }
                        catch
                        {
                            err.Add(paths[i]);
                        }
                    }
                    Playlists.Add("Canciones", Songs);
                    if (err.Count > 0)
                    {
                        var message = string.Join(Environment.NewLine, err);
                        MessageBox.Show("Error con: " + message);
                        err = new List<string>();
                    }
                }
                bindingSource = new BindingSource();
                bindingSourcelst = new BindingSource();
                Playlists.TryGetValue("Canciones", out tmlts);
                bindingSource.DataSource = tmlts;
                bindingSourcelst.DataSource = Playlists.Keys;
                listBox1.DataSource = bindingSourcelst;
                dataGridView1.DataSource = bindingSource;
               // tmlts = ((IEnumerable)bindingSource.DataSource).Cast<Song>().ToList();
                u = 0;
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
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void plsgbtn_Click(object sender, EventArgs e)
        {
            if (u == 0)
            {
                PathSong = tmlts[0].getPath();
                u = 1;
            }
            else if (p == 0)
                PlayFile(PathSong);
            else
            {
                player.controls.pause();
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
                p = 1;
            }
            catch
            {
                MessageBox.Show("El archivo no es compatible, utilice .mp3");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        { try
            {
                Song S;
                if (Playlists.TryGetValue(playlistName, out tmlts))
                {
                    S = tmlts.Find(i => i.Name.ToUpper() == textBox1.Text.ToUpper());

                    bindingSource = new BindingSource();
                    bindingSource.DataSource = S;
                    dataGridView1.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("La cancion no se encuentra, intente en otra playlist");
                }
            }
            catch
            {
                MessageBox.Show("La cancion no se encuentra");
            }
            }
            

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            l = e.RowIndex;
            PlayFile(tmlts[l].getPath());
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SetDatagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h = 0;
            while (h == 0)
            {
                if (!Playlists.Keys.Contains(textBox2.Text))
                {
                    h = 1;
                    break;
                }
                MessageBox.Show("Ya existe una playlist con ese nombre");
                textBox2.Text = "";
            }
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            playlistName = textBox2.Text;
            CreatePlaylist();
            textBox2.Text = "";
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
