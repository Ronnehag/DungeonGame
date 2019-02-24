using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dungeon.Data.Identity;

namespace Dungeon.Models
{
    public class Character
    {
        [Key]
        [Required]
        public int CharacterId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int CharacterStatsId { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [ForeignKey("UserId")]
        public AppUser User { get; set; }

        [ForeignKey("CharacterStatsId")]
        public CharacterStats CharacterStats { get; set; }


    }
}
