namespace BlogEFCore.Models;

public class UserRole
{
    [ForeignKey("PostId")]
    public int UserId { get; set; }

    [ForeignKey("PostId")]
    public int RoleId { get; set; }
}