using BetterGuards.Exceptions;

namespace BetterGuards.Extensions
{
    public static class GuardExtensions
    {
        public static void Null<T>(this IGuardClause clause, T value)
        {
            if (value is null)
            {
                throw new BetterGuardsNullException();
            }
        }

        public static void NullOrWhiteSpace(this IGuardClause clause, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new BetterGuardsNullOrWhiteSpaceException();
            }
        }
    }
}