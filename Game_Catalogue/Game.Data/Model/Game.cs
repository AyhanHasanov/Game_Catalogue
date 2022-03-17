using System;
using System.Collections.Generic;

namespace Game_Data.Model
{
    public partial class Game
    {
        public Game()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        public int IdGame { get; set; }

        public string Name { get; set; } = null!;

        public string Opinion { get; set; } = null!;

        public string State { get; set; } = null!;

        public int IdGenre { get; set; }

        public byte[]? Image { get; set; }

        public virtual Genre IdGenreNavigation { get; set; } = null!;
        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
