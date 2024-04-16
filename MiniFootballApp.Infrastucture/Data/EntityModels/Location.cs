using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(25)]
        public string Country { get; set; } = string.Empty;
    }
}
