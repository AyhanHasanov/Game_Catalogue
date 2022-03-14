namespace Game_Data.Model
{
    /// <summary>
    /// Class Game
    /// </summary>
    public partial class Game
    {
        private string name;

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
        public string Name
        {
            get { return name; }
            set
            {

                if (string.IsNullOrEmpty(value) || value.ToLower() == "name of game")
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }
                name = value; 
            } 
        } 

        /// <summary>
        /// Gets or sets the opinion.
        /// </summary>
        /// <value>
        /// The opinion.
        /// </value>
        public string Opinion { get; set; }

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
