using System;
using System.Collections.Generic;
using System.Text;

namespace BnetAPI.Domain.Common
{
    public class AuditEntitiy
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
