using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpsDashboard.Models;
using OpsDashboard.Repo;

namespace OpsDashboard.Controllers
{
  public class HomeController : Controller
  {
    IData _data = new TestData();

    IData _apiData = new TenThousandFtApi();

    // GET: Home
    public ActionResult Index()
    {

      List<User> allUsers = _apiData.GetAllUsers() ?? _data.GetAllUsers();
      List<Project> allProjects = _apiData.GetAllProjects() ?? _data.GetAllProjects();

      DashboardVM viewModel = new DashboardVM()
      {
        Projects = allProjects,
        Users = allUsers
      };
      return View(viewModel);
    }

    public ActionResult ProjectPage(int id)
    {
      Project project = _apiData.GetProject(id) ?? _data.GetProject(id);
      project.UsersOnProject = _data.GetUsersByProject(id);
      return View(project);
    }

    public ActionResult UserProfile(int userId)
    {
      User user = _apiData.GetUser(userId) ?? _data.GetUser(userId);
      user.Projects = _data.GetProjectsByUser(userId);
      user.TechTags = _data.GetTags();

      return View(user);
    }
  }
}