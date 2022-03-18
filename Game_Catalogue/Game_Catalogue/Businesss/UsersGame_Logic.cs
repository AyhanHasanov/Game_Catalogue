using Data;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Game_Catalogue.Business
{
    public class UsersGame_Logic
    {
        GameCatalogueContext context;
        
        public void Add(UsersGame ug)
        {
            using (context = new GameCatalogueContext())
            {
                context.Add(ug);
                context.SaveChanges();
            }
        }

        public List<UsersGame> GetAll()
        {
            using (context = new GameCatalogueContext())
            {
                return context.UsersGames.ToList();
            }
        }

        public List<UsersGame> GetAllGamesForCurrentUser(User user)
        {
            using (context = new GameCatalogueContext())
            {
                var result = context.UsersGames.Where(u => u.UserId.Equals(user.Id)).ToList();
                return result;
            }
        }
        public void Delete(int userId, int gameId)
        {
            using (context = new GameCatalogueContext())
            {
                var usersGame = context.UsersGames.FirstOrDefault((ug => (ug.UserId == userId) && (ug.GameId == gameId)));
                if (usersGame == null)
                {
                    throw new ArgumentException("Game does not exist!");
                }
                else
                {
                    context.UsersGames.Remove(usersGame);
                    context.SaveChanges();
                }
            }
        }

    }
}
