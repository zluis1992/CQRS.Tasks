using Infrastructure.ValueObject;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.DTOs
{
    public record TaskItemDto
    {
        [ValidInt(ErrorMessage = "The Id value is invalid")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The field Title is required")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "The field Description is required")]
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}
