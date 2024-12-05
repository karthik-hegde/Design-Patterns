namespace ChainPattern
{
    public abstract class Validator
    {
        private Validator nextHandler;

        public Validator SetNext(Validator handler)
        {
            this.nextHandler = handler;
            return this;
        }

        public Boolean Validate(RegistrationForm form)
        {
            if (!this.ValidateInput(form))
            {
                return false;
            }
            return nextHandler?.Validate(form) ?? true;
        }

        public abstract Boolean ValidateInput(RegistrationForm form);
    }
}