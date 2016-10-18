using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpsDashboard.Models
{
  public class User
  {

    public string FullName => FirstName + " " + LastName;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string Email { get; set; }
    public int EmployeeId { get; set; }
    public List<string> TechTags { get; set; }
    public List<Certification> Certifications { get; set; }
    public List<Project> Projects { get; set; }



  }
}