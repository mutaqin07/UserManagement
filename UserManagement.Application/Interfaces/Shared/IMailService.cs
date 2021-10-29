using UserManagement.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace UserManagement.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}