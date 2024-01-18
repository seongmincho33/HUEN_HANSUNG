using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator.Control
{   
    public class Calculator
    {
        public event EventHandler<CalculationNotificationEventArgs> CalculatorValueChanged;
       
        public CalculatorValue Value { get; set; }
        
        public Calculator() 
        {
            this.Value = new CalculatorValue()
            {
                RealCurrentNumber = 0,
                DisplayCurrentNumber = 0,
                CurrentOperator = OperatorButton.None,
                X1 = null,
                X2 = null
            };

            this.Value.RealCurrentNumber = 0;            
        } 
       
        public void DoSomething(CalculatorButton enButton)
        {
            switch (enButton)
            {
                case CalculatorButton.Zero:
                    this.InputNumber(0);
                    break;
                case CalculatorButton.One:
                    this.InputNumber(1);
                    break;
                case CalculatorButton.Two:
                    this.InputNumber(2);
                    break;
                case CalculatorButton.Three:
                    this.InputNumber(3);
                    break;
                case CalculatorButton.Four:
                    this.InputNumber(4);
                    break;
                case CalculatorButton.Five:
                    this.InputNumber(5);
                    break;
                case CalculatorButton.Six:
                    this.InputNumber(6);
                    break;
                case CalculatorButton.Seven:
                    this.InputNumber(7);
                    break;
                case CalculatorButton.Eight:
                    this.InputNumber(8);
                    break;
                case CalculatorButton.Nine:
                    this.InputNumber(9);
                    break;
                case CalculatorButton.Percentage:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Percentage;
                    break;
                case CalculatorButton.CE:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.CE;
                    break;
                case CalculatorButton.Clear:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Clear;
                    break;
                case CalculatorButton.Back:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Back;
                    break;
                case CalculatorButton.Fraction:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Fraction;
                    break;
                case CalculatorButton.Square:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Square;
                    break;
                case CalculatorButton.Root:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Root;
                    break;
                case CalculatorButton.Divide:
                    this.InputOperator(OperatorButton.Divide);
                    break;
                case CalculatorButton.Multiply:
                    this.InputOperator(OperatorButton.Multiply);
                    break;
                case CalculatorButton.Minus:
                    this.InputOperator(OperatorButton.Minus);
                    break;
                case CalculatorButton.Plus:
                    this.InputOperator(OperatorButton.Plus);                 
                    break;
                case CalculatorButton.Converter:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Converter;
                    break;
                case CalculatorButton.Dot:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Dot;
                    break;
                case CalculatorButton.Equal:
                    this.Value.X1 = this.Value.RealCurrentNumber;
                    this.Value.CurrentOperator = OperatorButton.Equal;
                    break;
            }

            this.NotifyCalculatorChanged();
        }

        private void InputOperator(OperatorButton opbtn)
        {
            if(this.Value.CurrentOperator != OperatorButton.None)
            {
                if (this.Value.RealCurrentNumber == 0)
                {
                    this.Value.CurrentOperator = opbtn;
                }
                else if (opbtn == OperatorButton.Plus)
                {
                    this.Value.X1 += this.Value.RealCurrentNumber;
                    Set();
                }
                else if (opbtn == OperatorButton.Minus)
                {
                    this.Value.X1 -= this.Value.RealCurrentNumber;
                    Set();
                }
                else if (opbtn == OperatorButton.Multiply)
                {
                    this.Value.X1 *= this.Value.RealCurrentNumber;
                    Set();
                }
                else if (opbtn == OperatorButton.Divide)
                {
                    this.Value.X1 /= this.Value.RealCurrentNumber;
                    Set();
                }
                
            }
            else
            {
                this.Value.X1 = this.Value.RealCurrentNumber;
                this.Value.CurrentOperator = opbtn;
                this.Value.RealCurrentNumber = 0;
            }

            void Set()
            {
                this.Value.RealCurrentNumber = this.Value.X1;
                this.Value.DisplayCurrentNumber = this.Value.X1;
                this.Value.CurrentOperator = opbtn;
            }            
        }        

        private void InputNumber(double number)
        {
            this.Value.RealCurrentNumber = this.Value.RealCurrentNumber * 10 + number;
            this.Value.DisplayCurrentNumber = this.Value.RealCurrentNumber;
        }       
      
        public void RemoveLastDigit()
        {
            this.Value.RealCurrentNumber = this.Value.RealCurrentNumber / 10;
            this.Value.DisplayCurrentNumber = this.Value.DisplayCurrentNumber / 10;
        }

        private void NotifyCalculatorChanged()
        {
            CalculationNotificationEventArgs? args = new CalculationNotificationEventArgs(this.Value);
            this.CalculatorValueChanged(this, args);
        }

       
    }

    public class CalculationNotificationEventArgs
    {
        public CalculatorValue CurrentValue { get; set; }

        public CalculationNotificationEventArgs(CalculatorValue val)
        {
            this.CurrentValue = val;
        }
    }
}
