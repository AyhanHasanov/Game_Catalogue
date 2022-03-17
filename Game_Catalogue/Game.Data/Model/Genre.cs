using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class Genre
    {
        public Genre()
        {
            Games = new HashSet<Game>();
        }

        public int IdGenre { get; set; }

        public string GenreName { get; set; } = null!;

        public virtual ICollection<Game> Games { get; set; }
    }
}
