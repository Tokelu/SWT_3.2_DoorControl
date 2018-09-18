using System;

namespace DoorControl
{
    class EntryNotification : IEntryNotification
    {
        public void NotifyEntryGranted()
        {
            Console.WriteLine("Access has been granted.");
        }
        public void NotifyEntryDenied()
        {
            Console.WriteLine("Access is Denied!.");
        }
    }
}