using Bolek.Dentonline.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Bolek.Dentonline;

[DependsOn(
    typeof(DentonlineEntityFrameworkCoreTestModule)
    )]
public class DentonlineDomainTestModule : AbpModule
{

}
