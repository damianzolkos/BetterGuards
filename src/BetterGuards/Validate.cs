namespace BetterGuards;

public class Validate : IClause
{
    public static IClause For {get; } = new Guard();
}
