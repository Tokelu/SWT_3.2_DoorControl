using System;

namespace DoorControl
{
    class Alarm : IAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("!!ALARM!! DOOR HAS BEEN OPENED WITHOUT AUTHENTICATION !!ALARM!!");
        }
    }
}