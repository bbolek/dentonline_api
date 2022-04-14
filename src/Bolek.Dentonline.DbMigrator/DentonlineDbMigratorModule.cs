using Bolek.Dentonline.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Bolek.Dentonline.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DentonlineEntityFrameworkCoreModule),
    typeof(DentonlineApplicationContractsModule)
    )]
public class DentonlineDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
