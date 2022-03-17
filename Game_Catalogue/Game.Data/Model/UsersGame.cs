using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Game_Data.Model
{
    public partial class UsersGame
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int GameId { get; set; }

        public virtual Game Game { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
