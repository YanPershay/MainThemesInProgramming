using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class ConsoleNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"ConsoleNotification: username was changed to {user.Username}");
        }
    }
}
