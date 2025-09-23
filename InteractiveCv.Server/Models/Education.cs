using System.ComponentModel.DataAnnotations;

namespace InteractiveCv.Server.Models;

public class Education
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Institution { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Degree { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Period { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int Order { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}