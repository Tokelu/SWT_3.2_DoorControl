namespace DoorControl
{
    class UserValidation : IUserValidation
    {
        public bool ValidateEntryRequest(int id)
        {
            bool IsValid = id > 0 ? true : false;
            return IsValid;
        }



    }
}