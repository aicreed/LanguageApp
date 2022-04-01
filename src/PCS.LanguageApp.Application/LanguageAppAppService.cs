using System;
using System.Collections.Generic;
using System.Text;
using PCS.LanguageApp.Localization;
using Volo.Abp.Application.Services;

namespace PCS.LanguageApp;

/* Inherit your application services from this class.
 */
public abstract class LanguageAppAppService : ApplicationService
{
    protected LanguageAppAppService()
    {
        LocalizationResource = typeof(LanguageAppResource);
    }
}
