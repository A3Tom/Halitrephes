using System;

namespace Halitrephes.Domain.Dtos
{
    public class IoTEvent
    {
        public Guid Id { get; init; }
        public Guid DeviceId { get; init; }
        public DateTimeOffset CreatedOn { get; init; }
    }
}
