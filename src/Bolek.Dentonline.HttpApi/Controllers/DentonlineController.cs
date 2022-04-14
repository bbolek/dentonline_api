using Bolek.Dentonline.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Bolek.Dentonline.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DentonlineController : AbpControllerBase
{
    protected DentonlineController()
    {
        LocalizationResource = typeof(DentonlineResource);
    }
}
