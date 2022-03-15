using Game_Data;
using Game_Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Catalogue.Businesss
{
    public class Game_Logic
    {
        private GameCatalogueContext catalogueContext = new GameCatalogueContext();

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<Game> GetAll()
        {
            using (catalogueContext = new GameCatalogueContext())
            {
                return catalogueContext.Games.ToList();
            }
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Game Get(int id)
        {
            using (catalogueContext = new GameCatalogueContext())
            {
                return catalogueContext.Games.Find(id);
            }
        }

        /// <summary>
        /// Adds the specified game.
        /// </summary>
        /// <param name="game">The game.</param>
        public void Add(Game game)
        {
            using (catalogueContext = new GameCatalogueContext())
            {
                catalogueContext.Games.Add(game);
                catalogueContext.SaveChanges();
            }
        }

        /// <summary>
        /// Updates the specified game.
        /// </summary>
        /// <param name="game">The game.</param>
        public void Update(Game game)
        {
            using (catalogueContext = new GameCatalogueContext())
            {
                var item = catalogueContext.Games.Find(game.IdGame);
                if (item != null)
                {
                    catalogueContext.Entry(item).CurrentValues.SetValues(game);
                    catalogueContext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            using (catalogueContext = new GameCatalogueContext())
            {
                var game = catalogueContext.Games.Find(id);
                if (game != null)
                {
                    catalogueContext.Games.Remove(game);
                    catalogueContext.SaveChanges();
                }
            }
        }

        public string GetGenre(int id)
        {
            using (catalogueContext = new GameCatalogueContext())
            {
                Genre genre = catalogueContext.Genres.Where(g => g.IdGenre == id).ToList().First();
                var name = genre.Name;
                return name;
            }
        }
    }
}
