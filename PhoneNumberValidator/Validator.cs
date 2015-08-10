namespace PhoneNumberValidator
{
    public class Validator
    {
        public bool IsNumberValid(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                var c = phoneNumber[i];
                if (i == 0 && c == '+')
                {
                    continue;
                }
                if (!char.IsDigit(c) && c != '-')
                {
                    return false;
                }
            }
            return true;
        }
    }
}