namespace ExercicioMusic
{
    public class Music
    {
       

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public string Genre { get; set; }

        public string Year { get; set;  }


        public Music(string Title, string Artist, string Album, string Genre, string Year)
        {
            Title = string.Empty;
            Artist = string.Empty;
            Album = string.Empty;
            Genre = string.Empty;
            Year = string.Empty;
        }
    }
}
