using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
public class Role
{
    [Key]
    public int RoleId { get; set; }

    [MaxLength(10)]
    public required string Name { get; set; }

    [MaxLength(255)]
    public required string Description { get; set; }

    public List<UserRole>? UserRoles { get; set; }

}
