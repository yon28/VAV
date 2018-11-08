using Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinForms
{
	public partial class EmployeeForm : Form
	{
		private string lastName;
        private string firstName;
        private int birth;
		private int idNumber;

		private bool createNew = true;


		#region Properties

		public string LastName
		{
			get
			{
				return lastName;
			}
		}
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }
        public int Birth
		{
			get
			{
				return birth;
			}
		}

		public int IDNumber
		{
			get
			{
				return idNumber;
			}
		}

		#endregion

		public EmployeeForm()
		{
			InitializeComponent();
		}

		public EmployeeForm(Employee employee)
		{
			InitializeComponent();
            this.lastName = employee.LastName;
            this.firstName = employee.FirstName;
			this.birth = employee.Birth;
			this.idNumber = employee.IDNumber;
            createNew = false;
		}

		private void Form_Load(object sender, EventArgs e)
		{
			txtLastName.Text = lastName;
            txtFirstName.Text = firstName;
			txtBirst.Text = birth.ToString();

			// cbYear.SelectedIndex = 0;

			if (createNew == true)
			{
				this.Text = "Регистрация нового пользователя";
				btnOK.Text = "Создать";
			}
			else
			{
				this.Text = "Редактирование записи о пользователя";
				btnOK.Text = "Обновить";
			}
		}

		private void OK_Click(object sender, EventArgs e)
		{
      /*      lastName = txtLastName.Text;
            firstName = txtFirstName.Text;
            idNumber = Int32.Parse(txtIDNumber.Text);
            txtBirst.Text = birth.ToString();*/

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

    		private void Birth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string input = txtBirst.Text.Trim();

			int result;
			if (Int32.TryParse(input, out result) == false)
			{
				errorProvider.SetError(txtBirst, "Некорректное значение!");
				e.Cancel = true;
			}
			else
			{
				errorProvider.SetError(txtBirst, String.Empty);
				e.Cancel = false;
			}
		}

		private void Birth_Validated(object sender, EventArgs e)
		{
			birth = Int32.Parse(txtBirst.Text);
		}

    }
}
