using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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