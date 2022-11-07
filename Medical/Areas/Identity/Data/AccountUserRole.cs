using Microsoft.AspNetCore.Identity;

namespace Medical.Areas.Identity.Data;

public class AccountUserRole : IdentityUserRole<string>
{
    public virtual AccountUser User { get; set; }
    public virtual AccountRole Role { get; set; }
}