using System;
using System.Collections.Generic;

namespace Game_Catalogue.Data.Model
{    
/// <summary>
/// 
/// </summary>
    public partial class Game
    {
        public int IdGame { get; set; }
        public string Name { get; set; } = null!;
        public string? Opinion { get; set; }
        public string State { get; set; } = null!;
        public int IdGenre { get; set; }
        public byte[]? Image { get; set; }

        public virtual Genre IdGenreNavigation { get; set; } = null!;
    }
}
