using System;
using System.Collections.Generic;

namespace Game_Catalogue.Data.Model
{    
/// <summary>
/// Class Game
/// </summary>
    public partial class Game
    {
        /// <summary>
        /// Gets or sets the identifier game.
        /// </summary>
        /// <value>
        /// The identifier game.
        /// </value>
        public int IdGame { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Gets or sets the opinion.
        /// </summary>
        /// <value>
        /// The opinion.
        /// </value>
        public string? Opinion { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; } = null!;
        /// <summary>
        /// Gets or sets the identifier genre.
        /// </summary>
        /// <value>
        /// The identifier genre.
        /// </value>
        public int IdGenre { get; set; }
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public byte[]? Image { get; set; }

        /// <summary>
        /// Gets or sets the identifier genre navigation.
        /// </summary>
        /// <value>
        /// The identifier genre navigation.
        /// </value>
        public virtual Genre IdGenreNavigation { get; set; } = null!;
    }
}
