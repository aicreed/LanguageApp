using PCS.LanguageApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PCS.LanguageApp;

[DependsOn(
    typeof(LanguageAppEntityFrameworkCoreTestModule)
    )]
public class LanguageAppDomainTestModule : AbpModule
{

}
