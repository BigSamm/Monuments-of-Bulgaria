﻿namespace MB.ViewModels.Hotels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class HotelEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Stars { get; set; }

        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; }
        
        [Required]
        [Display(Name = "Oblasts")]
        public int SelectedOblastId { get; set; }
        public IEnumerable<SelectListItem> Oblasts { get; set; }
    }
}
