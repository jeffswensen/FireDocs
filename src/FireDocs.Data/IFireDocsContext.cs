namespace FireDocs.Data {
    using FireDocs.Model;
    using Microsoft.EntityFrameworkCore;

    public interface IFireDocsContext {
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
