using Volo.Abp.Modularity;

namespace Bolek.Dentonline;

[DependsOn(
    typeof(DentonlineApplicationModule),
    typeof(DentonlineDomainTestModule)
    )]
public class DentonlineApplicationTestModule : AbpModule
{

}
