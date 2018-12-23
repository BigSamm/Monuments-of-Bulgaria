﻿namespace MB.Models.Hotels
{
    using System.Collections.Generic;
    using System.Linq;

    using Base;
    using Oblasts;

    public class Hotel : BaseModel<int>
    {
        public Hotel()
        {
            this.HotelReviews = new HashSet<HotelReview>();
            this.HotelComments = new HashSet<HotelComment>();
        }

        public string Name { get; set; }

        public int Stars { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public double OverallRating => this.HotelReviews.Any() ? this.HotelReviews.Average(x => (int)x.Rating) : 0;

        public int ReviewsCount => this.HotelReviews.Count();

        public int CommentsCount => this.HotelComments.Count();

        public int OblastId { get; set; }
        public virtual Oblast Oblast { get; set; }

        public virtual IEnumerable<HotelReview> HotelReviews { get; set; }

        public virtual IEnumerable<HotelComment> HotelComments { get; set; }
    }
}