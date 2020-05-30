using ArchitectBuroDataAccess;
using ArchitectBuroDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArchitectBuro
{
    public partial class MainForm : Form
    {
        public static List<Project> projectList;
        public static List<Employee> employeeList;
        public static List<Customer> customerList;
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {
            using (MySQLApplicationContext db = new MySQLApplicationContext())
            {
                projectType.Items.Clear();
                employeePosition.Items.Clear();
                employeeTeam.Items.Clear();
                projectTeam.Items.Clear();
                projectCustomer.Items.Clear();
                projectStatus.Items.Clear();
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
                projectList = db.Projects.ToList();
                employeeList = db.Employees.ToList();
                customerList = db.Customers.ToList();
                switch (tabControl.SelectedIndex)
                {
                    case 0:
                        RefreshDataGridView(projectList);
                        break;
                    case 1:
                        RefreshDataGridView(employeeList);
                        break;
                    case 2:
                        RefreshDataGridView(customerList);
                        break;
                }
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
            dataGridView.Columns[7].Name = "Дата приёма";
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
                    RefreshDataGridView(projectList);
                    break;
                case 1:
                    projectPanel.SendToBack();
                    customerPanel.SendToBack();
                    RefreshDataGridView(employeeList);
                    break;
                case 2:
                    projectPanel.SendToBack();
                    employeePanel.SendToBack();
                    RefreshDataGridView(customerList);
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                using (MySQLApplicationContext db = new MySQLApplicationContext())
                {
                    foreach(DataGridViewRow item in dataGridView.SelectedRows)
                        switch (tabControl.SelectedIndex)
                        {
                            case 0:
                                db.Projects.Remove(projectList[item.Index]);
                                break;
                            case 1:
                                db.Employees.Remove(employeeList[item.Index]);
                                break;
                            case 2:
                                db.Customers.Remove(customerList[item.Index]);
                                break;
                        }
                    db.SaveChanges();
                    UpdateData();
                    dataGridView.ClearSelection();
                }
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Location = Location;
            addForm.ShowDialog();
            UpdateData();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object data = null;
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    data = projectList[e.RowIndex];
                    break;
                case 1:
                    data = employeeList[e.RowIndex];
                    break;
                case 2:
                    data = customerList[e.RowIndex];
                    break;
            }
            AddForm addForm = new AddForm(true, tabControl.SelectedIndex, data);
            addForm.Location = Location;
            addForm.ShowDialog();
            UpdateData();
        }
    }
}
