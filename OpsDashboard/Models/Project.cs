using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpsDashboard.Models
{
  public class Project
  {
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public List<User> UsersOnProject {get; set; }
    public List<string> Tags { get; set; }
  }
}