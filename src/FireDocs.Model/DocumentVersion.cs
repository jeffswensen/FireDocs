﻿namespace FireDocs.Model {
    public class DocumentVersion {
        public long DocumentVersionId { get; set; }
        public int DocumentId { get; set; }
        public virtual Document Document { get; set; }
        public int PeriodId { get; set; }
        public virtual Period Period { get; set; }
        public DocumentVersionStatus Status { get; set; }
        public byte[] Timestamp { get; set; }
    }

    public enum DocumentVersionStatus {
        Oustanding, Pending, Published, Revoked, Vetoed
    }
}
