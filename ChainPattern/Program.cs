using ChainPattern;

var form = new RegistrationForm
{
    Username = "John a",
    Email = "john.doe@example.com",
    Password = "Password123!",
    Age = 17
};

var AgeValidator = new AgeValidator();
var emailValidator = new EmailValidator();
var passwordValidator = new PasswordValidator();
var usernameValidator = new UserNameValidator();

usernameValidator.SetNext(emailValidator).SetNext(passwordValidator).SetNext(AgeValidator);

if (usernameValidator.Validate(form))
{
    Console.WriteLine("Valid form");

}