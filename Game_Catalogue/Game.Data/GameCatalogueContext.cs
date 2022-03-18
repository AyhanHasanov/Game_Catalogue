using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    /// <summary>
    /// Class GameCaralogueContext
    /// </summary>
    public partial class GameCatalogueContext : DbContext
    {
        /// <summary>
        /// GameCatalogueContext constructor
        /// </summary>
        public GameCatalogueContext()
        {
            // Ensures the creation of the database
            Database.EnsureCreated();
        }

        /// <summary>
        /// GameCatalogueContext constructor
        /// </summary>
        public GameCatalogueContext(DbContextOptions<GameCatalogueContext> options)
            : base(options)
        {
            // Ensures the creation of the database
            Database.EnsureCreated();
        }

        /// <summary>
        /// Games table
        /// </summary>
        public virtual DbSet<Game> Games { get; set; } = null!;

        /// <summary>
        /// Genres table
        /// </summary>
        public virtual DbSet<Genre> Genres { get; set; } = null!;

        /// <summary>
        /// Users table
        /// </summary>
        public virtual DbSet<User> Users { get; set; } = null!;

        /// <summary>
        /// UsersGames table
        /// </summary>
        public virtual DbSet<UsersGame> UsersGames { get; set; } = null!;

        /// <summary>
        /// Configuring Sql Server connection string
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GameCatalogue;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.IdGame)
                    .HasName("pk_games_id");

                entity.HasIndex(e => e.IdGenre).HasName("IX_Games_id_genre");

                entity.Property(e => e.IdGame).HasColumnName("id_game");

                entity.Property(e => e.IdGenre).HasColumnName("id_genre");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Opinion)
                    .HasColumnType("text")
                    .HasColumnName("opinion");

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.HasOne(d => d.IdGenreNavigation)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.IdGenre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_games_id_genre");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.IdGenre)
                    .HasName("pk_genre_id");

                entity.Property(e => e.IdGenre).HasColumnName("id_genre");

                entity.Property(e => e.GenreName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).HasName("UQ__Users__AB6E6164F56D7870")
                    .IsUnique();

               entity.HasIndex(e => e.Username).HasName("UQ__Users__F3DBC572A854F7CE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UsersGame>(entity =>
            {
                entity.ToTable("Users_games");

                entity.HasIndex(e => e.GameId).HasName("IX_Users_games_game_id");

                entity.HasIndex(e => e.UserId).HasName("IX_Users_games_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usersgames_game");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersGames)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usersgames_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
