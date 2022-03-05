using System;
using System.Collections.Generic;

namespace Game_Catalogue.Data.Model
{
    /// <summary>
    /// Class UsersGame
    /// </summary>
    public partial class UsersGame
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>
        /// The user id.
        /// </value>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the game id.
        /// </summary>
        /// <value>
        /// The game id.
        /// </value>
        public int GameId { get; set; }
        /// <summary>
        /// Gets or sets game information from class game.
        /// </summary>
        public virtual Game Game { get; set; } = null!;
        /// <summary>
        /// Gets or sets user information from class user.
        /// </summary>
        public virtual User User { get; set; } = null!;
    }
}
