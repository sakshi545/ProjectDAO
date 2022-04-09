using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAO
{
    public class ProjectDAL
    {
        Sprint_dbEntities1 entities = new Sprint_dbEntities1();

        public int AddProject(string Title)
        {
            int Projectlist = entities.procAddProject(Title);
            return Projectlist;
        }

        public procReadProject_Result SearchProject(int projectId)
        {
            procReadProject_Result result = entities.procReadProject(projectId).FirstOrDefault<procReadProject_Result>();
            return result;
        }
        public List<procReadAllProject_Result> ShowProject()
        {
            List<procReadAllProject_Result> projectList = entities.procReadAllProject().ToList<procReadAllProject_Result>();
            return projectList;
        }

        public int DeleteProject(int projectId)
        {

            int result = entities.procDeleteProject(projectId);
            return result;
        }

        public int updateProject(int ProjectId, string Title)
        {
            int result = entities.procupdateProject(ProjectId, Title);
            return result;
        }


    }
}



