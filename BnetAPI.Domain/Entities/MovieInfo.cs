using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using BnetAPI.Domain.Common;

namespace BnetAPI.Domain.Models
{
    public class MovieInfo:AuditEntitiy
    {
        [Key]
        public long MovieId { get; set; }
        public long Destination { get; set; }
        public string MovieName { get; set; }

        public int Imdb_id { get; set; }

        public string OriginalTitle { get; set; }
        public string Originallanguage { get; set; }
        public string OrginalOverview { get; set; }

        public double Populerity { get; set; }

        public string PosterPath { get; set; }
        public DateTime Release_date { get; set; }
        public float Runtime { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public float VoteAverage { get; set; }

        public long Genreid { get; set; }

        [ForeignKey("Genreid")]
        public virtual Genres Genres { get; set; }
    }
}
