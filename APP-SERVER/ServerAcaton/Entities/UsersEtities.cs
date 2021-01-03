using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Entities
{
   public class UsersEtities
    {
        public string Miles { get; set; }
        public int? Password { get; set; }
        public string ListOfProjectThatIWas { get; set; }
        public int? IdEntrepreneur { get; set; }
        public string Name { get; set; }

        public static UsersEtities ToUsersEntities(Users c)
        {
            UsersEtities cnew = new UsersEtities() { Miles = c.Miles, Password = c.Password, ListOfProjectThatIWas = c.ListOfProjectThatIWas, IdEntrepreneur = c.IdEntrepreneur, Name = c.Name };

            return cnew;
        }

        public static Users ToUsersTbl(UsersEtities c)
        {
            Users cnew = new Users() { Miles = c.Miles, Password = c.Password, ListOfProjectThatIWas = c.ListOfProjectThatIWas, IdEntrepreneur = c.IdEntrepreneur, Name = c.Name };


            return cnew;
        }

        public static List<UsersEtities> ToListUsersEntities(List<Users> lc)
        {
            List<UsersEtities> lcnew = new List<UsersEtities>();
            lc.ForEach(c => lcnew.Add(ToUsersEntities(c)));


            return lcnew;
        }

        public static List<Users> ToListUsersTBL(List<UsersEtities> lc)
        {
            List<Users> lcnew = new List<Users>();
            lc.ForEach(c => lcnew.Add(ToUsersTbl(c)));
            return lcnew;
        }



    }
}

