using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SugerDocs.Model {
    public class Document {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public List<VisibilityTag> Tags { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
