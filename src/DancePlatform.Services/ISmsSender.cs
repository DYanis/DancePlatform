using System.Threading.Tasks;

namespace DancePlatform.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
