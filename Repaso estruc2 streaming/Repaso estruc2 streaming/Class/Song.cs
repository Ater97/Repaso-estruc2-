using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_estruc2_streaming.Class
{
    class Song
    {
        public Song (string name, TimeSpan lenght, int year, string artist, string album, string path, string filename)
        {
            Name = name;
            Length = lenght;
            Year = year;
            Artist = artist;
            Album = album;
            Path = path;
            FileName = filename;
        }

        public string Name { get; set; }
        public string Artist { get; set; }
        public TimeSpan Length { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }

        private string Path { get; set; }
        private string FileName { get; set; }

        public string getPath()
        {
            return Path;
        }
        public string getFileName()
        {
            return FileName;
        }
    }
}
