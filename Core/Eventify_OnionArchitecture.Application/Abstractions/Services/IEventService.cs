using Eventify_OnionArchitecture.Application.DTOs;
using Eventify_OnionArchitecture.Application.RequestParameters;

namespace Eventify_OnionArchitecture.Application.Abstractions.Services
{
    public interface IEventService
    {
        //Task CreateEventAsync(string title, DateTimeOffset date, Location location);

        // bunlari elnen 1-1 girmey yerine dto yaradiriq.

        Task CreateEventAsync(CreateEventDTO createEventDTO);

        //Task<IEnumerable<Event>> GetAllEventsAsync();

        //Eventi bura gondermey tehlukesizlik cehetden problemdi. Sebebi Event classinin daxilinde
        //Base entitiden alma id v.s setirleri var. Buda UI da gosterilmemesi lazim olan melumatlardi...
        //Ona gorede Event yerine Eventde neleri gostermek isteyirikse EventDTO yaradiriq...

        Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination);

    }
}
