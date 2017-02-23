using System;
using System.Collections.Generic;

namespace FireDocs.Model {
    public class Organization {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Members { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
