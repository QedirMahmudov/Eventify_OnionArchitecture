using Eventify_OnionArchitecture.Application.Abstractions.Services;
using Eventify_OnionArchitecture.Application.Abstractions.Services.Concrete;
using Eventify_OnionArchitecture.Application.DTOs;
using Eventify_OnionArchitecture.Application.RequestParameters;
using Microsoft.AspNetCore.Mvc;

namespace Eventify_OnionArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly ExportService _exportService;

        public EventsController(IEventService eventService, ExportService exportService)
        {
            _eventService = eventService;
            _exportService = exportService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEvents([FromQuery] Pagination pagination)
        {
            var events = await _eventService.GetAllEventsAsync(pagination);
            return Ok(events);
        }


        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventDTO createEventDTO)
        {
            await _eventService.CreateEventAsync(createEventDTO);
            return Ok();
        }

        [HttpGet("export")]
        public async Task<IActionResult> ExportEvents([FromQuery] Pagination pagination, [FromQuery] string path)
        {
            var events = await _eventService.GetAllEventsAsync(pagination);
            await _exportService.ExportEventsAsync(events, path);
            return Ok();
        }


    }
}
