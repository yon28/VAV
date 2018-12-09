using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class EmployeeForm : Form
    {
        private string lastName;
        private string firstName;
        private DateTime birth;
        private int idNumber;

        private bool createNew = true;
        public UserViewModel employeemodel;
        private List<Reward> rewards;
        #region Properties

        public string LastName
        {
            get => lastName;
        }
        public string FirstName
        {
            get => firstName;
        }
        public DateTime Birth
        {
            get => birth;
        }
        public int ID
        {
            get => idNumber;
        }

        #endregion

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(Employee employee, RewardsBL rewardsBl)
        {
            InitializeComponent();
            var allRewards = rewardsBl.GetList();
            if (employee != null)
            {
                this.idNumber = employee.ID;
                this.firstName = employee.FirstName;
                this.lastName = employee.LastName;
                this.birth = employee.Birth;
                this.rewards = employee.Rewards;
                createNew = false;
                employeemodel = UserViewModel.GetViewModel(employee, allRewards);
                var rewards = employeemodel.AvailableRewards;
                for (int i = 0; i < rewards.Count; i++)
                {
                    var index = chRewards.Items.Add(rewards[i].Title, rewards[i].Checked);
                }
            }
            else
            {
                for (int i = 0; i < allRewards.Count; i++)
                {
                    var index = chRewards.Items.Add(allRewards[i].Title, false);
                }
            }
        }


        private void Form_Load(object sender, EventArgs e)
        {
            if (createNew == true)
            {
                this.Text = "Регистрация нового пользователя";
                btnOK.Text = "Создать";
            }
            else
            {
                this.Text = "Редактирование записи о пользователе";
                btnOK.Text = "Обновить";
                txtLastName.Text = lastName;
                txtFirstName.Text = firstName;
                dtBirth.Value = birth;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void LastName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtLastName.Text.Trim();

            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(txtLastName, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, String.Empty);
                e.Cancel = false;
            }
        }
        private void LastName_Validated(object sender, EventArgs e)
        {
            lastName = txtLastName.Text.Trim();
        }

        private void FirstName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtFirstName.Text.Trim();
            if (String.IsNullOrEmpty(input) == true)
            {
                errorProvider.SetError(txtFirstName, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, String.Empty);
                e.Cancel = false;
            }
        }
        private void FirstName_Validated(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text.Trim();
        }

        private void Birth_Validating(object sender, CancelEventArgs e)
        {
            DateTime input = dtBirth.Value.Date;
            if (input == null)
            {
                errorProvider.SetError(dtBirth, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtBirth, null);
                e.Cancel = false;
            }
        }
        private void Birth_Validated(object sender, EventArgs e)
        {
            birth = dtBirth.Value.Date;
        }
    }
}
