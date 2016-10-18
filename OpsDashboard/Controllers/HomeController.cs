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
     IData _testData = new TestData();

    // GET: Home
    public ActionResult Index()
      {
        DashboardVM viewModel = new DashboardVM()
        {
          Projects = _testData.GetAllProjects(),
          Users = _testData.GetAllUsers()
        };
            return View(viewModel);
   }

    public ActionResult ProjectPage(int id)
    {
      Project project = _testData.GetProject(id);
      return View(project);
    }

      public ActionResult UserProfile(int userId)
      {
        User user = _testData.GetUser(userId);
        user.Projects = _testData.GetProjectsByUser(userId);
        user.TechTags = _testData.GetTags();

      return View(user);
      }
    }
  }