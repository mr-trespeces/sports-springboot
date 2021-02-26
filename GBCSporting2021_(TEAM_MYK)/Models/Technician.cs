using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Technician
    {
        public int TechnicianId { get; set; }

        [Required(ErrorMessage = "*Please enter a valid name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Please enter a valid phone")]
        public string Phone { get; set; }
        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}
