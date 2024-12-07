using Microsoft.EntityFrameworkCore;
using Shedule.Infrastructure.Context;
using System.Runtime.CompilerServices;

namespace Shedule.API.Extensions;

public static class AddDbExtension
{
    public static void AddDataBase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(
            builder.Configuration["ConnectionString:DefaultConnection"],
            o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
        ));
    }
}
