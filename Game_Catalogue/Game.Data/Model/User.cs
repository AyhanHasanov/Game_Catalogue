using System;
using System.Collections.Generic;

namespace Data.Model
{
    /// <summary>
    /// Class User
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// User constructor
        /// </summary>
        public User()
        {
            UsersGames = new HashSet<UsersGame>();
        }

        private string email;
        private string username;
        private string password;

        /// <summary>
        /// Gets or sets the user's id
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Gets or sets the user's email
        /// </summary>
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

        /// <summary>
        /// Gets or sets the user's username
        /// </summary>
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

        /// <summary>
        /// Gets or sets the user's password
        /// </summary>
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

        /// <summary>
        /// Gets or sets the date and time when the user's account was created
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Collection UsersGames
        /// </summary>
        public virtual ICollection<UsersGame> UsersGames { get; set; }
    }
}
