﻿using System;
using System.Collections.Generic;

namespace Game_Catalogue.Data.Model
{
    public partial class UsersGame
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        public virtual Game Game { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
