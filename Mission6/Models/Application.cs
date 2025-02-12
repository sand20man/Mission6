using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1900, 2025, ErrorMessage = "Year must be between 1900 and 2025")]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // G, PG, PG-13, R

        public bool? Edited { get; set; } // Nullable (optional field)
        public string? LentTo { get; set; } // Nullable
        [MaxLength(25)]
        public string? Notes { get; set; } // Nullable, max 25 chars
    }
}


