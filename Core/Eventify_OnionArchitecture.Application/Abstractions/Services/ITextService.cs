using Eventify_OnionArchitecture.Application.DTOs;

namespace Eventify_OnionArchitecture.Application.Abstractions.Services
{
    public interface ITextService
    {
        string FormatTextForEvent(IEnumerable<EventDTO> eventItems);
    }
}
