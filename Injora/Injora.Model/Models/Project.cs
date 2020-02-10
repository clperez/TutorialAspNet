using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injora.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CampaignMinimum { get; set; }
        public string Category { get; set; }
    }
}
