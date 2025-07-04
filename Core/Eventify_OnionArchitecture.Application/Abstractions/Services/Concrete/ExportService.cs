﻿using Eventify_OnionArchitecture.Application.DTOs;

namespace Eventify_OnionArchitecture.Application.Abstractions.Services.Concrete
{
    public class ExportService
    {
        private readonly ITextService _textService;
        private readonly IFileService _fileService;

        public ExportService(ITextService textService, IFileService fileService)
        {
            _textService = textService;
            _fileService = fileService;
        }

        public async Task ExportEventsAsync(IEnumerable<EventDTO> eventItems, string path)
        {
            var formattedText = _textService.FormatTextForEvent(eventItems);
            await _fileService.SaveTextAsync(formattedText, path);
        }
    }
}
