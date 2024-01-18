using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Control
{
    public partial class UC_Monitor : UserControl
    {
        private CalculatorValue _calcval;
        public CalculatorValue CalculatorValue
        {
            get { return _calcval; }
            set
            {
                _calcval = value;
                this.SetLabel1Text();
                this.SetLabel2Text();
            }
        }

        public UC_Monitor()
        {
            InitializeComponent();
            this.label1.Text = "0";
            this.label2.Text = "";
        }        

        public void SetLabel1Text()
        {
            this.label1.Text = this.CalculatorValue.DisplayCurrentNumber.ToString();
        }

        public void SetLabel2Text()
        {
            var x1 = this.CalculatorValue.X1.ToString();
            var op = this.CalculatorValue.CurrentOperator == OperatorButton.None ? "" : this.CalculatorValue.CurrentOperator.ToString();

            this.label2.Text = $"{x1} {op}";
        }
    }
}
