using System;
using LT.DigitalOffice.NotificationsService.Models.Dto.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NotificationService.Models.Db
{
  public class DbNotification
  {
    public const string TableName = "Notifications";

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Description { get; set; }
    public NotificationsStatus Status { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedAtUtc { get; set; }
  }

  public class DbNotificationConfiguration : IEntityTypeConfiguration<DbNotification>
  {
    public void Configure(EntityTypeBuilder<DbNotification> builder)
    {
      builder
        .ToTable(DbNotification.TableName);

      builder.HasKey(x => x.Id);
    }
  }
}
