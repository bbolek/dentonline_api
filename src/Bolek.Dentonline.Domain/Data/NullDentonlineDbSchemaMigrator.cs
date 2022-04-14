using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Bolek.Dentonline.Data;

/* This is used if database provider does't define
 * IDentonlineDbSchemaMigrator implementation.
 */
public class NullDentonlineDbSchemaMigrator : IDentonlineDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
