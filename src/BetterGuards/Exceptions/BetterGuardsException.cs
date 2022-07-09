namespace BetterGuards.Exceptions
{
    public class BetterGuardsException : Exception
    {
        private const string GenericMessage = "Some BetterGuards exception was thrown.";

        public BetterGuardsException() : base()
        {
            throw new BetterGuardsException(GenericMessage);
        }

        public BetterGuardsException(string message) : base(message)
        {
            throw new BetterGuardsException(GenericMessage);
        }
    }
}