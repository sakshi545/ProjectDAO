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
using System.Threading.Tasks;
using ProjectMVC.Models;

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

        public async Task<ActionResult> Create(Project project)
        {
            var client = new HttpClient();
            string url = $"https://localhost:44372/api/Home/AddProject/" + project.Title;

            var response = client.PostAsync(url, null);
            response.Wait();


           
                TempData["error"] = false;
                TempData["message"] = "Project created";
            
            return RedirectToAction("ShowProject");
        }
        public ActionResult Create()
        {
            return View();
        }

        //Delete Project
        
        public ActionResult DeleteView()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> DeleteView(Project project)
        {
            var client = new HttpClient();
            string url = $"https://localhost:44372/api/Home/DeleteProjectSp/{project.ProjectId}";
            TempData["id"] = project.ProjectId;
            var response = await client.GetAsync(url);
            

            if (((int)response.StatusCode)==200)
            {
                TempData["error"] = false;
                TempData["message"] = "Project deleted";
            }
            else
            {
                TempData["error"] = true;
                TempData["message"] = "Project not deleted";
            }
            
            return Redirect("ShowProject");
        }

        
            
        
         
        //Update Project
        [HttpPost]
        public async Task<ActionResult> UpdateProject(int projectId,string Title)
        {
           
            var client = new HttpClient();
            string url = $"https://localhost:44372/api/Home/UpdateProjectSp/"+projectId+","+Title;
            var response = await client.PutAsync(url,null);
           
            if (((int)response.StatusCode) == 200)
            {
                TempData["error"] = false;
                TempData["message"] = "Project Updated Successfully";
            }
            else
            {
                TempData["error"] = true;
                TempData["message"] = "Project not updated";
            }
            return RedirectToAction("ShowProject");
        }
        public ActionResult UpdateView()
        {
            return View();
        }

        //Assign Project
        [HttpPost]
        public async Task<ActionResult> AssignProject(int empid,int pid)
        {
            var client = new HttpClient();
            string url = $"https://localhost:44372/api/Home/AssignProject/"+empid+","+pid;           

            var response = await client.GetAsync(url);
            if (((int)response.StatusCode) == 200)
            {
                TempData["error"] = false;
                TempData["message"] = "Project Assigned ";
            }
            else
            {
                TempData["error"] = true;
                TempData["message"] = "Employee or Project Not Found";
            }

            return RedirectToAction("ShowProject");

        }
        public ActionResult Assign()
        {
            return View();
        }



    }

}