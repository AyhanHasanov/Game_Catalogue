using Game_Data;
using Game_Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Catalogue.Businesss
{
    public class Genre_Logic
    {
        GameCatalogueContext context;

        public void Add(Genre genre)
        {
            using (context = new GameCatalogueContext())
            {
                context.Add(genre);
                context.SaveChanges();
            }
        }
        public int GetCount()
        {
            using(context = new GameCatalogueContext())
                return context.Genres.Count();
        }
    }
}
