using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace Entities
{
     public class EntrepreneursEntities
    {
        //public   Image { get; set; }
        public string CompanyName { get; set; }
        public string Miles { get; set; }


        public static EntrepreneursEntities ToIdEntrepreneurEntities(Entrepreneurs c)
        {
            EntrepreneursEntities cnew = new EntrepreneursEntities() { /*Image = c.Image*/ CompanyName = c.CompanyName, Miles = c.Miles };

            return cnew;
        }

        public static Entrepreneurs ToIdEntrepreneurTbl(EntrepreneursEntities c)
        {
            Entrepreneurs cnew = new Entrepreneurs() { /*Image = c.Image*/ CompanyName = c.CompanyName, Miles = c.Miles };


            return cnew;
        }

        public static List<EntrepreneursEntities> ToListEntrepreneursEntities(List<Entrepreneurs> lc)
        {
            List<EntrepreneursEntities> lcnew = new List<EntrepreneursEntities>();
            lc.ForEach(c => lcnew.Add(ToIdEntrepreneurEntities(c)));


            return lcnew;
        }

        public static List<Entrepreneurs> ToListIdEntrepreneurTBL(List<EntrepreneursEntities> lc)
        {
            List<Entrepreneurs> lcnew = new List<Entrepreneurs>();
            lc.ForEach(c => lcnew.Add(ToIdEntrepreneurTbl(c)));
            return lcnew;
        }



    }
}


    

