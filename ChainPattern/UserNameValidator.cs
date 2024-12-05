namespace ChainPattern
{
    public class UserNameValidator : Validator
    {
        public override bool ValidateInput(RegistrationForm form)
        {
            if (form.Username.Length < 5)
            {
                Console.WriteLine("User name cannot be less than 5 char");
                return false;
            }

            return true;
        }
    }
}