﻿using Microsoft.AspNetCore.Identity;

namespace Medical.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AccountUser class
public class AccountUser : IdentityUser
{
    public virtual ICollection<AccountUserRole> UserRoles { get; set; }
}