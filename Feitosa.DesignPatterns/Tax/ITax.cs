using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public interface ITax
    {
        double Calculate(Budget budget);
    }
}
