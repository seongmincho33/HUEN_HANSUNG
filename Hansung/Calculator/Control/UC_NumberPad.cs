using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Control
{
    public partial class UC_NumberPad : UserControl
    {
        public CalculatorButton CurrentButton { get; set; }

        public event EventHandler<NumberPadEventArgs> NumberPadChanged;

        public UC_NumberPad()
        {
            InitializeComponent();
            this.btn0.Click += Btn_Click;
            this.btn1.Click += Btn_Click;
            this.btn2.Click += Btn_Click;
            this.btn3.Click += Btn_Click;
            this.btn4.Click += Btn_Click;
            this.btn5.Click += Btn_Click;
            this.btn6.Click += Btn_Click;
            this.btn7.Click += Btn_Click;
            this.btn8.Click += Btn_Click;
            this.btn9.Click += Btn_Click;

            this.btnPercentage.Click += Btn_Click;
            this.btnCE.Click += Btn_Click;
            this.btnClear.Click += Btn_Click;
            this.btnBack.Click += Btn_Click;
            this.btnFraction.Click += Btn_Click;
            this.btnSquare.Click += Btn_Click;
            this.btnSquareRoot.Click += Btn_Click;
            this.btnDivide.Click += Btn_Click;
            this.btnMultiply.Click += Btn_Click;
            this.btnMinus.Click += Btn_Click;
            this.btnPlus.Click += Btn_Click;
            this.btnOperationConverter.Click += Btn_Click;
            this.btnDot.Click += Btn_Click;
            this.btnEqual.Click += Btn_Click;

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == "0") { this.CurrentButton = CalculatorButton.Zero; }
            else if (btn.Text == "1") { this.CurrentButton = CalculatorButton.One; }
            else if (btn.Text == "2") { this.CurrentButton = CalculatorButton.Two; }
            else if (btn.Text == "3") { this.CurrentButton = CalculatorButton.Three; }
            else if (btn.Text == "4") { this.CurrentButton = CalculatorButton.Four; }
            else if (btn.Text == "5") { this.CurrentButton = CalculatorButton.Five; }
            else if (btn.Text == "6") { this.CurrentButton = CalculatorButton.Six; }
            else if (btn.Text == "7") { this.CurrentButton = CalculatorButton.Seven; }
            else if (btn.Text == "8") { this.CurrentButton = CalculatorButton.Eight; }
            else if (btn.Text == "9") { this.CurrentButton = CalculatorButton.Nine; }

            else if (btn.Text == "%") { this.CurrentButton = CalculatorButton.Percentage; }
            else if (btn.Text == "CE") { this.CurrentButton = CalculatorButton.CE; }
            else if (btn.Text == "C") { this.CurrentButton = CalculatorButton.Clear; }
            else if (btn.Text == "<") { this.CurrentButton = CalculatorButton.Back; }
            else if (btn.Text == "1/x") { this.CurrentButton = CalculatorButton.Fraction; }
            else if (btn.Text == "x^2") { this.CurrentButton = CalculatorButton.Square; }
            else if (btn.Text == "vx") { this.CurrentButton = CalculatorButton.Root; }
            else if (btn.Text == "/") { this.CurrentButton = CalculatorButton.Divide; }
            else if (btn.Text == "x") { this.CurrentButton = CalculatorButton.Multiply; }
            else if (btn.Text == "-") { this.CurrentButton = CalculatorButton.Minus; }
            else if (btn.Text == "+") { this.CurrentButton = CalculatorButton.Plus; }
            else if (btn.Text == "+/-") { this.CurrentButton = CalculatorButton.Converter; }
            else if (btn.Text == ".") { this.CurrentButton = CalculatorButton.Dot; }
            else if (btn.Text == "=") { this.CurrentButton = CalculatorButton.Equal; }

            NumberPadEventArgs? arg = new NumberPadEventArgs(this.CurrentButton);

            this.NumberPadChanged(this, arg);
        }
    }

    public class NumberPadEventArgs
    {
        public CalculatorButton CurrentButton { get; set; }

        public NumberPadEventArgs(CalculatorButton currentButton)
        {
            this.CurrentButton = currentButton;
        }
    }
}
