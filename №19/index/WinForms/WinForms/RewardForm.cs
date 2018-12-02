using Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinForms
{
    public partial class RewardForm : Form
    {
        private string title;
        private string description;
        private int id;

        private bool createNew = true;


        #region Properties

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
        }

        #endregion

        public RewardForm()
        {
            InitializeComponent();
        }

        public RewardForm(Reward Reward)
        {
            InitializeComponent();

            this.title = Reward.Title;
            this.description = Reward.Description;
            this.id = Reward.ID;

            createNew = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            txtTitle.Text = title;
            txtDescription.Text = description;
            // RTitle.SelectedIndex = 0;

            if (createNew == true)
            {
                this.Text = "Регистрация новой награды";
                btnOK.Text = "Создать";
            }
            else
            {
                this.Text = "Редактирование записи о награде";
                btnOK.Text = "Обновить";
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            description = txtDescription.Text;

            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void Description_Validating(object sender, CancelEventArgs e)
        {
            string input = txtDescription.Text.Trim();

            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(txtDescription, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtDescription, String.Empty);
                e.Cancel = false;
            }
        }

        private void Description_Validated(object sender, EventArgs e)
        {
            description = txtDescription.Text.Trim();
        }

        private void Title_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string input = txtTitle.Text.Trim();

            int result;
            if (Int32.TryParse(input, out result) == false)
            {
                errorProvider.SetError(txtTitle, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitle, String.Empty);
                e.Cancel = false;
            }
        }

        private void Title_Validated(object sender, EventArgs e)
        {
            title = txtTitle.Text;
        }

    }
}
