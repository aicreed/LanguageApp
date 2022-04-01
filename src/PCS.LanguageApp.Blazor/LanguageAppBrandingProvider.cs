using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PCS.LanguageApp.Blazor;

[Dependency(ReplaceServices = true)]
public class LanguageAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LanguageApp";
}
