using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    class UsersBll
    {
         static JhackthonUsersEntities DB = new JhackthonUsersEntities();
       
        //get all users

    public static List<UsersEntities> GetAllUsersList()

    {

        List<Users> lu = DB.Users.ToList();

        return UsersEntities.convertListUsersTblToListUsersEntities(lu);

    }

    

    //function singIn get name and password and return 0 when he didn't find and 1 when he find user

           public static int login(string name, string password)

    {

        if (DB.Users.Where(x => x.Name == name && x.Pssword == password).First() != null)

            return 1;

        return 0;

    }



    //add user 

    public static void addUser(UsersEntities user, Car_DetailsEntities car)

    {

        if (user != null)

        {
            Users newUser = UsersEntities.convertUserEntitiesToUserTbl(user);
           // Car_Details newCar = Car_DetailsEntities.convertCarDetailsEntitiestoCarDetailsTbl(car);
            DB.Users.Add(newUser);
           // DB.Car_Details.Add(newCar);
        
        }

    }



    //function that check if user is exists

    public static Boolean ExistUser(UsersEntities user)

    {

        Users u = UsersEntities.convertUserEntitiesToUserTbl(user);

        if (DB.Users.Any(x => x.Mail == u.Mail)) //when exists user

            return false;

        return true;

      }
    }
}
