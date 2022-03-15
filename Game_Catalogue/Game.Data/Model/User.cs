using System;
using System.Collections.Generic;

namespace Game_Data.Model
{
    /// <summary>
    /// Class User
    /// </summary>
    public partial class User
    {
        private string name;
        private string email;
        private string password;

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.ToLower().Equals("email address"))
                    throw new ArgumentException("Invalid email address!");
                email = value;
            }
        }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.ToLower().Equals("username"))
                    throw new ArgumentException("Invalid username!");

                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.ToLower().Equals("password"))
                    throw new ArgumentException("Invalid password!");
                password = value;
            }
        }

        /// <summary>
        /// Gets or sets the date the account is created at.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime? CreatedAt { get; set; }
    }
}
