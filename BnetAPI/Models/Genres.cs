using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BnetAPI.Models
{
    public class Genres
    {
        [Key]
        public long GenreId { get; set; }
        public long GenreName { get; set; }
    }
}
