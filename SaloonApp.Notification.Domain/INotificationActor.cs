using SaloonApp.Email.Domain.Models;
using SaloonApp.UserDom.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaloonApp.Notification.Domain
{
    public interface INotificationActor
    {
        Task CreateConfirmationEmailAsync(User user);
        Task CreateChangePasswordEmailAsync(User user);
    }
}
