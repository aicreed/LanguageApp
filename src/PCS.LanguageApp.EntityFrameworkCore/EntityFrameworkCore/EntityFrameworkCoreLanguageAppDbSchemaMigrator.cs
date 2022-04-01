using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PCS.LanguageApp.Data;
using Volo.Abp.DependencyInjection;

namespace PCS.LanguageApp.EntityFrameworkCore;

public class EntityFrameworkCoreLanguageAppDbSchemaMigrator
    : ILanguageAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLanguageAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LanguageAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LanguageAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
