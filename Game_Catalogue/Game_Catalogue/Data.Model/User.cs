using System;
using System.Collections.Generic;

namespace Game_Catalogue.Data.Model
{
    /// <summary>
    /// Class User
    /// </summary>
    public partial class User
    {
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
        public string Email { get; set; } = null!;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date the account is created at.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime? CreatedAt { get; set; }
    }
}
