using Iterator;

class Program
{
    static void Main()
    {
        var playlist = new Playlist();
        playlist.AddSong(new Song("Song 1", "Abu noorah"));
        playlist.AddSong(new Song("Song 2", "Khalid abdualrahamn"));
        playlist.AddSong(new Song("Song 3", "meehad hamad"));

        var iterator = playlist.CreateIterator();
        while (iterator.HasNext())
        {
            var song = iterator.Next();
            Console.WriteLine($"{song.Title} by {song.Artist}");
        }
    }
}
