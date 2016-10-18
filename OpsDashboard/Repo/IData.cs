using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpsDashboard.Models;

namespace OpsDashboard.Repo
{
  interface IData
  {
    List<Project> GetAllProjects();
    List<User> GetAllUsers();
    List<Project> GetProjectsByUser(int id);
    List<string> GetTags();
    List<Certification> GetCertifications();
    User GetUser(int userId);
    Project GetProject(int id);
  }
}
