using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SugerDocs.Model {
    public class DepartmentRole {
        public int DepartmentRoleId { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
