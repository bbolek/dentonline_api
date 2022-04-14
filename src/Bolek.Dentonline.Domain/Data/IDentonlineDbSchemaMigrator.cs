using System.Threading.Tasks;

namespace Bolek.Dentonline.Data;

public interface IDentonlineDbSchemaMigrator
{
    Task MigrateAsync();
}
