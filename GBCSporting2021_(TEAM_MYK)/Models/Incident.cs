using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }

        [Required(ErrorMessage = "Please enter a valid title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a valid customer")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Please enter a valid product")]
        public string Product { get; set; }

        [Required(ErrorMessage = "Please enter a valid date opened")]
        public string DateOpened { get; set; }
    }
}
