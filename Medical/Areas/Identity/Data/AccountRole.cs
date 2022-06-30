using Microsoft.AspNetCore.Identity;

namespace Medical.Areas.Identity.Data;


public class AccountRole : IdentityRole
    {
        public virtual ICollection<AccountUserRole> UserRoles { get; set; }
    }

