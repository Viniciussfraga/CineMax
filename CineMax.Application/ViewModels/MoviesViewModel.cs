﻿using CineMax.Core.Enums;

namespace CineMax.Application.ViewModels
{
    public class MovieViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string TrailerURL { get; set; }
        public string Duration { get; set; }
        public MovieStatusEnum Status { get; set; }
    }
}
