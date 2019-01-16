using System;
using System.Windows.Forms;
using System.Drawing;

namespace bee
{
    public partial class FieldForm : Form
    {
        public FieldForm()
        {
            InitializeComponent();

        }

        private void FieldForm_Load(object sender, EventArgs e)
        {

        }

        private void FieldForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }
    }
}
