using System;
using System.Collections.Generic;

namespace Game_Catalogue.Data.Model
{
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
    }
}
