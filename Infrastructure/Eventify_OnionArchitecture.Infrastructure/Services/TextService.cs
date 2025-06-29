using Eventify_OnionArchitecture.Application.Abstractions.Services;
using Eventify_OnionArchitecture.Application.DTOs;
using System.Text;

namespace Eventify_OnionArchitecture.Infrastructure.Services
{
    public class TextService : ITextService
    {
        public string FormatTextForEvent(IEnumerable<EventDTO> eventItems)
        {
            if (eventItems is null)
                throw new ArgumentNullException(nameof(eventItems));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in eventItems)
            {
                if (eventItems is not null)
                    stringBuilder.AppendLine($"Event: {item.Title} - Location: {item.Location.City} - Date:{item.EventDate.ToString("HH:mm - dd/MM/yyyy")}");
            }

            return stringBuilder.ToString().TrimEnd();

        }
    }
}
