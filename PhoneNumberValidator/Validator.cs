namespace PhoneNumberValidator
{
    public class Validator
    {
        public bool IsNumberValid(string phoneNumber)
        {
            foreach (var c in phoneNumber)
            {
                if (!IsValidPhoneNumberCharacter(c))
                {
                    continue;
                }
                return false;
            }
            return true;
        }

        private static bool IsValidPhoneNumberCharacter(char c)
        {
            return !char.IsDigit(c) && c != '-' && c != '+';
        }
    }
}