using PlannerView.Controller.Frame;

namespace PlannerView
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            
            this.Load += MainFrame_Load;
        }

        private void MainFrame_Load(object? sender, EventArgs e)
        {
            Renderer.Render("Planner");
        }
    }
}
