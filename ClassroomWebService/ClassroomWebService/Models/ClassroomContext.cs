namespace ClassroomWebService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClassroomContext : DbContext
    {
        public ClassroomContext()
            : base("name=ClassroomContext")
        {
        }

        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<ResourceCategory> ResourceCategories { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceType> ResourceTypes { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Audit>()
                .Property(e => e.ObjectType)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.OldValue)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.NewValue)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.Data)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Building1)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.entry_user)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.modify_user)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Building)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResourceCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Resource>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Resource>()
                .Property(e => e.entry_user)
                .IsUnicode(false);

            modelBuilder.Entity<Resource>()
                .Property(e => e.modify_user)
                .IsUnicode(false);

            modelBuilder.Entity<ResourceType>()
                .Property(e => e.ResourceType1)
                .IsUnicode(false);

            modelBuilder.Entity<ResourceType>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<ResourceType>()
                .HasMany(e => e.ResourceTypes1)
                .WithOptional(e => e.ResourceType2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Room>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.modify_by)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.entry_user)
                .IsUnicode(false);
        }
    }
}
