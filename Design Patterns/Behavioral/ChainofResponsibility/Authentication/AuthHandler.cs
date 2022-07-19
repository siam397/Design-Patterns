namespace Design_Patterns.Behavioral.ChainofResponsibility.Authentication
{
    public abstract class AuthHandler
    {
        public string? _dummyCorrectUsername;
        public string? _dummyCorrectPassword;
        public AuthHandler _nextHandler;

        public AuthHandler()
        {
            _dummyCorrectUsername = "Himel Kabir";
            _dummyCorrectPassword = "FAHIMMIA";
        }

        public static AuthHandler GetAuthConfig()
        {
            AuthHandler validateUsername = new ValidateUsername();
            validateUsername.SetNextHandler(new PasswordHandler());
            return validateUsername;
        }

        public void SetNextHandler(AuthHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Handle(string username, string password);

        public void GoToNextHandler(string username,string password)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(username, password);
            }
        }
    }
}
