using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Default
{
    class Program
    {
        public enum GenreFilm
        {
            Actiefilm,
            Avonturenfilm,
            Biografischefilm,
            Drama,
            Detective,
            Familiefilm,
            Fantasyfilm,
            Gangsterfilm,
            Historischdrama,
            Horrorfilm,
            Komedie,
            Kostuumdrama,
            Melodrama,
            Misdaadfilm,
            Musicalfilm,
            Muziekfilm,
            Mystery,
            Oorlogsfilm,
            Pornofilm,
            Psychologischethriller,
            Rampenfilm,
            Roadmovie,
            Romantischefilm,
            Romantischekomedie,
            Sciencefiction,
            Sportfilm,
            Sandalenfilm,
            Thriller,
            Tragikomedie,
            Western,
            Onbekend
        }
        public static void FilmRuntime(string naamFilm, int tijdMinutenFilm = 90, GenreFilm filmgenre = GenreFilm.Onbekend)
        {
            if (tijdMinutenFilm == 0)
            {
                tijdMinutenFilm = 90;
            }
            Console.WriteLine($"{naamFilm} ({tijdMinutenFilm} minuten, {filmgenre})");
        }
        static void Main(string[] args)
        {
            FilmRuntime("The Matrix", 120, GenreFilm.Actiefilm);
            FilmRuntime("The Matrix", 120);
            FilmRuntime("The Matrix");
            Console.ReadLine();
        }
    }
}
