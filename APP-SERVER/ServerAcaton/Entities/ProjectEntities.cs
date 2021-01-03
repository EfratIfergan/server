using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Entities
{
    public class ProjectEntities
    {
        
            public int? CategoryCode { get; set; }
            public string ProjectName { get; set; }
            public string ProjectStatus { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public int? NumberOfParticipants { get; set; }
            public string ProjectDescription { get; set; }
            public int ProjectCode { get; set; }

            public static ProjectEntities ToProjectEntities(Project c)
            {
                ProjectEntities cnew = new ProjectEntities() { CategoryCode = c.CategoryCode, ProjectName = c.ProjectName, ProjectStatus = c.ProjectStatus, StartDate = c.StartDate, EndDate = c.EndDate, NumberOfParticipants = c.NumberOfParticipants, ProjectDescription = c.ProjectDescription, ProjectCode = c.ProjectCode };

                return cnew;
            }

            public static Project ToProjectTbl(ProjectEntities c)
            {
                Project cnew = new Project() { CategoryCode = c.CategoryCode, ProjectName = c.ProjectName, ProjectStatus = c.ProjectStatus, StartDate = c.StartDate, EndDate = c.EndDate, NumberOfParticipants = c.NumberOfParticipants, ProjectDescription = c.ProjectDescription, ProjectCode = c.ProjectCode };


                return cnew;
            }

            public static List<ProjectEntities> ToListProjectEntities(List<Project> lc)
            {
                List<ProjectEntities> lcnew = new List<ProjectEntities>();
                lc.ForEach(c => lcnew.Add(ToProjectEntities(c)));


                return lcnew;
            }

            public static List<Project> ToListProjectTBL(List<ProjectEntities> lc)
            {
                List<Project> lcnew = new List<Project>();
                lc.ForEach(c => lcnew.Add(ToProjectTbl(c)));
                return lcnew;
            }



        }
    
}
