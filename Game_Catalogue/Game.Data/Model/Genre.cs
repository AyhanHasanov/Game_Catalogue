namespace Game_Data.Model
{
    /// <summary>
    /// class Genre
    /// </summary>
    public partial class Genre
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Genre"/> class.
        /// </summary>
        public Genre()
        {
            Games = new HashSet<Game>();
        }

        /// <summary>
        /// Gets or sets the identifier genre.
        /// </summary>
        /// <value>
        /// The identifier genre.
        /// </value>
        public int IdGenre { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = null!;


        /// <summary>
        /// Gets or sets the collection of games.
        /// </summary>
        /// <value>
        /// The games.
        /// </value>
        public virtual ICollection<Game> Games { get; set; }
    }
}

