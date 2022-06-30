using Medical.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Medical.Data;

//public class AccountContext : IdentityDbContext<AccountUser>
//{
//    public AccountContext(DbContextOptions<AccountContext> options)
//        : base(options)
//    {
//    }

//    protected override void OnModelCreating(ModelBuilder builder)
//    {
//        base.OnModelCreating(builder);
//        // Customize the ASP.NET Identity model and override the defaults if needed.
//        // For example, you can rename the ASP.NET Identity table names and more.
//        // Add your customizations after calling base.OnModelCreating(builder);
//    }
//}
public class AccountContext : IdentityDbContext<
        AccountUser, AccountRole, string,
        IdentityUserClaim<string>, AccountUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>//IdentityDbContext<CallCenterUser> IdentityDbContext<AccountUser>
{
    public AccountContext(DbContextOptions<AccountContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        base.OnModelCreating(builder);

        builder.Entity<AccountUser>().HasKey(p => p.Id);
        builder.Entity<AccountRole>().HasKey(p => p.Id);

        builder.Entity<AccountUser>(b =>
        {
            b.HasMany(e => e.UserRoles)
            .WithOne(w => w.User)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired();
        });
        builder.Entity<AccountRole>(b =>
        {
            // Each Role can have many entries in the UserRole join table
            b.HasMany(e => e.UserRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
        });
        // Customize the ASP.NET Identity model and override the defaults if needed. For example,
        // you can rename the ASP.NET Identity table names and more. Add your customizations after
        // calling base.OnModelCreating(builder);
    }
}