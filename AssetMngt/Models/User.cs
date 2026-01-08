using System.ComponentModel.DataAnnotations;

namespace AssetMngt.Models
{

    public enum UserRole
    {
        Employee,
        Manager,
        Admin
    }

    public enum UserStatus
    {
        Active,
        Inactive
    }
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        [Required]
        public string UserName { get; set; }
        [Required]
        public UserRole Role { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(100)]
        public string Department { get; set; }
        [Required]
        public UserStatus Status { get; set; }

    }
}
