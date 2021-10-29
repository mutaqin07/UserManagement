using System.ComponentModel.DataAnnotations;

namespace UserManagement.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}