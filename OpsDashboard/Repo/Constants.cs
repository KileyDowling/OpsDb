using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpsDashboard.Repo
{
  public static class Constants
  {

    /*API: GET  /api/v1/users/<user_id>
    curl 'https://vnext.10000ft.com/api/v1/users/12345?fields=tags,assignments&auth=...' 
    
       GET  /api/v1/users
 curl 'https://vnext.10000ft.com/api/v1/users?fields=tags,assignments&auth=...'*/

    public static readonly string TenThousandFtApiUrl = "https://api.10000ft.com/api/v1";

    public static readonly string TenThousandFtApiToken = "&auth=";

  }
}