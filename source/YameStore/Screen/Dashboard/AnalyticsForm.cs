using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore.Screen.Dashboard
{
    public partial class AnalyticsForm : Form
    {
        public AnalyticsForm()
        {
            InitializeComponent();
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };

            totalSalesChart.Plot.Add.Scatter(dataX, dataY);
            totalOrdersChart.Plot.Add.Scatter(dataX, dataY);
            topProductsChart.Plot.Add.Scatter(dataX, dataY);
            tempChart.Plot.Add.Scatter(dataX, dataY);

            totalSalesChart.Refresh();
            totalOrdersChart.Refresh();
            topProductsChart.Refresh();
            tempChart.Refresh();
        }
    }
}
