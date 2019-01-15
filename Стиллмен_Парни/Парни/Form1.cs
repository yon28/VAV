using System;
using System.Windows.Forms;

namespace Парни
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            joe = new Guy { Name = "Joe", Cash = 50};
            bob = new Guy { Name = "Bob", Cash = 100 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateForm()
        {
            lJoe.Text = joe.Cash.ToString();
            lBob.Text = bob.Cash.ToString();
            lBank.Text = bank.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("B банке нет денег.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          bank+=bob.GiveCash(5);
          UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(10);
            joe.GiveCash(10);
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(5);
            bob.GiveCash(5);
            UpdateForm();
        }
    }
}
