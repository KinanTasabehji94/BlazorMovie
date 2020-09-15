using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { Title = "SuperMan", ReleaseDate = new DateTime(2020, 1, 3), Poster = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SY1000_CR0,0,674,1000_AL_.jpg" },
                new Movie() { Title = "Hulk", ReleaseDate = new DateTime(2017, 4, 1), Poster = "https://m.media-amazon.com/images/M/MV5BMTU5OTA1OTkwNV5BMl5BanBnXkFtZTcwODM3ODkyMQ@@._V1_.jpg" },
                new Movie() { Title = "BatMan", ReleaseDate = new DateTime(2018, 5, 5), Poster="https://m.media-amazon.com/images/M/MV5BZjE4MTdhNGYtMjA1My00ODU1LTg0NzQtZDdiMmY0Y2E4NzY1XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg" }
            };
        }
    }
}
