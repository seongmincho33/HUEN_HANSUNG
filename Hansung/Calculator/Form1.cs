using Calculator.Control;

namespace Calculator
{
    public partial class Form1 : Form
    {       
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            this.SetControls();
        }

        private void SetControls()
        {
            UC_NumberPad NumberPad = new UC_NumberPad();
            UC_Monitor Monitor = new UC_Monitor();

            Monitor.Dock = DockStyle.Fill;
            this.panelTop.Controls.Add(Monitor);

            NumberPad.Dock = DockStyle.Fill;
            this.panelFill.Controls.Add(NumberPad);

            Calculator calculator = new Calculator(NumberPad, Monitor);
        }
    }
}
