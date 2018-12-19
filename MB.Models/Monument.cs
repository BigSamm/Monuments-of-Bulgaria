﻿namespace MB.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Base;

    public class Monument : BaseModel<int>
    {
        public Monument()
        {
            this.MonumentReviews = new HashSet<MonumentReview>();
            this.MonumentComments = new HashSet<MonumentComment>();
        }

        public string Name { get; set; }

        public string  Description { get; set; }

        public double OverallRating => this.MonumentReviews.Any() ? this.MonumentReviews.Average(x => (int)x.Rating) : 0;

        public int ReviewsCount => this.MonumentReviews.Count();

        public int CommentsCount => this.MonumentComments.Count();

        public int OblastId { get; set; }
        public virtual Oblast Oblast { get; set; }

        public virtual IEnumerable<MonumentReview> MonumentReviews { get; set; }

        public virtual IEnumerable<MonumentComment> MonumentComments { get; set; }
    }
}
