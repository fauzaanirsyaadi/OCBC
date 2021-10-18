using System.ComponentModel.DataAnnotations;
using TodoApp.Controllers;

namespace TodoApp.Models.DTOs.Requests {
    public class UserLoginRequest {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}