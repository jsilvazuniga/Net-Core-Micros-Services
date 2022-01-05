using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public interface ICommandDataClients
    {
        Task SendPlatformToCommand(PlatformReadDto plaform);
    }
}