using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace M3NETCORE_MVCEF.DatabaseFirst.Models
{
    public partial class QatarDBContext : DbContext
    {
        public QatarDBContext()
        {
        }

        public QatarDBContext(DbContextOptions<QatarDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerPosition> PlayerPosition { get; set; }
        public virtual DbSet<PlayerTeam> PlayerTeam { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=QatarDB;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.PlayerPositionId, "IX_Player_PlayerPositionId");

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.HasOne(d => d.PlayerPosition)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.PlayerPositionId);
            });

            modelBuilder.Entity<PlayerPosition>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<PlayerTeam>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.TeamId });

                entity.HasIndex(e => e.TeamId, "IX_PlayerTeam_TeamId");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerTeam)
                    .HasForeignKey(d => d.PlayerId);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.PlayerTeam)
                    .HasForeignKey(d => d.TeamId);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
