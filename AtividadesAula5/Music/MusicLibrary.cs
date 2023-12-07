using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace ExercicioMusic
{
    public class MusicLibrary
    {
        public List<Music> musics = [];

        public MusicLibrary()
        {

        }

        public void AdicionarMusicas()
        {
            musics.Add(new Music("Throne", "Bring Me The Horinzon", "That's The Spirit", "Heavy Metal", "2015"));
            musics.Add(new Music("Drown", "Bring Me The Horinzon", "That's The Spirit", "Heavy Metal", "2015"));
            musics.Add(new Music("Doomed", "Bring Me The Horinzon", "That's The Spirit", "Heavy Metal", "2015"));
            musics.Add(new Music("One Step Closer", "Linkin Park", "Hybrid Theory", "Heavy Metal", "2000"));
            musics.Add(new Music("Papercut", "Linkin Park", "Hybrid Theory", "Heavy Metal", "2000"));

        }



        public class Jason
        {
            public string Serializar<Music>(Music music)
            {
                return JsonSerializer.Serialize(music);

            }

            string fileName = "musicLibrary.json";
        }

    }
}
