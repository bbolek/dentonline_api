using System;
using System.Collections.Generic;
using System.Text;
using Bolek.Dentonline.Localization;
using Volo.Abp.Application.Services;

namespace Bolek.Dentonline;

/* Inherit your application services from this class.
 */
public abstract class DentonlineAppService : ApplicationService
{
    protected DentonlineAppService()
    {
        LocalizationResource = typeof(DentonlineResource);
    }
}
