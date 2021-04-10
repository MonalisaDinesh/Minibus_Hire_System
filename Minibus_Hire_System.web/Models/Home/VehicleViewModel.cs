using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minibus_Hire_System.web.Models.Home
{
    public class VehicleViewModel
    {
        public Guid VehicleId { get; set; }
        public string Name { get; set; }
        public string imageName { get; set; }
        public string ShortDescr { get; set; }
        public string Description { get; set; }

    }
}
