using Eventify_OnionArchitecture.Domain.ValueObject;

namespace Eventify_OnionArchitecture.Application.DTOs
{
    public class CreateEventDTO
    {
        public string Title { get; set; }
        public DateTimeOffset EventDate { get; set; }
        public Location Location { get; set; }
    }
}
