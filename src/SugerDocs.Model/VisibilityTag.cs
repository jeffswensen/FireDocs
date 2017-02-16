namespace SugerDocs.Model {
    public class VisibilityTag {
        public int VisibilityTagId { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public string Name { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
