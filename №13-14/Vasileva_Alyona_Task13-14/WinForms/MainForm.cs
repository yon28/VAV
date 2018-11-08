using Department.BLL;
using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        private enum EmployeeSortMode { Asceding, Desceding };
        private enum RewardSortMode { Asceding, Desceding };
        private readonly EmployeesBL employees;
        private readonly RewardsBL rewards;
        private EmployeeSortMode sortMode = EmployeeSortMode.Asceding;
        private RewardSortMode sortMode1 = RewardSortMode.Asceding;

        public MainForm()
        {
            employees = new EmployeesBL();
            rewards = new RewardsBL();
            InitializeComponent();
            this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          // CreateEmployeeGrid();
          // employees.SortEmployeesByFullNameAsc();
         // employees.SortEmployeesByFullNameDesc();
         //   DisplayEmployee();

          ctlEmployees.DataSource = employees.InitList();
            dgvRewards.DataSource = rewards.InitList();

        }

        private void CreateEmployeeGrid()
        {
            ctlEmployees.AutoGenerateColumns = false;

            ctlEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "LastName",
                HeaderText = "Фамилия",
                Width = 200
            });

            ctlEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "FirstName",
                HeaderText = "Имя",
                Width = 70
            });

            ctlEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Birth",
                HeaderText = "Год рождения",
                Width = 70
            });

            ctlEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Age",
                HeaderText = "Возраст",
                Width = 70
            });
        }

        private void DisplayEmployee()
        {
            // Data binding
            ctlEmployees.DataSource = null;
            ctlEmployees.DataSource = employees.GetList();

            /*
                        ctlEmployees.Items.Clear();

                        for (int i = 0; i < employees.Count; i++)
                        {
                            Employee employee = employees[i];

                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = (i + 1).ToString(); // 1-я колонка

                            lvi.SubItems.Add(employee.FullName); 
                            lvi.SubItems.Add(employee.Year.ToString()); 
                            lvi.SubItems.Add(employee.PassNumber.ToString());

                            ctlEmployee.Items.Add(lvi);
                        }
            */

            //ctlEmployeeCount.Text = String.Format(employees.Count);
            //ctlProgressBar.Value = employees.Count;
        }

        private void Employees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditSelectedEmployee();
        }

        private void FileRegister_Click(object sender, EventArgs e)
        {
            RegisterNewEmployee();
        }

        private void FileEdit_Click(object sender, EventArgs e)
        {
            EditSelectedEmployee();
        }

        private void FileRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedEmployee();
        }

        private void ContextRegister_Click(object sender, EventArgs e)
        {
            RegisterNewEmployee();
        }

        private void ContextEdit_Click(object sender, EventArgs e)
        {
            EditSelectedEmployee();
        }

        private void ContextRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedEmployee();
        }

        private void RegisterNewEmployee()
        {
            EmployeeForm form = new EmployeeForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                employees.Add(form.LastName, form.FirstName, form.Birth, "");///////
                DisplayEmployee();
            }
        }

        private void EditSelectedEmployee()
        {
            if (ctlEmployees.SelectedCells.Count > 0)
            {
                Employee employee = (Employee)ctlEmployees.SelectedCells[0].OwningRow.DataBoundItem;
                EmployeeForm form = new EmployeeForm(employee);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    employee.LastName = form.LastName;
                    employee.FirstName = form.FirstName;
                    employee.Birth = form.Birth;
                    DisplayEmployee();
                }
            }
        }

        private void RemoveSelectedEmployee()
        {
            if (ctlEmployees.SelectedCells.Count > 0)
            {
                Employee employee = (Employee)ctlEmployees.SelectedCells[0].OwningRow.DataBoundItem;
                employees.Remove(employee);
                DisplayEmployee();
            }
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            //splashForm.Close();
            //splashTimer.Enabled = false;

            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
        }
        private void Employees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 1)
            {
                if (sortMode == EmployeeSortMode.Asceding)
                {
                    employees.SortEmployeesByFullNameDesc();
                    sortMode = EmployeeSortMode.Desceding;
                }
                else
                {
                    employees.SortEmployeesByFullNameAsc();
                    sortMode = EmployeeSortMode.Asceding;
                }
                DisplayEmployee();
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.jpg";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //
        private void DisplayReward()
        {
            dgvRewards.DataSource = null;
            dgvRewards.DataSource = rewards.GetList();
        }

        private void Rewards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditSelectedReward();
        }
        private void FileRewardRegister_Click(object sender, EventArgs e)
        {
            RegisterNewReward();
        }

        private void FileRewardEdit_Click(object sender, EventArgs e)
        {
            EditSelectedReward();
        }
        private void ctlFileRewardRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedReward();
        }

        /*       private void ContextRewardRegister_Click(object sender, EventArgs e)
               {
                   RegisterNewReward();
               }
               private void ContextRewardEdit_Click(object sender, EventArgs e)
               {
                   EditSelectedReward();
               }

               private void ContextRewardRemove_Click(object sender, EventArgs e)
               {
                   RemoveSelectedReward();
               }
               */
        private void RegisterNewReward()
        {
            RewardForm form = new RewardForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                rewards.Add(form.Title, form.Description);
                DisplayReward();
            }
        }

        private void EditSelectedReward()
        {
            if (dgvRewards.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;

                RewardForm form = new RewardForm(reward);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    reward.Title = form.txtTitle.Text;
                    reward.Description = form.txtDescription.Text;
                    DisplayReward();
                }
            }
        }

        private void RemoveSelectedReward()
        {
            if (dgvRewards.SelectedCells.Count > 0)
            {
                Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;
                rewards.Remove(reward);
                DisplayReward();
            }
        }

        private void SplashTimerR_Tick(object sender, EventArgs e)
        {
            //splashForm.Close();
            //splashTimer.Enabled = false;
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
        }

        private void Rewards_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 1)
            {
                if (sortMode1 == RewardSortMode.Asceding)
                {
                    rewards.SortRewardsByFullNameDesc();
                    sortMode1 = RewardSortMode.Desceding;
                }
                else
                {
                    rewards.SortRewardsByFullNameAsc();
                    sortMode1 = RewardSortMode.Asceding;
                }

                DisplayReward();
            }
        }

        private void BrowseR_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileRewardDialog = new OpenFileDialog();
            openFileRewardDialog.Filter = "*.jpg";

            if (openFileRewardDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileRewardName = openFileRewardDialog.FileName;
            }
        }

        private void ctlEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

