﻿namespace MB.Models
{
    using System;

    using Base;

    public class HotelComment : BaseModel<int>
    {
        public HotelComment()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        public string Content { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public DateTime CreatedOn { get; set; }

        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        public string UserId { get; set; }
        public virtual MbUser User { get; set; }
    }
}
