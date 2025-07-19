using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
public class User
{
    [Key]
    public int UserId { get; set; }

    [MaxLength(10)]
    public string? Phone { get; set; }

    [MaxLength(50)]
    public required string Email { get; set; }

    [MaxLength(50)]
    public required string Password { get; set; }

    public DateTime CreatedDate { get; set; }

    public List<News>? NewsList { get; set; }

    public required List<UserRole> UserRoles { get; set; }
}
