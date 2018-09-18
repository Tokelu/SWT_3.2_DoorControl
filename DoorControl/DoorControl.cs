using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    class DoorControl
    {

        static void Main(string[] args)
        {

        }


        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;
        private IDoor _door;
        private IAlarm _alarm;


        public DoorControl(IEntryNotification entryNotification, IUserValidation userValidation, IDoor door, IAlarm alarm)
        {
            this._entryNotification = entryNotification;
            this._userValidation = userValidation;
            this._door = door;
            this._alarm = alarm;
        }

        public void RequestEntry(int id)
        {
            Console.WriteLine($"{ id } has requested access.");
            bool isValidated = _userValidation.ValidateEntryRequest(id);
            Console.WriteLine(isValidated?"ID is valid":"ID is NOT Valid");


        }

        public void DoorOpen()
        {
            Console.WriteLine("Door is Open");
        }

        public void DoorClosed()
        {
            Console.WriteLine("Door is Closed");
        }





    }
}

   

