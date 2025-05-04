using DragonFarm.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DragonFarm.Data.Models
{
    [Table("Dragons")]
    public class Dragons
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Sex Sex { get; set; }
        public string Image { get; set; }
        [Required]
        public DragonBreeds Breed { get; set; } = DragonBreeds.CommonDrake;
        [Required]
        public BreathTypes BreathType { get; set; }
        [Required]
        public WingTypes WingType { get; set; }
        [Required]
        public DragonColors Color { get; set; }
        [Required]
        public HornTypes HornType { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Weight { get; set; }
        public int Age { get; set; }
    }
}
