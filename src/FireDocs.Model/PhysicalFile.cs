
namespace FireDocs.Model {
    using System;
    public class PhysicalFile {
        public int PhysicalFileId { get; set; }
        public long DocumentVersionId { get; set; }
        public virtual DocumentVersion DocumentVersion { get; set; }
        public string Filename { get; set; }
        public DateTime UploadDate { get; set; }
        public string StoragePath { get; set; }
    }
}
