using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dungeon.Models
{
    public class CharacterStats
    {
        [Key]
        [Required]
        public int CharacterStatsId { get; set; }

        [Required]
        public int CharacterId { get; set; }

        [Required]
        public int CurrentLevel { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public int Health { get; set; }

        [Required]
        public int Energy { get; set; }

        [Required]
        public int Strength { get; set; }

        [Required]
        public int Magic { get; set; }
    }
}
