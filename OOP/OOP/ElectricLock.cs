using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ElectricLock : Lock
    {
        
        private void InserCard()
        {
            Console.WriteLine("Insert card");
        }
        public new void Open()
        {
            InserCard();
            Console.WriteLine("Opened by electric card.");
        }
    }
}
