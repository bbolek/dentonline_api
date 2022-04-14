using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Bolek.Dentonline;

[Dependency(ReplaceServices = true)]
public class DentonlineBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Dentonline";
}
