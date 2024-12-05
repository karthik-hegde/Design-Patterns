using System.Text.RegularExpressions;

namespace ChainPattern
{
    public class EmailValidator : Validator
    {
        public override bool ValidateInput(RegistrationForm form)
        {
            if (Regex.IsMatch(form.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                return true;
            }
            Console.WriteLine("Invalid email");
            return false;
        }
    }
}