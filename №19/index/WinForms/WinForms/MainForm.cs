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
        private readonly EmployeesBL employees;
        private readonly RewardsBL rewards;

        private enum SortMode { Asceding, Desceding };
        private SortMode sortMode = SortMode.Asceding;
        private SortMode sortModeRewards = SortMode.Asceding;

        private void Employees_ColumnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (sortMode == SortMode.Asceding)
                {
                    employees.SortByLastName("descending");
                    sortMode = SortMode.Desceding;
                }
                else
                {
                    employees.SortByLastName("ascending");
                    sortMode = SortMode.Asceding;
                }
                DisplayEmployee();
            }
        }

        private void Rewards_ColumnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortModeRewards == SortMode.Asceding)
            {
                rewards.SortRewards("descending");
                sortModeRewards = SortMode.Desceding;
            }
            else
            {
                rewards.SortRewards("ascending");
                sortModeRewards = SortMode.Asceding;
            }
            DisplayReward();

        }

        public MainForm()
        {
            employees = new EmployeesBL();
            rewards = new RewardsBL();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            employees.SortByLastName("ascending");
            dgvEmployees.DataSource = employees.InitList();

            dgvRewards.DataSource = rewards.InitList();
            CreateEmployeeGrid();
            CreateRewardGrid();
        }

        private void CreateEmployeeGrid()
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.Columns.Clear();
            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "LastName",
                HeaderText = "�������",
                Width = 100
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "FirstName",
                HeaderText = "���",
                Width = 100
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Birth",
                HeaderText = "���� ��������",
                Width = 120
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Age",
                HeaderText = "�������",
                Width = 70
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "RewardsToString",
                HeaderText = "�������",
                Width = 200
            });
        }

        private void DisplayEmployee()
        {
            dgvEmployees.DataSource = null;
            var employeesList = employees.GetList();
            dgvEmployees.DataSource = employeesList;
            CreateEmployeeGrid();

        }
        private void CreateRewardGrid()
        {
            dgvRewards.AutoGenerateColumns = false;

            dgvRewards.Columns.Clear();
            dgvRewards.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Title",
                HeaderText = "��� �������",
                Width = 170
            });

            dgvRewards.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Description",
                HeaderText = "��������",
                Width = 370
            });
        }
        private void DisplayReward()
        {
            dgvRewards.DataSource = null;
            dgvRewards.DataSource = rewards.GetList();
            CreateRewardGrid();
        }

        private void dgvEmployees_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctlContextMenu.Show(dgvEmployees, new Point(e.X, e.Y));
            }
        }
        private void dgvRewards_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ctlContextMenuReward.Show(dgvRewards, new Point(e.X, e.Y));
            }
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
        private void ContextRegisterReward_Click(object sender, EventArgs e)
        {
            RegisterNewReward();
        }
        private void ContextEditReward_Click(object sender, EventArgs e)
        {
            EditSelectedReward();
        }
        private void ContextRemoveReward_Click(object sender, EventArgs e)
        {
            RemoveSelectedReward();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void RegisterNewEmployee()
        {
            EmployeeForm form = new EmployeeForm(null, rewards);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                employees.Add(form.LastName, form.FirstName, form.Birth, Checked(form));
                DisplayEmployee();
            }
        }

        private List<Reward> Checked(EmployeeForm form)
        {
            var allRewards = rewards.GetList();//
            var rewards_ = new List<Reward> { };
            if (form.chRewards.CheckedItems.Count != 0)
            {
				for (int i = 0; i < form.chRewards.CheckedItems.Count; i++)
                {
					string checkedItem = (string)form.chRewards.CheckedItems[i];
					Reward reward = rewards.GetList().FirstOrDefault(it => it.Title == checkedItem);
                    rewards_.Add(reward);
                }
            }
            return rewards_;
        }

        private void EditSelectedEmployee()
        {
            if (dgvEmployees.SelectedCells.Count > 0)
            {
                Employee employee = (Employee)dgvEmployees.SelectedCells[0].OwningRow.DataBoundItem;
                EmployeeForm form = new EmployeeForm(employee, rewards);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    employee.LastName = form.LastName;
                    employee.FirstName = form.FirstName;
                    employee.Birth = form.Birth;
                    employee.Rewards = Checked(form);
                    employees.Edit(employee);
                    DisplayEmployee();
                }
            }
        }

        private void RemoveSelectedEmployee()
        {
            if (dgvEmployees.SelectedCells.Count > 0)
            {
                DelEmployeeForm form = new DelEmployeeForm();
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Employee employee = (Employee)dgvEmployees.SelectedCells[0].OwningRow.DataBoundItem;
                    employees.Remove(employee);
                    DisplayEmployee();
                }
            }
        }

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
                    rewards.Edit(reward);
                    DisplayReward();
 			    DisplayEmployee();

                }
            }
        }

        private void RemoveSelectedReward()
        {
            if (dgvRewards.SelectedCells.Count > 0)
            {
                DelReward form = new DelReward();
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;
                    string del = reward.Title.ToString();
                    for (int i = 0; i < dgvEmployees.RowCount; i++)
                    {


                        if (dgvEmployees[4, i].Value != null)
                        {
                            if (dgvEmployees[4, i].Value.ToString().Contains(del))
                            {
                                Employee employee = (Employee)dgvEmployees[4, i].OwningRow.DataBoundItem;
                                // employee.Rewards = employee.Rewards.Replace(del, "");
                                employee.Rewards.Remove(reward);
                                DisplayEmployee();
                            }

                        }
                        rewards.Remove(reward);
                        DisplayReward();
                        DisplayEmployee();
                    }
                }
            }

        }
    }
}

