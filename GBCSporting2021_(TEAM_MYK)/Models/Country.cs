using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Country
    {
        [Range(1, 10, ErrorMessage = "*Please select a country")]
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
}
