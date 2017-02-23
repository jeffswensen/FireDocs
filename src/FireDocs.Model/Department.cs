namespace FireDocs.Model {
    public class Department {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
