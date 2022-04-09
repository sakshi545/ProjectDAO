using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.UtilFunctions
{
    public class UtilityFunctions
    {
        public bool isLoggedIn(HttpRequestBase requestBase)
        {
            if (requestBase.Cookies.AllKeys.Contains("user"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}