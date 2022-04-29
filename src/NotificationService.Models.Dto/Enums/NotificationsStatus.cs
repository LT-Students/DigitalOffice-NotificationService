using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace LT.DigitalOffice.NotificationsService.Models.Dto.Enums
{
  [JsonConverter(typeof(StringEnumConverter))]
  public enum NotificationsStatus
  {
    Sended,
    Readed
  }
}
