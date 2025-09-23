using System.ComponentModel.DataAnnotations;

namespace InteractiveCv.Server.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Level { get; set; } = "Intermediate";
        // Beginner, Intermediate, Advanced, Expert

        public int Order { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
