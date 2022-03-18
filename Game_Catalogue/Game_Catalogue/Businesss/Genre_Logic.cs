using Data;
using Data.Model;

namespace Game_Catalogue.Business
{
    /// <summary>
    /// Class Genre_Logic
    /// </summary>
    public class Genre_Logic
    {
        GameCatalogueContext context;

        /// <summary>
        /// Adds the genre
        /// </summary>
        /// <param name="genre"></param>
        public void Add(Genre genre)
        {
            using (context = new GameCatalogueContext())
            {
                context.Add(genre);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets the count of genres
        /// </summary>
        /// <returns>The count</returns>
        public int GetCount()
        {
            using (context = new GameCatalogueContext())
                return context.Genres.Count();
        }

        /// <summary>
        /// Gets the genre
        /// </summary>
        /// <param name="id">Genre's id</param>
        /// <returns>The genre</returns>
        public Genre GetGenre(int id)
        {
            using (context = new GameCatalogueContext())
            {
                var result = context.Genres.Where(g => g.IdGenre == id).FirstOrDefault();
                return result;
            }
        }

        /// <summary>
        /// Gets the genre's id by it's name
        /// </summary>
        /// <param name="genreName">The genre name</param>
        /// <returns>The genre's id</returns>
        public int GetGenreIdByName(string genreName)
        {
            using (context = new GameCatalogueContext())
            {
                var genre = context.Genres.ToList().Where(g => g.GenreName.Equals(genreName)).FirstOrDefault();
                if (genre != null)
                    return genre.IdGenre;

                return -1;
            }
        }
    }
}
