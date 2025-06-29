using Eventify_OnionArchitecture.Domain.ValueObject;

namespace Eventify_OnionArchitecture.Application.DTOs
{
    //Paylasmaq istediyimiz datalara gore DTO yaradiriq. yoxsa Id v.s gelecey Event clasndan...
    public class EventDTO
    {
        public string Title { get; set; }
        public DateTimeOffset EventDate { get; set; }
        public Location Location { get; set; }
    }
}
