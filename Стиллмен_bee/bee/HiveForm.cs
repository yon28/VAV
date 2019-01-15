using System;
using System.Windows.Forms;

namespace bee
{
    public partial class HiveForm : Form
    {
        public HiveForm()
        {
            InitializeComponent();//594
            BackgroundImage = Renderer.ResizeImage(Properties.Resources._5,ClientRectangle.Width, ClientRectangle.Height);
           
        }

        private void The_Hive_Load(object sender, EventArgs e)
        {

        }

        private void HiveForm_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(e.Location.ToString());
        }


    }
}
