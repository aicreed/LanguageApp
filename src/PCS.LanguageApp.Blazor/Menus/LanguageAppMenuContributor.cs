using System.Threading.Tasks;
using PCS.LanguageApp.Localization;
using PCS.LanguageApp.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace PCS.LanguageApp.Blazor.Menus;

public class LanguageAppMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<LanguageAppResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                LanguageAppMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                LanguageAppMenus.Activities,
                l["Menu:Activity1"],
                "/activities/1",
                order: 1
            )
        );
        context.Menu.Items.Insert(
           0,
           new ApplicationMenuItem(
               LanguageAppMenus.Activities,
               l["Menu:Activity2"],
               "/activities/2",
               order: 2
           )
       );
        context.Menu.Items.Insert(
           0,
           new ApplicationMenuItem(
               LanguageAppMenus.Activities,
               l["Menu:Activity3"],
               "/activities/3",
               order: 3
           )
       );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }
}
