using Data;
using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Game_Catalogue.Business
{
    /// <summary>
    /// Class UsersGame_Logic
    /// </summary>
    public class UsersGame_Logic
    {
        GameCatalogueContext context;

        /// <summary>
        /// Adds
        /// </summary>
        /// <param name="ug"></param>
        public void Add(UsersGame ug)
        {
            using (context = new GameCatalogueContext())
            {
                context.Add(ug);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<UsersGame> GetAll()
        {
            using (context = new GameCatalogueContext())
            {
                return context.UsersGames.ToList();
            }
        }

        /// <summary>
        /// Gets all the current user's games
        /// </summary>
        /// <param name="user">The user</param>
        /// <returns>A list of all games</returns>
        public List<UsersGame> GetAllGamesForCurrentUser(User user)
        {
            using (context = new GameCatalogueContext())
            {
                var result = context.UsersGames.Where(u => u.UserId.Equals(user.Id)).ToList();
                return result;
            }
        }

        /// <summary>
        /// Deletes a game from user's list
        /// </summary>
        /// <param name="userId">The user id</param>
        /// <param name="gameId">The game id</param>
        /// <exception cref="ArgumentException">Game does not exist</exception>
        public void Delete(int userId, int gameId)
        {
            using (context = new GameCatalogueContext())
            {
                var usersGame = context.UsersGames.FirstOrDefault((ug => (ug.UserId == userId) && (ug.GameId == gameId)));
                var game = context.Games.FirstOrDefault((g => (g.IdGame == gameId)));
                if (usersGame == null)
                {
                    throw new ArgumentException("Game does not exist!");
                }
                else
                {
                    context.UsersGames.Remove(usersGame);
                    context.Games.Remove(game);
                    context.SaveChanges();
                }
            }
        }

    }
}
