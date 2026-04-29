using Domain.Entities.IdentityModule;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Data
{
    public class EStoreDbContextIdentity(DbContextOptions<EStoreDbContextIdentity> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<IdentityUserRole<String>>().ToTable("UserRoles");
            builder.Entity<IdentityRole>().ToTable("Roles");
            //----------------------------------------------
            builder.Ignore<IdentityUserLogin<String>>();
            builder.Ignore<IdentityUserToken<String>>();
            builder.Ignore<IdentityUserClaim<String>>();
            builder.Ignore<IdentityRoleClaim<String>>();
        }
    }
}
