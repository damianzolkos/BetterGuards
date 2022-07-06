namespace BetterGuards;

public class Guard : IGuardClause
{
    public static IGuardClause Against { get; } = new Guard();
}