using System;
using System.Windows.Forms;
namespace Party_Planer
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthDayParty birthDayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked,fancyBox.Checked);
            DisplayDinnerPartyCost();
            birthDayParty = new BirthDayParty((int)numericUpDown2.Value, healthyBox2.Checked, fancyBox2.Checked,cakeWriting.Text);
            DisplayBirthDayPartyCost();

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            labelCost.Text = Cost.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthDayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthDayPartyCost();
        }

        private void fancyBox2_CheckedChanged(object sender, EventArgs e)
        {
            birthDayParty.CalculateCostOfDecorations(fancyBox2.Checked);
            DisplayBirthDayPartyCost();
        }

        private void healthyBox2_CheckedChanged(object sender, EventArgs e)
        {
            birthDayParty.SetHealthyOption(healthyBox2.Checked);
            DisplayBirthDayPartyCost();
        }

        private void DisplayBirthDayPartyCost()
        {
            cakeWriting.Text = birthDayParty.CakeWriting;
            decimal Cost2 = birthDayParty.CalculateCost(healthyBox2.Checked);
            labelCost2.Text = Cost2.ToString("c");
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthDayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthDayPartyCost();
        }

    }
}
