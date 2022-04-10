using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity.Core.Objects;
using System.Text;
using ProjectDAO;
using System.Net.Http;

namespace ProjectApi.Controllers
{
    public class HomeController : ApiController

    {
        private Sprint_dbEntities1 db = new Sprint_dbEntities1();

        [HttpGet]
        [Route("api/Home/ShowProjectSp")]

        public IQueryable<procReadAllProject_Result> ShowProjectSp()
        {
            ProjectDAL dal = new ProjectDAL();
            List<procReadAllProject_Result> projectList = dal.ShowProject();
            IQueryable<procReadAllProject_Result> result = projectList.AsQueryable();
            return result;
        }

        [HttpGet]
        [Route("api/Home/SearchprojectSp/{ProjectId}")]
        [ResponseType(typeof(Project))]
        public IHttpActionResult SearchProjectPoject(int ProjectId)
        {
            ProjectDAL dal = new ProjectDAL();
            procReadProject_Result projectresult = dal.SearchProject(ProjectId);
            if (projectresult == null)
            {
                return NotFound();

            }

            return Ok(projectresult);

        }

        [HttpPost]
        [Route("api/Home/AddProject/{title}")]
        [ResponseType(typeof(Project))]
        public IHttpActionResult AddProject(string title)
        {
            ProjectDAL dal = new ProjectDAL();
            Project project = new Project();
            project.Title = title;
            dal.AddProject(title);
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Project Inserted", Encoding.UTF8, "application/json");
            return ResponseMessage(response);

        }

        [HttpGet]
        [Route("api/Home/DeleteProjectSp/{projectId}")]
        [ResponseType(typeof(Project))]

        public IHttpActionResult DeleteProjectSp(int projectId)
        {
            ProjectDAL dal = new ProjectDAL();
            procReadProject_Result project = dal.SearchProject(projectId);
            if (project == null)
            {
                return NotFound();

            }
            dal.DeleteProject(projectId);

            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Project Deleted", Encoding.UTF8, "application/json");
            return ResponseMessage(response);
        }

        [HttpPut]
        [Route("api/Home/UpdateProjectSp/{projectId},{Title}")]
        [ResponseType(typeof(Project))]

        public IHttpActionResult UpdateProjectSp(int projectId, string Title)
        {
            ProjectDAL dal = new ProjectDAL();
            procReadProject_Result project = dal.SearchProject(projectId);
            if (project == null)
            {
                return NotFound();

            }
            dal.updateProject(projectId, Title);


            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Project Updated Succesfullyy...", Encoding.UTF8, "application/json");
            return ResponseMessage(response);


        }

        [HttpGet]
        [Route("api/Home/AssignProject/{empid},{projectid}")]
        [ResponseType(typeof(Employee))]

        public IHttpActionResult AssignProject(int empid, int projectid)
        {
            Sprint_dbEntities1 db = new Sprint_dbEntities1();
            ProjectDAL dao = new ProjectDAL();
            Employee emp = db.Employees.Find(empid);
            Project prj = db.Projects.Find(projectid);
            if (emp == null || prj == null)
            {
                return NotFound();
            }
            dao.AssignProject(empid, projectid);
            var response = this.Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Project Assigned ....", Encoding.UTF8, "application/json");
            return ResponseMessage(response);
        }

    }
}

