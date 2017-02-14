using Microsoft.EntityFrameworkCore;
using System;
using SugerDocs.Model;

namespace SugerDocs.Data {

    // TODO:
    /*
     * https://docs.microsoft.com/en-us/ef/core/modeling/concurrency
     * 
     */
    public class SugerContext : DbContext, ISugerContext {

        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentRole> DepartmentRoles { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<DocumentRole> DocumentRoles { get; set; }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<OrganizationRole> OrganizationRoles { get; set; }

        public DbSet<SiteRole> SiteRoles { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<DepartmentRole>()
                .HasAlternateKey(dr => new { dr.RoleId, dr.UserId, dr.DepartmentId });
            modelBuilder.Entity<DocumentRole>()
                .HasAlternateKey(dr => new { dr.RoleId, dr.UserId, dr.DocumentId, dr.Level });
            modelBuilder.Entity<OrganizationRole>()
                .HasAlternateKey(or => new { or.RoleId, or.UserId, or.OrganizationId });
            modelBuilder.Entity<SiteRole>()
                .HasAlternateKey(sr => new { sr.RoleId, sr.UserId });

            modelBuilder.Entity<Department>()
                .HasKey(d => d.DepartmentId);
            modelBuilder.Entity<Department>()
                .Property(d => d.DepartmentId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<DepartmentRole>()
                .HasKey(dr => dr.DepartmentRoleId);
            modelBuilder.Entity<DepartmentRole>()
                .Property(dr => dr.DepartmentRoleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Document>()
                .HasKey(e => e.DocumentId);
            modelBuilder.Entity<Document>()
                .Property(e => e.DocumentId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<DocumentRole>()
                .HasKey(e => e.DocumentRoleId);
            modelBuilder.Entity<DocumentRole>()
                .Property(e => e.DocumentRoleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Organization>()
                .HasKey(e => e.OrganizationId);
            modelBuilder.Entity<Organization>()
                .Property(e => e.OrganizationId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<OrganizationRole>()
                .HasKey(e => e.OrganizationRoleId);
            modelBuilder.Entity<OrganizationRole>()
                .Property(e => e.OrganizationRoleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Role>()
                .HasKey(e => e.RoleId);
            modelBuilder.Entity<Role>()
                .Property(e => e.RoleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<SiteRole>()
                .HasKey(e => e.SiteRoleId);
            modelBuilder.Entity<SiteRole>()
                .Property(e => e.SiteRoleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
                .HasKey(e => e.UserId);
            modelBuilder.Entity<User>()
                .Property(e => e.UserId)
                .ValueGeneratedOnAdd();

        }
    }

    public interface ISugerContext {
        DbSet<Department> Departments { get; }
        DbSet<DepartmentRole> DepartmentRoles { get; }
        DbSet<Document> Documents { get; }
        DbSet<DocumentRole> DocumentRoles { get; }
        DbSet<Organization> Organizations { get; }
        DbSet<OrganizationRole> OrganizationRoles { get; }
        DbSet<SiteRole> SiteRoles { get; }
        DbSet<Role> Roles { get; }
        DbSet<User> Users { get; }

    }
}
