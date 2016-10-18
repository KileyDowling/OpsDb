using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpsDashboard.Models
{
  public class Certification
  {
    public string Vendor { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateAchieved { get; set; }
  
    }
}