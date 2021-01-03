using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Entities
{
     public class CategoriesEntities
    {
        public string CategoryName { get; set; }
        public int Categorycode { get; set; }

        public static CategoriesEntities ToCategoryEntities(Categories c)
        {
            CategoriesEntities cnew = new CategoriesEntities() { CategoryName = c.CategoryName, Categorycode = c.Category_code };

            return cnew;
        }

        public static Categories ToCategoryTbl(CategoriesEntities c)
        {
            Categories cnew = new Categories() { CategoryName = c.CategoryName, Category_code = c.Categorycode };


            return cnew;
        }

        public static List<CategoriesEntities> ToListCategoryEntities(List<Categories> lc)
        {
            List<CategoriesEntities> lcnew = new List<CategoriesEntities>();
            lc.ForEach(c => lcnew.Add(ToCategoryEntities(c)));


            return lcnew;
        }

        public static List<Categories> ToListCategoryTBL(List<CategoriesEntities> lc)
        {
            List<Categories> lcnew = new List<Categories>();
            lc.ForEach(c => lcnew.Add(ToCategoryTbl(c)));
            return lcnew;
        }



    }
}

