using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Entities;

public class UserEntity : IdentityUser
{
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public string? ProfileImage { get; set; } = "Avatar.jpg";
    public string? Bio { get; set; }

    public int? AdressId { get; set; }
    public AdressEntity? Adresss { get; set; }
}
