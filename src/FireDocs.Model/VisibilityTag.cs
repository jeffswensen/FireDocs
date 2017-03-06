namespace FireDocs.Model {
    public class VisibilityTag {
        public int VisibilityTagId { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
