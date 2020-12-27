using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class SoundNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Sound notification: username was changed to {user.Username}");
        }
    }
}
