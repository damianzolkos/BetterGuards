using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}