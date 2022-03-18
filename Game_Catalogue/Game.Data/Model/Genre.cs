using System;
using System.Collections.Generic;

namespace Data.Model
{
    /// <summary>
    /// Class Genre
    /// </summary>
    public partial class Genre
    {
        /// <summary>
        /// Genre constructor
        /// </summary>
        public Genre()
        {
            Games = new HashSet<Game>();
        }

        /// <summary>
        /// Gets or sets the genre's id
        /// </summary>
        public int IdGenre { get; set; }

        /// <summary>
        /// Gets or sets the genre's name
        /// </summary>
        public string GenreName { get; set; } = null!;

        /// <summary>
        /// A collection of the games
        /// </summary>
        public virtual ICollection<Game> Games { get; set; }
    }
}
