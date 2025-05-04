using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DragonFarm.Data.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public bool DarkMode { get; set; } = false;
        [Required]
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
