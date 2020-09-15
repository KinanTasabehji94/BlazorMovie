using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
