﻿using Department.BLL;
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            employees.SortEmployeesByLastNameAsc();
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
                HeaderText = "Фамилия",
                Width = 100
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "FirstName",
                HeaderText = "Имя",
                Width = 100
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Birth",
                HeaderText = "Дата рождения",
                Width = 120
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Age",
                HeaderText = "Возраст",
                Width = 70
            });

            dgvEmployees.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Rewards",
                HeaderText = "Награды",
                Width = 200
            });
        }

        private void DisplayEmployee()
        {
            dgvEmployees.DataSource = null;
            var employeesList = employees.GetList();
            dgvEmployees.DataSource = employeesList;
            CreateEmployeeGrid();
            dgvID.Visible = false;

        }
        private void CreateRewardGrid()
        {
            dgvRewards.AutoGenerateColumns = false;

            dgvRewards.Columns.Clear();
            dgvRewards.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Title",
                HeaderText = "Вид награды",
                Width = 170
            });

            dgvRewards.Columns.Add(new DataGridViewColumn()
            {
                CellTemplate = new DataGridViewTextBoxCell(),
                DataPropertyName = "Description",
                HeaderText = "Описание",
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


        private void Employees_ColumnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (sortMode == EmployeeSortMode.Asceding)
                {
                    employees.SortEmployeesByLastNameDesc();
                    sortMode = EmployeeSortMode.Desceding;
                }
                else
                {
                    employees.SortEmployeesByLastNameAsc();
                    sortMode = EmployeeSortMode.Asceding;
                }
                DisplayEmployee();
            }
        }

        private void Rewards_ColumnClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortMode1 == RewardSortMode.Asceding)
            {
                rewards.SortRewardsByDesc();
                sortMode1 = RewardSortMode.Desceding;
            }
            else
            {
                rewards.SortRewardsByAsc();
                sortMode1 = RewardSortMode.Asceding;
            }
            DisplayReward();
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
            EmployeeForm form = new EmployeeForm();
          for (int i = 0; i < dgvRewards.RowCount; i++)
            {
                form.chRewards.Items.Add(dgvRewards[0, i].Value);
            }//////

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                employees.Add(form.LastName, form.FirstName, form.Birth, Checked_(form), Checked(form));///////
                DisplayEmployee();
            }
        }

        private string Checked_(EmployeeForm form)
        {
            string text = "";
            for (int i = 0; i < form.chRewards.CheckedItems.Count; i++)
            {
                text = text + " " + form.chRewards.CheckedItems[i].ToString();
            }
            return text;
        }

        private List<int> Checked(EmployeeForm form)
        {
            List<int> RewardsIdList = new List<int> { };
            if (form.chRewards.CheckedItems.Count != 0)
            {
                for (int i = 0; i < form.chRewards.CheckedItems.Count; i++)
                {
                //    Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;//////

                  //  RewardsIdList.Add(reward.ID);
                }
            }
            //  return RewardsToString(RewardsList);
            return RewardsIdList;
        }

        private string RewardsToString(List<int> RewardsIdList)
        {
            List<string> RewardsTitleList = new List<string> { };
            for (int i = 0; i < RewardsIdList.Count; i++)
            {
                Reward reward = (Reward)dgvRewards.SelectedCells[0].OwningRow.DataBoundItem;
                RewardsTitleList.Add(reward.Title);
            }
            ///////
            string RewardsToString_ = null;
            if (RewardsTitleList != null)
            {
                RewardsToString_ = string.Join(", ", RewardsTitleList);
            }
            return RewardsToString_;
        }

        private void EditSelectedEmployee()
        {
            if (dgvEmployees.SelectedCells.Count > 0)
            {
                Employee employee = (Employee)dgvEmployees.SelectedCells[0].OwningRow.DataBoundItem;
                EmployeeForm form = new EmployeeForm(employee, rewards);

                for (int i = 0; i < dgvRewards.RowCount; i++)
                {
                    bool b = true;
                    if (employee.Rewards == null)
                    {
                        b = false;
                    }
                    else
                    {
                        if (!employee.Rewards.Contains(dgvRewards[0, i].Value.ToString()))
                        {
                            b = false;
                        }
                    }
                    form.chRewards.Items.Add(dgvRewards[0, i].Value, b);
                }
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    employee.LastName = form.LastName;
                    employee.FirstName = form.FirstName;
                    employee.Birth = form.Birth;

                    //employee.Rewards = RewardsToString(Checked(form); 
                    employee.Rewards = Checked_(form);
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
                                employee.Rewards = employee.Rewards.Replace(del, "");
                                DisplayEmployee();
                            }
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

