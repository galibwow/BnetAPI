using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BnetAPI.Domain.Common;

namespace BnetAPI.Domain.Models
{
    public class Genres:AuditEntitiy
    {
        [Key]
        public long GenreId { get; set; }
        public long GenreName { get; set; }
    }
}
