﻿using Game_Data;
using Game_Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Catalogue.Business
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

        /// <summary>
        /// Gets the count of genres
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            using(context = new GameCatalogueContext())
                return context.Genres.Count();
        }

        public Genre GetGenre(int id)
        {
            using(context = new GameCatalogueContext())
            {
                var result = context.Genres.Where(g=> g.IdGenre == id).FirstOrDefault();
                return result;
            }
        }
    }
}
