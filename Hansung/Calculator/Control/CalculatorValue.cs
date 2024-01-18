﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Control
{
    public class CalculatorValue
    {
        public double? RealCurrentNumber { get; set; }

        public double? DisplayCurrentNumber { get; set; }

        public OperatorButton CurrentOperator { get; set; }

        public double? X1 { get; set; }

        public double? X2 { get; set; }
    }
}
