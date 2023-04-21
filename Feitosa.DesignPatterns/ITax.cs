using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns
{
    public interface ITax
    {
        double Calculate(Budget budget);
    }
}
