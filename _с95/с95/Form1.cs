using System;

using System.Windows.Forms;

namespace с95
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 2;
            for (int q = 2; q < 32;
            q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                 
                    q = p - q;
               
            }
            Console.Read();
            for (int l = 0; l < 1; l++)
            {

            }
            {

            }
        }
    }
}
