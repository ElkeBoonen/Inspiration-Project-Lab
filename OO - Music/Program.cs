namespace OO___Music
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist Justin = new Artist("Justin Bieber", Genres.Pop);
            Artist Drake = new Artist("Drake", Genres.Rap);
            Artist Eminem = new Artist("Eminem", Genres.Rap);
            Artist Taylor = new Artist("Taylor Swift", Genres.Pop);
            Artist Caroline = new Artist("Caroline Polachek", Genres.Pop);
            Artist Billie = new Artist("Billie Eilish", Genres.Pop);

            Justin.AddAlbum();
            Justin.AddAlbum();
            Eminem.RemoveAlbum();

            List<Artist> artists = new List<Artist>();
            artists.Add(Justin);
            artists.Add(Drake);
            artists.Add(Eminem);
            artists.Add(Taylor);
            artists.Add(Caroline);
            artists.Add(Billie);
            foreach (var item in artists)
            {
                Console.WriteLine(item);
            }

            Song sorry = new Song("Sorry", Justin, Genres.Pop, 2000);
            Song hotlineBling = new Song("Hotline Bling", Drake, Genres.Rap, 3000);
            Song loseYourself = new Song("Lose Yourself", Eminem, Genres.Rap, 4000);
            Song shakeItOff = new Song("Shake It Off", Taylor, Genres.Pop, 5000);
            Song welcome = new Song("Welcome to my island", Caroline, Genres.Pop, 6000);
            Song badGuy = new Song("Bad Guy", Billie, Genres.Pop, 7000);

            List<Song> songs = new List<Song>();
            songs.Add(sorry);
            songs.Add(hotlineBling);
            songs.Add(loseYourself);
            songs.Add(shakeItOff);
            songs.Add(welcome);
            songs.Add(badGuy);

            PlayList IMS = new PlayList("IMS", songs);
            Console.WriteLine(IMS);

            IMS.Sort();
            Console.WriteLine(IMS);

            IMS.Shuffle();
            Console.WriteLine(IMS);

            //IMS.Play();
        }
    }
}