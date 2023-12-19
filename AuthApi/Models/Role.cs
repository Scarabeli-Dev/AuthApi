using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthApi.Models;

public class Role : IdentityRole<Guid>
{
    [Column("user_roles")]
    public IEnumerable<UserRoles> UserRoles { get; set; }
}
