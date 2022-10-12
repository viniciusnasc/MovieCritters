﻿namespace MovieCritters.Domain.Models
{
    public class Movie : BaseModel
    {
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Type { get; set; }
        public bool IsAdult { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int RuntimeMinutes { get; set; }
        public List<string> Genres { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
    }
}