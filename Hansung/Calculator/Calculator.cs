using Calculator.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        private UC_NumberPad NumberPad { get; set; }

        private UC_Monitor Monitor { get; set; }

        private double X1 { get; set; }

        private double X2 { get; set; }

        private double Y
        {
            get
            {
                return this.Calculate(X1, X2);
            }
        }        

        public Calculator(UC_NumberPad numberPad, UC_Monitor monitor) 
        { 
            this.NumberPad = numberPad;
            this.Monitor = monitor;

            this.NumberPad.NumberPadChanged += NumberPad_NumberPadChanged;
        }

        private void NumberPad_NumberPadChanged(object? sender, NumberPadEventArgs e)
        {
            switch(e.CurrentButton)
            {
                case CalculatorButton.Zero:
                    break;
                case CalculatorButton.One:
                    break;
                case CalculatorButton.Two:
                    break;
                case CalculatorButton.Three:
                    break;
                case CalculatorButton.Four:
                    break;
                case CalculatorButton.Five:
                    break;
                case CalculatorButton.Six:
                    break;
                case CalculatorButton.Seven:
                    break;
                case CalculatorButton.Eight:
                    break;
                case CalculatorButton.Nine:
                    break;
                case CalculatorButton.Percentage:
                    break;
                case CalculatorButton.CE:
                    break;
                case CalculatorButton.Clear:
                    break;
                case CalculatorButton.Back:
                    break;
                case CalculatorButton.Fraction:
                    break;
                case CalculatorButton.Square:
                    break;
                case CalculatorButton.Root:
                    break;
                case CalculatorButton.Divide:
                    break;
                case CalculatorButton.Multiply:
                    break;
                case CalculatorButton.Minus:
                    break;
                case CalculatorButton.Plus:
                    break;
                case CalculatorButton.Converter:
                    break;
                case CalculatorButton.Dot:
                    break;
                case CalculatorButton.Equal:
                    break;
            }
        }

        private double Calculate(double x1, double x2)
        {


            return x1 * x2;
        }
    }
}
