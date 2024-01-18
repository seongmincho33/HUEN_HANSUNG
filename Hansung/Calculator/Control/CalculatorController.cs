using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Control
{
    public class CalculatorController
    {
        private UC_NumberPad NumberPad { get; set; }

        private UC_Monitor Monitor { get; set; }

        private Calculator Calculator { get; set; }

        public CalculatorController(UC_NumberPad numberPad, UC_Monitor monitor)
        {
            this.NumberPad = numberPad;
            this.Monitor = monitor;
            this.Calculator = new Calculator();

            this.NumberPad.NumberPadChanged += NumberPad_NumberPadChanged;
            this.Calculator.CalculatorValueChanged += Calculator_CalculatorValueChanged;
        }

        private void NumberPad_NumberPadChanged(object? sender, NumberPadEventArgs e)
        {
            this.Calculator.DoSomething(e.CurrentButton);
        }

        private void Calculator_CalculatorValueChanged(object? sender, CalculationNotificationEventArgs e)
        {
            this.Monitor.CalculatorValue = e.CurrentValue;
        }

        
    }
}
