using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    class ProjectBll
    {
         static JhackthonProjectEntities DB = new JhackthonProjectEntities();

       
             public static List<ProjectEntities> getAllProjects()//שליפת כל הפרוייקטים
               {

                    return ProjectEntities.ToListProjectEntities(DB.Project.ToList());
               }

    }
}
