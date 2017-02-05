using System;
using System.Collections.Generic;
using System.Text;

namespace SugerDocs.Model {
    public class Document {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
