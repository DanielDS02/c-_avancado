using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.JsonSerializer;

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



        public class Serializar
        {
            public string Serializar<Music>(Music music)
            {
                File.ReadAllText(music)
                return JsonSerializer.Serialize(music);

            }

            string fileName = "musicLibrary.json";
        }
        public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
        }


                WeatherForecast? weatherForecast =
               JsonSerializer.Deserialize<WeatherForecast>(Music);

    }
}
