﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto
{
    internal class ReviewDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }

    }
}