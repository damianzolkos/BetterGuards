namespace BetterGuards;

public class Guard : IClause
{
    public static IClause Against {get; } = new Guard();
}
