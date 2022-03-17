using System;
using System.Collections.Generic;

namespace Data.Model
{
    public partial class User
    {
        public User()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        public int Id { get; set; }

        public string Email { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
