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

    // GET: Home
    public ActionResult Index()
      {
        DashboardVM viewModel = new DashboardVM()
        {
          Projects = _data.GetAllProjects(),
          Users = _data.GetAllUsers()
        };
            return View(viewModel);
   }

    public ActionResult ProjectPage(int id)
    {
      Project project = _data.GetProject(id);
      project.UsersOnProject = _data.GetUsersByProject(id);
      return View(project);
    }

      public ActionResult UserProfile(int userId)
      {
        User user = _data.GetUser(userId);
        user.Projects = _data.GetProjectsByUser(userId);
        user.TechTags = _data.GetTags();

      return View(user);
      }
    }
  }