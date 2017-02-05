using System;
using System.Collections.Generic;
using System.Text;

namespace SugerDocs.Model {
    public class OrganizationRole {
        public int OrganizationRoleId { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
