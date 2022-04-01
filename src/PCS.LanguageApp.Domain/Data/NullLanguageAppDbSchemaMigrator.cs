using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PCS.LanguageApp.Data;

/* This is used if database provider does't define
 * ILanguageAppDbSchemaMigrator implementation.
 */
public class NullLanguageAppDbSchemaMigrator : ILanguageAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
