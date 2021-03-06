﻿using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using OpsDashboard.Models;

namespace OpsDashboard.Repo
{
  public class TenThousandFtApi : IData
  {

    public List<Project> GetAllProjects()
    {
      string results = MakeTenThousandFtApiRequest(BuildRequestUrl("projects?fields=tags"));

      var response = !string.IsNullOrEmpty(results) ? JsonConvert.DeserializeObject<List<Project>>(results) : null;

      return response;
    }

    public List<User> GetAllUsers()
    {
     string results = MakeTenThousandFtApiRequest(BuildRequestUrl("users?fields=tags,assignments"));

      var response = !string.IsNullOrEmpty(results) ? JsonConvert.DeserializeObject<List<User>>(results) : null;

      return response;
    }

    public User GetUser(int userId)
    {
      string results = MakeTenThousandFtApiRequest(BuildRequestUrl($"users/{userId}?fields=tags,assignments"));

      var response = !string.IsNullOrEmpty(results) ? JsonConvert.DeserializeObject<User>(results) : null;

      return response;
    }

    public Project GetProject(int projectId)
    {
      string results = MakeTenThousandFtApiRequest(BuildRequestUrl($"projects/{projectId}?fields=tags"));

      var response = !string.IsNullOrEmpty(results) ? JsonConvert.DeserializeObject<Project>(results) : null;

      return response;
    }

    public List<Project> GetProjectsByUser(int id)
    {
      throw new NotImplementedException();
    }

    public List<User> GetUsersByProject(int id)
    {
      throw new NotImplementedException();
    }

    public List<string> GetTags()
    {
      throw new NotImplementedException();
    }

    public List<Certification> GetCertifications()
    {
      throw new NotImplementedException();
    }
    
    private string MakeTenThousandFtApiRequest(string requestUrl)
    {
      string result = string.Empty;

      var request = WebRequest.Create(requestUrl) as HttpWebRequest;

      if (request != null)
      {
        request.Method = "GET";

        try
        {
          var response = request.GetResponse() as HttpWebResponse;

          if (response != null)
          {
            using (var responseStream = response.GetResponseStream())
            {
              if (responseStream != null)
              {
                using (var sr = new StreamReader(responseStream))
                {
                  result = sr.ReadToEnd();
                }
              }
            }
          }
        }
        catch (Exception ex)
        {

        }
      }

      return result;
    }
    
    public string BuildRequestUrl(string endpointAddress)
    {
      return Constants.TenThousandFtApiUrl + endpointAddress + Constants.TenThousandFtApiToken;
    }
  }
}