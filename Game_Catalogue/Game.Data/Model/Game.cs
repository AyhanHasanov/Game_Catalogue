using System;
using System.Collections.Generic;

namespace Data.Model
{
    /// <summary>
    /// Class Game
    /// </summary>
    public partial class Game
    {
        /// <summary>
        /// Game constructor
        /// </summary>
        public Game()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        /// <summary>
        /// Sets ot gets the game's id
        /// </summary>
        public int IdGame { get; set; }

        /// <summary>
        /// Sets or gets the game's name
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Sets or gets the user's opinion/description of the game
        /// </summary>
        public string Opinion { get; set; } = null!;

        /// <summary>
        /// Sets or gets the state of the game 
        /// For example: Playing, Plan To Play, Played
        /// </summary>
        public string State { get; set; } = null!;

        /// <summary>
        /// Sets or gets the genre's id
        /// </summary>
        public int IdGenre { get; set; }

        /// <summary>
        /// Gets or sets the image
        /// </summary>
        public byte[]? Image { get; set; }

        /// <summary>
        /// Id Genre Navigation
        /// </summary>
        public virtual Genre IdGenreNavigation { get; set; } = null!;

        /// <summary>
        /// Collection of UsersGames
        /// </summary>
        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
