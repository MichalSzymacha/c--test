using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Resources")]
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual ICollection<Blob> Blobs { get; set; } = new List<Blob>();
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}