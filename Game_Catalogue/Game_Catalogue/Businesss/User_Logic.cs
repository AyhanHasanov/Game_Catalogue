using Data;
using Data.Model;

namespace Game_Catalogue.Business
{
    /// <summary>
    /// Class User_Logic
    /// </summary>
    public class User_Logic
    {
        GameCatalogueContext context;
        User user;

        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="user">The user</param>
        public void CreateNewUser(User user)
        {
            using (context = new GameCatalogueContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Check if the user exists in the database
        /// </summary>
        /// <param name="email">The email</param>
        /// <returns>True or false</returns>
        public bool CheckIfUserExists(string email)
        {
            using (context = new GameCatalogueContext())
            {
                return context.Users.Any(u => u.Email == email);
            }
        }

        /// <summary>
        /// Gets the user by username
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns>The user</returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Gets the user from a .txt file
        /// </summary>
        /// <returns>The user</returns>
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

        /// <summary>
        /// Checks if the password is correct
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        /// <returns>True or false</returns>
        /// <exception cref="Exception"></exception>
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
