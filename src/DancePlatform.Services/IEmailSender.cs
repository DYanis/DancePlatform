using System.Threading.Tasks;

namespace DancePlatform.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
