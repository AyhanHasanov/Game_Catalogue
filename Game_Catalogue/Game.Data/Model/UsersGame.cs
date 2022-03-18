using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Model
{
    /// <summary>
    /// Class UsersGame
    /// </summary>
    public partial class UsersGame
    {
        /// <summary>
        /// Gets or sets the id of the table
        /// Primary key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user's id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the game's id
        /// </summary>
        public int GameId { get; set; }

        public virtual Game Game { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
