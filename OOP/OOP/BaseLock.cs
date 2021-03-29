using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BaseLock : Lock
    {
        private void Insertkey()
        {
            Console.WriteLine("Insert key");
        }

        private void Round()
        {
            Console.WriteLine("Round key");
        }

        public override void Open()
        {
            Insertkey();
            Round();
            Console.WriteLine("Opened by key.");
        }
    }
}
