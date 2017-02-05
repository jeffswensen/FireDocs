using System;
using System.Collections.Generic;
using System.Text;

namespace SugerDocs.Model {
    public class User {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
