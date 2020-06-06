using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string AlbumArtist { get; set; }
        public string AlbumCover { get; set; }
        public string Notes { get; set; }
    }
}
