using PCS.LanguageApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PCS.LanguageApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LanguageAppEntityFrameworkCoreModule),
    typeof(LanguageAppApplicationContractsModule)
    )]
public class LanguageAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
