using Eventify_OnionArchitecture.Domain.Common;
using Eventify_OnionArchitecture.Domain.ValueObject;

namespace Eventify_OnionArchitecture.Domain.Entities
{
    public class Event : EntityBase
    {
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public Location Location { get; set; }
    }
}
