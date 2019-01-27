using System;
using System.Drawing;
using System.Windows.Forms;

namespace bee
{
    public partial class HiveForm : Form
    { 
        public RendererForWinForm Renderer { get; set; }
        public HiveForm()
        {
            InitializeComponent();//594          
        }

        private void The_Hive_Load(object sender, EventArgs e)
        {

        }

        private void HiveForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void HiveForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Renderer.PaintHive(g);
        }
    }
}
