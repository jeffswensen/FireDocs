using System;
using System.Collections.Generic;
using System.Text;

namespace SugerDocs.Model {
    public class Role {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public RoleScope Scope { get; set; }
    }
    public enum RoleScope { Site, Organization, Department, Document };
}
