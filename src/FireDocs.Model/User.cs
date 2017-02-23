namespace FireDocs.Model {
    using System.Collections.Generic;
    public class User {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public List<VisibilityTag> Tags { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
