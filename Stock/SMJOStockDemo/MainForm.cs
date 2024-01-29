using StockController;
using StockView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMJOStockDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UC_Stock uC_Stock = new UC_Stock();
            KoreanStockController koreanStockController = new KoreanStockController(uC_Stock);
            koreanStockController.LoadView();
            uC_Stock.Dock = DockStyle.Fill;
            this.Controls.Add(uC_Stock);
        }
    }
}
