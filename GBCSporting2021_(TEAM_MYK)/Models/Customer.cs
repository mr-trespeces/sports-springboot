using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter a valid first name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a valid last name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a valid address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a valid city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a valid state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a valid postal code")]
        public string Postalcode { get; set; }

        [Range(1, 10, ErrorMessage = "Please select a country")]
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

    }
}
