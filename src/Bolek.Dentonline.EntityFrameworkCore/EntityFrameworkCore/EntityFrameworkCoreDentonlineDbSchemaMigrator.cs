using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bolek.Dentonline.Data;
using Volo.Abp.DependencyInjection;

namespace Bolek.Dentonline.EntityFrameworkCore;

public class EntityFrameworkCoreDentonlineDbSchemaMigrator
    : IDentonlineDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDentonlineDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DentonlineDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DentonlineDbContext>()
            .Database
            .MigrateAsync();
    }
}
