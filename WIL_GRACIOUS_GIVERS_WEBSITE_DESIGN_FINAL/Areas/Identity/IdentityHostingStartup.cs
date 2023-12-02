using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WIL_GRACIOUS_GIVERS_WEBSITE_DESIGN_FINAL.Data;

[assembly: HostingStartup(typeof(WIL_GRACIOUS_GIVERS_WEBSITE_DESIGN_FINAL.Areas.Identity.IdentityHostingStartup))]
namespace WIL_GRACIOUS_GIVERS_WEBSITE_DESIGN_FINAL.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}