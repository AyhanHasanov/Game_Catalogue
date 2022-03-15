using Game_Data;
using Game_Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Catalogue.Business
{
    public class User_Logic
    {
        GameCatalogueContext context;
        User user;

        public void CreateNewUser(User user)
        {
            using (context = new GameCatalogueContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public bool CheckIfUserExists(string email)
        {
            using (context = new GameCatalogueContext())
            {
                return context.Users.Any(u => u.Email == email);
            }
        }

        public User GetUserByUsername(string username)
        {
            using (context = new GameCatalogueContext())
            {
                var targerUser = context.Users.Where(u => u.Username == username).ToList().First();

                if (targerUser == null)
                    throw new Exception();
                else
                    return targerUser;
            }
        }
    }
}
