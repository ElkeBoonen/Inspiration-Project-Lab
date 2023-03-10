using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO___Music
{
    public class Song
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public Genres Genre { get; set; }
        public int Length { get; set; }

        public Song(string title, Artist artist, Genres genre, int length)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            Length = length;
        }

        public void Play()
        {
            Console.WriteLine($"Now playing: {Title} by {Artist.Name}");
            Thread.Sleep(Length);
            Console.WriteLine($"Finished playing: {Title} by {Artist.Name}");
        }
    }
}
