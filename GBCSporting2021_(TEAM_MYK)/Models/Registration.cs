using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public Customer Customer { get; set; }
        [Range(1, 30, ErrorMessage = "Please select a Customer")]
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        [Range(1, 30, ErrorMessage = "Please select a Product")]
        public int ProductId { get; set; }
    }
}
