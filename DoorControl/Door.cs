using System;

namespace DoorControl
{
    class Door : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Lock disengaged, you can open ze door");
        }

        public void Close()
        {
            Console.WriteLine("Door closed, Lock engaging");
        }
    }




}

   

