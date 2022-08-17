﻿using Filmovita.Entity;
namespace Filmovita
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}