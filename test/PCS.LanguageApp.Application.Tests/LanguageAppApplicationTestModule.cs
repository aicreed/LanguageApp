using Volo.Abp.Modularity;

namespace PCS.LanguageApp;

[DependsOn(
    typeof(LanguageAppApplicationModule),
    typeof(LanguageAppDomainTestModule)
    )]
public class LanguageAppApplicationTestModule : AbpModule
{

}
