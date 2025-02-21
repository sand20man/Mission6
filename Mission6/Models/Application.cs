using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Mission6.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2025, ErrorMessage = "Year must be between 1888 and 2025")]
        public int Year { get; set; }
        
        public string? Director { get; set; }
        
        public string? Rating { get; set; } // G, PG, PG-13, R

        [Required]
        public bool Edited { get; set; } // Nullable (optional field)
        
        public string? LentTo { get; set; } // Nullable
        
        [Required]
        public bool CopiedToPlex { get; set; }
        
        [MaxLength(25)]
        public string? Notes { get; set; } // Nullable, max 25 chars
    }
}


