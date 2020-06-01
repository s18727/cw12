using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw12.Models
{
    public class Movie
    {
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        private string title;

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }

        private DateTime releaseDate;

        public DateTime GetReleaseDate()
        {
            return releaseDate;
        }

        public void SetReleaseDate(DateTime value)
        {
            releaseDate = value;
        }

        private string genre;

        public string GetGenre()
        {
            return genre;
        }

        public void SetGenre(string value)
        {
            genre = value;
        }

        private decimal price;

        public decimal GetPrice()
        {
            return price;
        }

        public void SetPrice(decimal value)
        {
            price = value;
        }

        private string rating;

        public string GetRating()
        {
            return rating;
        }

        public void SetRating(string value)
        {
            rating = value;
        }
    }
}

