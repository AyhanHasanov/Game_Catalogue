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

        private string email;
        private string username;
        private string password;

        public int Id { get; set; }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.ToLower() == "email address" || value.ToCharArray().Any(ch => ch.Equals("@")))
                    throw new ArgumentException("Invalid email address!");
                email = value;
            }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.ToLower() == "username")
                    throw new ArgumentException("Invalid username!");

                username = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 6)
                    throw new ArgumentException("Invalid password! Use at least 6 characters!");

                if (!value.ToCharArray().Any(char.IsDigit) || !value.ToCharArray().Any(char.IsLower) || !value.ToCharArray().Any(char.IsUpper))
                    throw new ArgumentException("Invalid password! Use digits, uppercase and lowercase letters!");
                
                password = value;
            }
        }

        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
