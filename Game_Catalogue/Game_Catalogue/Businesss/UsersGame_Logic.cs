using Game_Data;
using Game_Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Catalogue.Business
{
    public class UsersGame_Logic
    {
        GameCatalogueContext context;
        /*public void Add(int userId, int gameId)
        {
            if (userId <= 0 && gameId <= 0)
                using (context = new GameCatalogueContext())
                {
                    UsersGame userGame = new UsersGame();
                    userGame.UserId = userId;
                    userGame.GameId = gameId;

                    context.UsersGames.Add(userGame);
                    context.SaveChanges();
                }
        }*/
        public void Add(UsersGame ug)
        {
            using (context = new GameCatalogueContext())
            {
                context.Add(ug);
                context.SaveChanges();
            }
        }

    }
}
