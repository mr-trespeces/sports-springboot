using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "*Please enter a valid first name")]
        [StringLength(51, MinimumLength = 1)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "*Please enter a valid last name")]
        [StringLength(51, MinimumLength = 1)]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "*Please enter a valid address")]
        [StringLength(51, MinimumLength = 1)]
        public string Address { get; set; }

        [Required(ErrorMessage = "*Please enter a valid city")]
        [StringLength(51, MinimumLength = 1)]
        public string City { get; set; }

        [Required(ErrorMessage = "*Please enter a valid state")]
        [StringLength(51, MinimumLength = 1)]
        public string State { get; set; }

        [Required(ErrorMessage = "*Please enter a valid postal code")]
        [StringLength(21, MinimumLength = 1)]
        public string Postalcode { get; set; }

        [Range(1, 10, ErrorMessage = "*Please select a country")]
        public int CountryId { get; set; }

        [Required(ErrorMessage ="Please enter a valid email")]
        [StringLength(51, MinimumLength = 1)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please enter a valid email")]
        public string? Email { get; set; }

        [RegularExpression(@"^\(\d{3}\)\s\d{3}-\d{4}", ErrorMessage = "Please enter in (999) 999-9999 format")]
        public string? Phone { get; set; }

        public string Slug => Firstname?.Replace(' ', '-').ToLower()
            + '-' + Lastname?.Replace(' ', '-').ToLower();
    }
}
