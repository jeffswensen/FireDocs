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

        public DbSet<Department> Departments { get; }

        public DbSet<DepartmentRole> DepartmentRoles { get; }

        public DbSet<Document> Documents { get; }

        public DbSet<DocumentRole> DocumentRoles { get; }

        public DbSet<Organization> Organizations { get; }

        public DbSet<OrganizationRole> OrganizationRoles { get; }

        public DbSet<SiteRole> SiteRoles { get; }

        public DbSet<Role> Roles { get; }

        public DbSet<User> Users { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<DepartmentRole>()
                .HasAlternateKey(dr => new { dr.RoleId, dr.UserId, dr.DepartmentId });
            modelBuilder.Entity<DocumentRole>()
                .HasAlternateKey(dr => new { dr.RoleId, dr.UserId, dr.DocumentId, dr.Level });
            modelBuilder.Entity<OrganizationRole>()
                .HasAlternateKey(or => new { or.RoleId, or.UserId, or.OrganizationId });
            modelBuilder.Entity<SiteRole>()
                .HasAlternateKey(sr => new { sr.RoleId, sr.UserId });
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
