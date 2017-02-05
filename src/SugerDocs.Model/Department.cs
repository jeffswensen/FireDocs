using System;
using System.Collections.Generic;
using System.Text;

namespace SugerDocs.Model {
    public class Department {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
