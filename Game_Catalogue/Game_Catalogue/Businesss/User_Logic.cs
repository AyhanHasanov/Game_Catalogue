using Data;
using Data.Model;

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

        public User GetUserFromTxtFile()
        {
            using (context = new GameCatalogueContext())
            {
                using (var reader = new StreamReader("username.txt"))
                {
                    string username = reader.ReadToEnd().Trim().Replace("\\r", "").Replace("\\n", "");
                    return GetUserByUsername(username);
                }
            }
        }

        public bool CheckPassword(string username, string password)
        {
            using (context = new GameCatalogueContext())
            {
                User user = GetUserByUsername(username);
                if (user.Password != password)
                    throw new Exception();
                else return true;
            }
        }
    }
}
