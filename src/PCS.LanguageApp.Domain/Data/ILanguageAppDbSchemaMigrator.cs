using System.Threading.Tasks;

namespace PCS.LanguageApp.Data;

public interface ILanguageAppDbSchemaMigrator
{
    Task MigrateAsync();
}
