using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DragonFarm.Data.Models
{
    public class UserDragons
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int DragonId { get; set; }


        [ForeignKey(nameof(UserId))]
        public virtual Users User { get; set; }
        [ForeignKey(nameof(DragonId))]
        public virtual Dragons Dragon { get; set; }
    }
}
