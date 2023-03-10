﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO___Music
{
    public class Song : IComparable
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
            for (int i = 0; i < Length/1000; i++)
            {
                Console.Write(".");
                Console.Beep();
                Thread.Sleep(1000);
            }

            Console.WriteLine($"\nFinished playing: {Title} by {Artist.Name}");
        }

        public override string ToString()
        {
            return $"{Title} - {Artist.Name} - {Genre} - {Length}";
        }

        public int CompareTo(Song song)
        {
            return this.Title.CompareTo(song.Title);

            /*    if (this.Title 'komt voor' song.Title)
                    return -1;
                  else if (this.Title 'is gelijk aan' song.Title)
                    return 0;
                  else return 1*/
        }

        public int CompareTo(object? obj)
        {
            //obj kan null zijn, maar we gaan ervan uit dat dat niet het geval is ;)
            return this.Title.CompareTo(((Song)obj).Title);
        }
    }
}
