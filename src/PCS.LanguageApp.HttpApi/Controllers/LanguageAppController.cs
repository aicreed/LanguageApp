using PCS.LanguageApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PCS.LanguageApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LanguageAppController : AbpControllerBase
{
    protected LanguageAppController()
    {
        LocalizationResource = typeof(LanguageAppResource);
    }
}
