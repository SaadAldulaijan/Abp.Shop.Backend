using System.Threading.Tasks;

namespace Shop.Data;

public interface IShopDbSchemaMigrator
{
    Task MigrateAsync();
}
