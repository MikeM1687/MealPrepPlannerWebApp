using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MealPrepPlannerWebApp.Entities.Models
{
    public partial class MealPrepPlannerWebApp_DatabaseContext : DbContext
    {
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Meal> Meal { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

        public MealPrepPlannerWebApp_DatabaseContext(DbContextOptions<MealPrepPlannerWebApp_DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MealPrepPlannerWebApp.Database;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(50)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ingredient_ToUnit");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(50)");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.Meal)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Meal_ToIngredient");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(10)");
            });
        }
    }
}
