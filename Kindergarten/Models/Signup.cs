using System.ComponentModel.DataAnnotations;

namespace kinder.Models
{
    public class Signup
    {
        [Key]
        public int? UserId { get; set; }
        public string? FullName { get; set; }
        public int? Age { get; set; }
        public int? CardNumber { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? AnswerSecurty { get; set; }
    }
}
