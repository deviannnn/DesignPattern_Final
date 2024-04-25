using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore.Screen.Initial
{
    public partial class ActiveForm : Form
    {
        public event EventHandler? BackLoginClicked;

        public ActiveForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackLoginClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
