using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021__TEAM_MYK_.Models
{
    public class AddIncidentView
    {
        public Customer  Customer{ get; set; }
        public Product Product { get; set; }
        public Technician Technician{ get; set; }
        public Incident Incident { get; set; }
        public string Operation { get; set; }
    }
}
