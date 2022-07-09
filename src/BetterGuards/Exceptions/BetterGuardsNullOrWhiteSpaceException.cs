namespace BetterGuards.Exceptions
{
    public class BetterGuardsNullOrWhiteSpaceException : BetterGuardsException
    {
        public BetterGuardsNullOrWhiteSpaceException()
        {
            throw new BetterGuardsException("String is null or whitespace.");
        }
    }
}