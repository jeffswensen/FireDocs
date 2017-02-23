
namespace FireDocs.Model {
    using System.Collections.Generic;
    public class Document {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public List<VisibilityTag> Tags { get; set; }
        public PeriodType PeriodType { get; set; }
        public byte[] Timestamp { get; set; }

    }
}
