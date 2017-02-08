using Microsoft.EntityFrameworkCore;
using System;
using SugerDocs.Model;

namespace SugerDocs.Data {

    // TODO:
    /*
     * https://docs.microsoft.com/en-us/ef/core/modeling/concurrency
     * 
     */
    public class DatabaseContext : DbContext, IDatabaseContext {
        public DbSet<Department> Departments => throw new NotImplementedException();

        public DbSet<DepartmentRole> DepartmentRoles => throw new NotImplementedException();

        public DbSet<Document> Documents => throw new NotImplementedException();

        public DbSet<DocumentRole> DocumentRoles => throw new NotImplementedException();

        public DbSet<Organization> Organizations => throw new NotImplementedException();

        public DbSet<OrganizationRole> OrganizationRoles => throw new NotImplementedException();

        public DbSet<Role> Roles => throw new NotImplementedException();

        public DbSet<User> Users => throw new NotImplementedException();
    }

    public interface IDatabaseContext {
        DbSet<Department> Departments { get; }
        DbSet<DepartmentRole> DepartmentRoles { get; }
        DbSet<Document> Documents { get; }
        DbSet<DocumentRole> DocumentRoles { get; }
        DbSet<Organization> Organizations { get; }
        DbSet<OrganizationRole> OrganizationRoles { get; }
        DbSet<Role> Roles { get; }
        DbSet<User> Users { get; }

    }
}
