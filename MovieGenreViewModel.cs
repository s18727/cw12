using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw12.Models
{
    public class MovieGenreViewModel
    {
        private List<Movie> movies;

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public void SetMovies(List<Movie> value)
        {
            movies = value;
        }

        private SelectList genres;

        public SelectList GetGenres()
        {
            return genres;
        }

        public void SetGenres(SelectList value)
        {
            genres = value;
        }

        private string movieGenre;

        public string GetMovieGenre()
        {
            return movieGenre;
        }

        public void SetMovieGenre(string value)
        {
            movieGenre = value;
        }

        private string searchString;

        public string GetSearchString()
        {
            return searchString;
        }

        public void SetSearchString(string value)
        {
            searchString = value;
        }
    }
}
