using Eventify_OnionArchitecture.Application.Abstractions.Services;
using Eventify_OnionArchitecture.Application.DTOs;
using Eventify_OnionArchitecture.Application.RequestParameters;
using Eventify_OnionArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eventify_OnionArchitecture.Persistence.Services
{
    public class EventService : IEventService
    {
        private readonly AppDbContext _context;

        public EventService(AppDbContext context)
        {
            _context = context;
        }


        public async Task CreateEventAsync(CreateEventDTO createEventDTO)
        {
            if (createEventDTO is not null)
            {
                var newEvent = new Event()
                {
                    Title = createEventDTO.Title,
                    Location = createEventDTO.Location,
                    Date = createEventDTO.Date,
                };

                await _context.Events.AddAsync(newEvent);
                await _context.SaveChangesAsync();
            }
            else
                throw new NullReferenceException();


        }


        //Dtoda melumatlar limitlidi deye pramoy contextden cekebilmrik datani. Error verir
        //Ona gorede selectnen dto icinde olan propertileri getiririk.
        public async Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination)
        {
            return await _context.Events
                .AsNoTracking()
                .Select(e => new EventDTO
                {
                    EventDate = e.Date,
                    Location = e.Location,
                    Title = e.Title
                }).Skip(pagination.PageCount * pagination.ItemCount)
              .Take(pagination.ItemCount)
              .ToListAsync();
        }
    }
}
