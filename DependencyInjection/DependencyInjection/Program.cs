using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleNotification = new ConsoleNotification();

            var user1 = new User("Tim");
            user1.ChangeName("Robert", consoleNotification);

            var soundNotification = new SoundNotification();
            user1.ChangeName("Tamir", soundNotification);
        }
    }
}
