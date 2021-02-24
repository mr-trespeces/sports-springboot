using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        public string Name { get; set; }

        public List<SelectListItem> Countries { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "MX", Text = "Mexico" },
        new SelectListItem { Value = "CA", Text = "Canada" },
        new SelectListItem { Value = "US", Text = "USA"  },
    };
    }
}
