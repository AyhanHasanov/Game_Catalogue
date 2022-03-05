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
        public int IdGame { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Gets or sets the opinion.
        /// </summary>
        public string? Opinion { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public string State { get; set; } = null!;
        /// <summary>
        /// Gets or sets the identifier genre.
        /// </summary>
        public int IdGenre { get; set; }
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        public byte[]? Image { get; set; }

        /// <summary>
        /// Gets or sets the identifier genre navigation.
        /// </summary>
        public virtual Genre IdGenreNavigation { get; set; } = null!;
    }
}
