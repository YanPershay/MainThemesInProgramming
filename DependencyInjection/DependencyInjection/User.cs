using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class User
    {
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }

        public void ChangeName(string newUsername, INotificationService notificationService)
        {
            Username = newUsername;
            notificationService.NotifyUsernameChanged(this);
        }
    }
}
