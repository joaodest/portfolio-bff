namespace portfolio_bff.Exceptions
{
    public class InvalidUserException : Exception
    {
        private const string DefaultErrorMessage = "Não foi possível encontrar o usuário.";

        public InvalidUserException(string message = DefaultErrorMessage) 
            : base(message) { }

    }
}
