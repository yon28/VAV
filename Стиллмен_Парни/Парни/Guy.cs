using System.Windows.Forms;

namespace Парни
{
    class Guy
    {
        public string Name;
        public int Cash;

        // Поле Name — это строка, с именем парня(Joe), а поле Cash целое число, указываюш,ее на количество наличных денег.
        //     сумма должна быть больше нуля.

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"У меня не хватает денег {amount},  говорит {Name}.");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"Мне не нужно {amount}, говорит {Name}");
                return 0;
            }
        }
    }
}
