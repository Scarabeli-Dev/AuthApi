﻿using Microsoft.AspNetCore.Identity;

namespace AuthApi.Models;

public class UserRoles : IdentityUserRole<Guid>
{
    public User User { get; set; }
    public Role Role { get; set; }
}
