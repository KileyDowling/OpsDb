using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpsDashboard.Models
{
  public class DashboardVM
  {
    public List<User> Users { get; set; }
    public List<Project> Projects { get; set; }
  }
}