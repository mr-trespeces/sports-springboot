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

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required(ErrorMessage = "Please enter a valid title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a valid description")]
        public string Description { get; set; }

        public int TechnicianId { get; set; }

        public Technician Technician { get; set; }

        public string DateOpened { get; set; }

        [Required(ErrorMessage = "Please enter a valid closed date")]
        public string DateClosed { get; set; }
    }
}
