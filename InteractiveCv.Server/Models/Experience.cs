using System.ComponentModel.DataAnnotations;

namespace InteractiveCv.Server.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Technologies { get; set; }
        public int Order { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
