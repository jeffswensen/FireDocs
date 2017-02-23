
namespace FireDocs.Model {
    using System.Collections.Generic;
    public class Organization {
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Members { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
