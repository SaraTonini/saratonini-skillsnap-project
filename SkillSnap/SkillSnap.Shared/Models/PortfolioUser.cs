using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillSnap.Shared.Models
{
    public class PortfolioUser
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Bio { get; set; }

        public string? ProfileImageUrl { get; set; }

        // Navigation properties
        [InverseProperty("PortfolioUser")]
        public List<Project> Projects { get; set; } = new();

        [InverseProperty("PortfolioUser")]
        public List<Skill> Skills { get; set; } = new();

    }
}
