﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Feitosa.DesignPatterns.Tax
{
    public class ICMS : ITax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1d;
        }
    }
}