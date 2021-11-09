using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoutubeDownloader.Models
{
    public class url
    {
        private string youtubeUrl;

        private string format;

        public List<string> FormatList { get; set; }
        public string YoutubeUrl { get => youtubeUrl; set => youtubeUrl = value; }
        public string Format { get => format; set => format = value; }

        public url()
        {
            FormatList = new List<string>()
            {
               "mp3","m4a","aac","flac","opus","ogg","wav","webm","360","480","720p","1080","4k","8k"
            };

        }

    }
}
