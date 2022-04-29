using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotificationService.Data.Provider;
using NotificationService.Models.Db;

namespace LT.DigitalOffice.NotificationService.Data.Provider.MsSql.Ef
{
  public class NotificationServiceDbContext : DbContext, IDataProvider
  {
    public DbSet<DbNotification> Notifications { get; set; }

    public NotificationServiceDbContext(DbContextOptions<NotificationServiceDbContext> options)
      : base(options)
    {

    }

    // Fluent API is written here.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("LT.DigitalOffice.NotificationService.Models.Db"));
    }

    public object MakeEntityDetached(object obj)
    {
      Entry(obj).State = EntityState.Detached;

      return Entry(obj).State;
    }

    public void Save()
    {
      SaveChanges();
    }

    public void EnsureDeleted()
    {
      Database.EnsureDeleted();
    }

    public bool IsInMemory()
    {
      return Database.IsInMemory();
    }

    public async Task SaveAsync()
    {
      await SaveChangesAsync();
    }
  }
}
