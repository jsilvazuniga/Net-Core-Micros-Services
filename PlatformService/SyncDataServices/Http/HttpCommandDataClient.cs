using System.Text.Json;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
   public class HttpCommandDataClient : ICommandDataClients
    {
            private readonly HttpClient _httpClient;
            private readonly IConfiguration _configuration;
        public  HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            if (httpClient is null)
            {
                throw new ArgumentNullException(nameof(httpClient));
            }

            _httpClient = httpClient;
            _configuration = configuration;

        }

        public async Task SendPlatformToCommand(PlatformReadDto plaform)
        {
           var httpContent = new StringContent(
               JsonSerializer.Serialize(plaform),
               System.Text.Encoding.UTF8,
               "application/json"
           );

           var response = await _httpClient.PostAsync($"{_configuration["CommandService"]}", httpContent);

            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("--> Post to command service was OK");
            }else {
                Console.WriteLine("--> Post to command service was not OK");
            }

        }
    }
}