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
        public Customer Customer { get; set; }
        [Range(1, 30, ErrorMessage = "*Please select a Customer")]
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        [Range(1, 30, ErrorMessage = "*Please select a Product")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "*Please enter a valid title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "*Please enter a valid description")]
        public string Description { get; set; }
        public int? TechnicianId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DateOpened { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateClosed { get; set; }
        public string Slug => Title?.Replace(' ', '-').ToLower();

    }
}
