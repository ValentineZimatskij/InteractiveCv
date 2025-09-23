using System.ComponentModel.DataAnnotations;

namespace InteractiveCv.Server.Models;

public class Project
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    public string? Technologies { get; set; }

    [Url]
    public string? GitHubUrl { get; set; }

    [Url]
    public string? LiveUrl { get; set; }

    public string? ImageUrl { get; set; }

    public bool IsFeatured { get; set; }

    public int Order { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}