using System.ComponentModel.DataAnnotations;

namespace SkillSnap.Shared.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Skill name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Skill level is required")]
        public string Level { get; set; } = string.Empty;

        public int PortfolioUserId { get; set; }
    }
}
