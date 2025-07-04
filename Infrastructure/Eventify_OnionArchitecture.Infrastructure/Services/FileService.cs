﻿using Eventify_OnionArchitecture.Application.Abstractions.Services;

namespace Eventify_OnionArchitecture.Infrastructure.Services
{
    public class FileService : IFileService
    {
        public async Task SaveTextAsync(string text, string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                    throw new ArgumentNullException(nameof(path));
                await File.WriteAllTextAsync(path, text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex}");
            }
        }
    }
}
