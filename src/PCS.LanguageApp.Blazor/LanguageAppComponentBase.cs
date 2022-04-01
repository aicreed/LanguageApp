using PCS.LanguageApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PCS.LanguageApp.Blazor;

public abstract class LanguageAppComponentBase : AbpComponentBase
{
    protected LanguageAppComponentBase()
    {
        LocalizationResource = typeof(LanguageAppResource);
    }
}
