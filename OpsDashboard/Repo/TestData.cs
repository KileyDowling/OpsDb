﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OpsDashboard.Models;

namespace OpsDashboard.Repo
{
  public class TestData : IData
  {
    public List<User> GetAllUsers()
    {
      List<User> users = new List<User>();

      User user1 = new User()
      {
        FirstName = "John",
        LastName = "Doe",
        Email = "jdoe@site.com",
        Title = "Developer",
        EmployeeId = 121212,
        Certifications = GetCertifications(),
      };

      User user2 = new User()
      {
        FirstName = "Jane",
        LastName = "Doeth",
        Email = "jdoath@site.com",
        Title = "Developer",
        EmployeeId = 45454545,
        Certifications = GetCertifications(),
      };

      users.Add(user1);
      users.Add(user2);

      return users;
    }

    public List<Project> GetAllProjects()
    {
      List<Project> projects = new List<Project>();

      var project1 = new Project()
      {
        Name = "Travel Canada",
        ProjectId = 1234,
        Tags = GetTags(),
      };

      var project2 = new Project()
      {
        Name = "Hospital Five",
        ProjectId = 5679,
        Tags = GetTags(),
      };

      projects.Add(project1);
      projects.Add(project2);

      return projects;
      }

    public List<Project> GetProjectsByUser(int id)
    {
      return GetAllProjects();
      }

    public List<Certification> GetCertifications()
    {
     List<Certification> certifications = new List<Certification>();

      Certification cert1 = new Certification()
      {
        Vendor = "Microsoft",
        Name = "Programming",
        DateAchieved = new DateTime(2012,07,25),
        Description = "This shows you know something about programming"
      };

      certifications.Add(cert1);

      return certifications;
    }

    public List<string> GetTags()
    {
      List<string> tags = new List<string> {"ASP.NET MVC", "Sitecore", "JavaScript", "Lucene"};
      
      return tags;
    }

    public Project GetProject(int id)
    {
      Project project = GetAllProjects().FirstOrDefault(x=>x.ProjectId==id);
      return project;
      }

    public User GetUser(int userId)
    {
      User user = GetAllUsers().FirstOrDefault(x => x.EmployeeId == userId);
      return user;
    }
  }
}