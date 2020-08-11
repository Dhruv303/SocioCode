using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocioCode.Areas.Identity.Data;
using SocioCode.Models;

[assembly: HostingStartup(typeof(SocioCode.Areas.Identity.IdentityHostingStartup))]
namespace SocioCode.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SocioCodeContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SocioCodeContextConnection")));

                services.AddDefaultIdentity<SocioCodeUser>(options => options.SignIn.RequireConfirmedEmail = false)
                    .AddEntityFrameworkStores<SocioCodeContext>();
            });
        }
    }
}