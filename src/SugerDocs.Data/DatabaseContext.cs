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

        public DbSet<VisibilityTag> VisibilityTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            // Department
            modelBuilder.Entity<Department>()
                .HasKey(d => d.DepartmentId);
            modelBuilder.Entity<Department>()
                .Property(d => d.DepartmentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Department>()
                .Property(d => d.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            // DepartmentRole
            modelBuilder.Entity<DepartmentRole>()
                .HasKey(dr => dr.DepartmentRoleId);
            modelBuilder.Entity<DepartmentRole>()
                .Property(dr => dr.DepartmentRoleId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<DepartmentRole>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();
            modelBuilder.Entity<DepartmentRole>()
                .HasAlternateKey(dr => new { dr.RoleId, dr.UserId, dr.DepartmentId });

            // Document
            modelBuilder.Entity<Document>()
                .HasKey(e => e.DocumentId);
            modelBuilder.Entity<Document>()
                .Property(e => e.DocumentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Document>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            // DocumentRole
            modelBuilder.Entity<DocumentRole>()
                .HasKey(e => e.DocumentRoleId);
            modelBuilder.Entity<DocumentRole>()
                .Property(e => e.DocumentRoleId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<DocumentRole>()
                .HasAlternateKey(dr => new { dr.RoleId, dr.UserId, dr.DocumentId, dr.Level });
            modelBuilder.Entity<DocumentRole>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            // Organization
            modelBuilder.Entity<Organization>()
                .HasKey(e => e.OrganizationId);
            modelBuilder.Entity<Organization>()
                .Property(e => e.OrganizationId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Organization>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            // OrganizationRole
            modelBuilder.Entity<OrganizationRole>()
                .HasKey(e => e.OrganizationRoleId);
            modelBuilder.Entity<OrganizationRole>()
                .Property(e => e.OrganizationRoleId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<OrganizationRole>()
                .HasAlternateKey(or => new { or.RoleId, or.UserId, or.OrganizationId });
            modelBuilder.Entity<OrganizationRole>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            // Role
            modelBuilder.Entity<Role>()
                .HasKey(e => e.RoleId);
            modelBuilder.Entity<Role>()
                .Property(e => e.RoleId)
                .ValueGeneratedOnAdd();

            // SiteRole
            modelBuilder.Entity<SiteRole>()
                .HasKey(e => e.SiteRoleId);
            modelBuilder.Entity<SiteRole>()
                .Property(e => e.SiteRoleId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SiteRole>()
                .HasAlternateKey(sr => new { sr.RoleId, sr.UserId });
            modelBuilder.Entity<SiteRole>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            // User
            modelBuilder.Entity<User>()
                .HasKey(e => e.UserId);
            modelBuilder.Entity<User>()
                .Property(e => e.UserId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
                .HasAlternateKey(e => e.EmailAddress);
            modelBuilder.Entity<User>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

            // VisibilityTag
            modelBuilder.Entity<VisibilityTag>()
                .HasKey(e => e.VisibilityTagId);
            modelBuilder.Entity<VisibilityTag>()
                .Property(e => e.VisibilityTagId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<VisibilityTag>()
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();
            modelBuilder.Entity<VisibilityTag>()
                .HasAlternateKey(e => new { e.OrganizationId, e.Name });

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
        DbSet<VisibilityTag> VisibilityTags { get; }

    }
}
