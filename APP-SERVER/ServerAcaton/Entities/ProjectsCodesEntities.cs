using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Entities
{
     public class ProjectsCodesEntities
    {
        public int? ProjectCose { get; set; }
        public string Miles { get; set; }
        public int AutomaticCode { get; set; }

        public static ProjectsCodesEntities ToProjectsCodesEntities(ProjectsCodes c)
        {
            ProjectsCodesEntities cnew = new ProjectsCodesEntities() { ProjectCose = c.ProjectCose, Miles = c.Miles, AutomaticCode = c.AutomaticCode };

            return cnew;
        }

        public static ProjectsCodes ToProjectsCodesTbl(ProjectsCodesEntities c)
        {
            ProjectsCodes cnew = new ProjectsCodes() { ProjectCose = c.ProjectCose, Miles = c.Miles, AutomaticCode = c.AutomaticCode };


            return cnew;
        }

        public static List<ProjectsCodesEntities> ToListProjectsCodesEntities(List<ProjectsCodes> lc)
        {
            List<ProjectsCodesEntities> lcnew = new List<ProjectsCodesEntities>();
            lc.ForEach(c => lcnew.Add(ToProjectsCodesEntities(c)));


            return lcnew;
        }

        public static List<ProjectsCodes> ToListProjectsCodesTBL(List<ProjectsCodesEntities> lc)
        {
            List<ProjectsCodes> lcnew = new List<ProjectsCodes>();
            lc.ForEach(c => lcnew.Add(ToProjectsCodesTbl(c)));
            return lcnew;
        }
    }
}
