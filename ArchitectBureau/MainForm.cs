using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ArchitectBureauDataAccess;
using ArchitectBureauDataAccess.Models;

namespace ArchitectBureau
{
    public partial class MainForm : Form
    {
        private List<Project> _projectList;
        private List<Employee> _employeeList;
        private List<Customer> _customerList;

        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            using (MySqlApplicationContext db = new MySqlApplicationContext())
            {
                projectType.Items.Clear();
                employeePosition.Items.Clear();
                employeeTeam.Items.Clear();
                projectTeam.Items.Clear();
                projectCustomer.Items.Clear();
                projectStatus.Items.Clear();
                projectType.Items.Add("");
                employeePosition.Items.Add("");
                employeeTeam.Items.Add("");
                projectTeam.Items.Add("");
                projectCustomer.Items.Add("");
                projectStatus.Items.Add("");

                foreach (ProjectType item in db.ProjectTypes)
                {
                    projectType.Items.Add(item.Name);
                }
                foreach (Position item in db.Positions)
                {
                    employeePosition.Items.Add(item.Name);
                }

                foreach (Team item in db.Teams)
                {
                    employeeTeam.Items.Add(item.Name);
                    projectTeam.Items.Add(item.Name);
                }

                foreach (Customer item in db.Customers)
                {
                    projectCustomer.Items.Add(item.FirstName + " " + item.LastName);
                }

                foreach (ProjectStatus item in db.ProjectStatuses)
                {
                    projectStatus.Items.Add(item.Name);
                }

                _projectList = db.Projects.ToList();
                _employeeList = db.Employees.ToList();
                _customerList = db.Customers.ToList();
            }
        }

        public void RefreshDataGridView(List<Project> dataSource)
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Команда";
            dataGridView.Columns[2].Name = "Дата заказа";
            dataGridView.Columns[3].Name = "Дата окончания";
            dataGridView.Columns[4].Name = "Статус проекта";
            dataGridView.Columns[5].Name = "Тип проекта";
            dataGridView.Columns[6].Name = "Клиент";
            foreach (Project item in dataSource)
            {
                dataGridView.Rows.Add(
                    item.Id,
                    item.Team.Name,
                    item.OrderDate.ToString("dd.MM.yyyy"),
                    item.FinishDate.ToString("dd.MM.yyyy"),
                    item.ProjectStatus.Name,
                    item.ProjectType.Name,
                    item.Customer.FirstName + " " + item.Customer.LastName
                );
            }
        }

        public void RefreshDataGridView(List<Employee> dataSource)
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 8;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Команда";
            dataGridView.Columns[2].Name = "Должность";
            dataGridView.Columns[3].Name = "Имя Фамилия";
            dataGridView.Columns[4].Name = "Дата рождения";
            dataGridView.Columns[5].Name = "Домашний адрес";
            dataGridView.Columns[6].Name = "Телефон";
            dataGridView.Columns[7].Name = "Дата вступления";
            foreach (Employee item in dataSource)
            {
                dataGridView.Rows.Add(
                    item.Id,
                    item.Team.Name,
                    item.Position.Name,
                    item.FirstName + " " + item.LastName,
                    item.BirthDate.ToString("dd.MM.yyyy"),
                    item.HomeAddress,
                    item.Phone,
                    item.ApplyDate.ToString("dd.MM.yyyy")
                );
            }
        }

        public void RefreshDataGridView(List<Customer> dataSource)
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "Имя Фамилия";
            dataGridView.Columns[2].Name = "Почта";
            dataGridView.Columns[3].Name = "Телефон";
            foreach (Customer item in dataSource)
            {
                dataGridView.Rows.Add(
                    item.Id,
                    item.FirstName + " " + item.LastName,
                    item.Email,
                    item.Phone
                );
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    employeePanel.SendToBack();
                    customerPanel.SendToBack();
                    RefreshDataGridView(_projectList);
                    break;
                case 1:
                    projectPanel.SendToBack();
                    customerPanel.SendToBack();
                    RefreshDataGridView(_employeeList);
                    break;
                case 2:
                    projectPanel.SendToBack();
                    employeePanel.SendToBack();
                    RefreshDataGridView(_customerList);
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    RefreshDataGridView(_projectList);
                    break;
                case 1:
                    RefreshDataGridView(_employeeList);
                    break;
                case 2:
                    RefreshDataGridView(_customerList);
                    break;
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (MySqlApplicationContext db = new MySqlApplicationContext())
                {
                    foreach (DataGridViewRow item in dataGridView.SelectedRows)
                    {
                        switch (tabControl.SelectedIndex)
                        {
                            case 0:
                                db.Projects.Remove(_projectList.Find(search =>
                                    search.Id == int.Parse(item.Cells[0].Value.ToString())));
                                break;
                            case 1:
                                db.Employees.Remove(_employeeList.Find(search =>
                                    search.Id == int.Parse(item.Cells[0].Value.ToString())));
                                break;
                            case 2:
                                db.Customers.Remove(_customerList.Find(search =>
                                    search.Id == int.Parse(item.Cells[0].Value.ToString())));
                                break;
                        }

                        dataGridView.Rows.Remove(item);
                    }

                    db.SaveChanges();
                    UpdateData();
                }
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(Location);
            addForm.ShowDialog();
            if (addForm.ReturnValues != null)
            {
                dataGridView.Rows.Add(addForm.ReturnValues);
                if (dataGridView.SortedColumn != null)
                {
                    dataGridView.Sort(dataGridView.SortedColumn,
                        dataGridView.SortOrder == SortOrder.Ascending
                            ? ListSortDirection.Ascending
                            : ListSortDirection.Descending);
                }

                UpdateData();
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            object data = null;
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    data = _projectList.Find(search =>
                        search.Id == int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    break;
                case 1:
                    data = _employeeList.Find(search =>
                        search.Id == int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    break;
                case 2:
                    data = _customerList.Find(search =>
                        search.Id == int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    break;
            }

            AddForm addForm = new AddForm(new Point(Cursor.Position.X - 100, Cursor.Position.Y - 50), true,
                tabControl.SelectedIndex, data);
            addForm.ShowDialog();
            if (addForm.ReturnValues != null)
            {
                dataGridView.Rows[e.RowIndex].SetValues(addForm.ReturnValues);
                if (dataGridView.SortedColumn != null)
                {
                    dataGridView.Sort(dataGridView.SortedColumn,
                        dataGridView.SortOrder == SortOrder.Ascending
                            ? ListSortDirection.Ascending
                            : ListSortDirection.Descending);
                }

                UpdateData();
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    //foreach (DataGridViewRow item in dataGridView.Rows)
                    //{
                    //    if (item.Cells[1].Value.ToString() == projectTeam.SelectedItem.ToString() && projectTeam.SelectedItem.ToString() == "" && item.Cells[2].Value.ToString() == projectStartDate.Text && projectStartDate.Text != "")
                    //    {
                    //        item.Visible = true;
                    //    }
                    //    else
                    //    {
                    //        item.Visible = false;
                    //    }
                    //}
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }
    }
}