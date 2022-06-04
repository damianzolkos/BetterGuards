namespace BetterGuards;

public class Validate : IValidateClause
{
    public static IValidateClause For { get; } = new Validate();
}
