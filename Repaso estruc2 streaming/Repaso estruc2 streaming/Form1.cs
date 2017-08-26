using Repaso_estruc2_streaming.Class;
using System;
using System.Collections.Generic;
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
       
        Dictionary<string,Song> Songs = new Dictionary<string,Song>();
        string PathSong;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        List<string> err = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Create_Song_Click(object sender, EventArgs e)
        {

        }

        private void Create_Playlist_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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
                            artist = tagFile.Tag.FirstAlbumArtist;
                            year = int.Parse(tagFile.Tag.Year.ToString());
                            length = tagFile.Properties.Duration;

                            song = new Song(title, length, year, artist, album, paths[i], files[i]);
                            Songs.Add(files[i], song);
                        }
                        catch 
                        {
                            err.Add(paths[i]);
                        }
                    }
                    if(err.Count>0)
                    {
                        var message = string.Join(Environment.NewLine, err);
                        MessageBox.Show("Error con: " + message);
                    }
                }
                dataGridView1.DataSource = Songs;
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void plsgbtn_Click(object sender, EventArgs e)
        {
            PlayFile(PathSong);
        }

        public void PlayFile(String path)
        {
            try
            {
                player.URL = path;
                player.controls.play();
                double i = player.currentMedia.duration;
               
            }
            catch
            {
                MessageBox.Show("El archivo no es compatible, utilice .mp3");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
