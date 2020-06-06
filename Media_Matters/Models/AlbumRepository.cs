using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace Media_Matters.Models
{
    public class AlbumRepository : IAlbumRepository
    {
        public IEnumerable<Album> getAlbums() =>
            new List<Album>
            {
                // the Album list
                new Album{ AlbumId=1, AlbumTitle="Megalithic Symphony", AlbumArtist="Awolnation", 
                    Notes="I love the beat and they have a variety of styles for different songs.", AlbumCover="220px-Awolnation-Megalithic-Symphony.jpeg" },
                new Album{ AlbumId=2, AlbumTitle="All of Them", AlbumArtist="Enya", 
                    Notes="Perfect for when you need soothing/relaxing music.", AlbumCover="enyaadaywithoutrain.jpg" },
                new Album{ AlbumId=3, AlbumTitle="All of Them", AlbumArtist="Weird Al", 
                    Notes="He is so talented and funny and his songs are frequently better than the original.", AlbumCover="weirdalbadhairday.jpg" },
                new Album{ AlbumId=4, AlbumTitle="Gorillaz", AlbumArtist="Gorillaz", 
                    Notes="They have a variety of styles and I like the beat etc.", AlbumCover="gorillaz.png" },
                new Album{ AlbumId=5, AlbumTitle="Night Visions", AlbumArtist="Imagine Dragons",
                    Notes="Same as Awolnation and Gorillaz", AlbumCover="Imagine-Dragons-Evolve-album-cover-820.jpg" },
            };

        public Album getAlbumbyId(int Id)
        {
            //throw new NotImplementedException();
            return getAlbums().FirstOrDefault(p => p.AlbumId == Id);
        }
    }
}
