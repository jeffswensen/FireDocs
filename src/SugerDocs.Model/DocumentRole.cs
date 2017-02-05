using System;
using System.Collections.Generic;
using System.Text;

namespace SugerDocs.Model {
    public class DocumentRole {
        public int DocumentRoleId { get; set; }
        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int Level { get; set; }
    }
}
