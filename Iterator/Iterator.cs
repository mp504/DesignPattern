namespace Iterator
{


    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        public Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }
    }
    public interface ISongIterator
    {
        bool HasNext();
        Song Next();
    }


    public interface IPlaylist
    {
        ISongIterator CreateIterator();
        void AddSong(Song song);
        int Count { get; }
        Song this[int index] { get; }
    }

    public class Playlist : IPlaylist
    {
        private readonly List<Song> _songs = new List<Song>();

        public ISongIterator CreateIterator()
        {
            return new SongIterator(this);
        }

        public void AddSong(Song song)
        {
            _songs.Add(song);
        }

        public int Count => _songs.Count;

        public Song this[int index] => _songs[index];
    }

    public class SongIterator : ISongIterator
    {
        private readonly Playlist _playlist;
        private int _current = 0;

        public SongIterator(Playlist playlist)
        {
            _playlist = playlist;
        }

        public bool HasNext()
        {
            return _current < _playlist.Count;
        }

        public Song Next()
        {
            return _playlist[_current++];
        }
    }


}
