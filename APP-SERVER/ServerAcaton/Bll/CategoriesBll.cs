using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
namespace Bll
{
    class CategoriesBll
    {
        static JhackthonEntities db = new JhackthonEntities();


        //        public static List<CategoriesEntities> getAllCategory()//שליפת כל הקטגוריות
        //        {

        //            return CategoriesEntities.ToListCategoryEntities(db.Categories.ToList());
        //        }

        //        public static List<CategoriesEntities> getRecipeByCategory(int CategoryCode)// שליפת מתכונים לפי קטגוריה
        //        {

        //            return CategoriesEntities.ToListCategoryEntities(db.RecipeProducts.Where(i => i.CategoryCode == CategoryCode).ToList());
        //        }


        //        public static CategoryEntities GetCategoryById(int CategoryCode)//החזרת קטגוריה לפי מזהה- מסוג האנטיטי
        //        {
        //            return CategoryEntities.ToCategoryEntities(db.Category.FirstOrDefault(i => i.CategoryCode == CategoryCode));
        //        }



        //        public static List<CategoryEntities> addCategory(Category category)//הוספת קטגוריה
        //        {

        //            db.Category.Add(category);
        //            db.SaveChanges();
        //            return getAllCategory();
        //        }


        //        public static void deleteCategory(int CategoryCode)//מחיקת קטגוריה מהטבלה לפי מזהה
        //        {
        //            db.Category.RemoveRange(db.Category.Where(i => i.CategoryCode == CategoryCode));
        //            db.SaveChanges();
        //            db.Category.Remove(db.Category.First(i => i.CategoryCode == CategoryCode));
        //            db.SaveChanges();
        //        }


        //        public static void UpdateCategory(CategoryEntities Category)//עדכון קטגוריה בטבלה
        //        {
        //            db.Category.First(i => i.CategoryCode == Category.CategoryCode).CategoryName = Category.CategoryName;
        //            db.SaveChanges();
        //        }



        //    }
        //}
    }
}
