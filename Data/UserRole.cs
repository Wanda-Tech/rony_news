using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Microsoft.EntityFrameworkCore;


[PrimaryKey(nameof(UserId), nameof(RoleId))]
public class UserRole
{
    public int UserId { get; set; }
    public required User User { get; set; }

    public int RoleId { get; set; }
    public required Role Role { get; set; }

}
