using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Customer> customer { get; set; }
    }
}
