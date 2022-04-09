using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using ProjectDAO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Data;
using ProjectMVC.UtilFunctions;

namespace ProjectMVC.Controllers
{
    public class ProjectController : Controller
    {
        public ActionResult Index()
        {
            UtilityFunctions utils = new UtilityFunctions();
            if (utils.isLoggedIn(Request))
            {
                return View();
            }
            return Redirect("/Login/Login");

        }

         // GETAll : Project
        public ActionResult ShowProject()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            string json = (new WebClient()).DownloadString("https://localhost:44372/api/Home/ShowProjectSp");
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(json);
            List<Project> ProejctList = new List<Project>();
            Project project = null;

            foreach (DataRow dr in dt.Rows)
            {
                project = new Project();
                project.ProjectId = Convert.ToInt32(dr["ProjectId"]);
                project.Title = dr["Title"].ToString();
                project.Status = Convert.ToBoolean(dr["Status"]);
                ProejctList.Add(project);
            }
            return View(ProejctList);
        }

        //Add :Project

        
        [HttpPost]

        public ActionResult Create(Project project)
        {
            var client = new HttpClient();
            string url = "https://localhost:44372/api/Home/AddProject/" + project.Title;

            var response = client.PostAsync(url, null);
            return RedirectToAction("ShowProject");

        }
        public ActionResult Create()
        {
            return View();
        }

    }
}