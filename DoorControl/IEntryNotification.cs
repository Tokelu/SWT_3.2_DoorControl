namespace DoorControl
{
    interface IEntryNotification
    {
        void NotifyEntryDenied();
        void NotifyEntryGranted();
    }
}