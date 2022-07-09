namespace BetterGuards.Exceptions
{
    public class BetterGuardsNullException : BetterGuardsException
    {
        public BetterGuardsNullException()
        {
            throw new BetterGuardsException("Object is null.");
        }
    }
}