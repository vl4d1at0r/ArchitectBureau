using ArchitectBuroDataAccess;
using ArchitectBuroDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchitectBuro
{
    public partial class AddForm : Form
    {
        public List<Team> Teams;
        public List<Customer> Customers;
        public List<Employee> Employees;
        public List<Project> Projects;
        public List<ProjectStatus> ProjectStatuses;
        public List<ProjectType> ProjectTypes;
        public List<Position> Positions;
        public int Id;

        public AddForm(bool edit = false, int editIndex = 0, object element = null)
        {
            InitializeComponent();
            using (MySQLApplicationContext db = new MySQLApplicationContext())
            {
                foreach (Team item in db.Teams)
                {
                    projectTeamComboBox.Items.Add(item.Name);
                    employeeTeamComboBox.Items.Add(item.Name);
                }
                foreach (ProjectStatus item in db.ProjectStatuses)
                {
                    projectStatusComboBox.Items.Add(item.Name);
                }
                foreach (ProjectType item in db.ProjectTypes)
                {
                    projectTypeComboBox.Items.Add(item.Name);
                }
                foreach (Customer item in db.Customers)
                {
                    projectCustomerComboBox.Items.Add(item.FirstName + " " + item.LastName);
                }
                foreach (Position item in db.Positions)
                {
                    employeePositionComboBox.Items.Add(item.Name);
                }
                Teams = db.Teams.ToList();
                Customers = db.Customers.ToList();
                Employees = db.Employees.ToList();
                Projects = db.Projects.ToList();
                ProjectStatuses = db.ProjectStatuses.ToList();
                ProjectTypes = db.ProjectTypes.ToList();
                Positions = db.Positions.ToList();
            }
            if (edit)
            {
                createButton.Text = "Изменить";
                createButton.Click += editButton;
                Text = "Изменить";
                createTypeComboBox.SelectedIndex = editIndex;
                createTypeComboBox.Enabled = false;
                switch (editIndex)
                {
                    case 0:
                        Project project = element as Project;
                        Id = project.Id;
                        projectTeamComboBox.SelectedItem = project.Team.Name;
                        projectOrderDatePicker.Value = project.OrderDate;
                        projectStatusComboBox.SelectedItem = project.ProjectStatus.Name;
                        projectTypeComboBox.SelectedItem = project.ProjectType.Name;
                        projectCustomerComboBox.SelectedItem = project.Customer.FirstName + " " + project.Customer.LastName;
                        break;
                    case 1:
                        Employee employee = element as Employee;
                        Id = employee.Id;
                        employeeTeamComboBox.SelectedItem = employee.Team.Name;
                        employeePositionComboBox.SelectedItem = employee.Position.Name;
                        employeeFirstNameTextBox.Text = employee.FirstName;
                        employeeLastNameTextBox.Text = employee.LastName;
                        employeeBirthDatePicker.Value = employee.BirthDate;
                        employeeHomeAddressTextBox.Text = employee.HomeAddress;
                        employeePhoneTextBox.Text = employee.Phone;
                        employeeApplyDatePicker.Value = employee.ApplyDate;
                        break;
                    case 2:
                        Customer customer = element as Customer;
                        Id = customer.Id;
                        customerFirstNameTextBox.Text = customer.FirstName;
                        customerLastNameTextBox.Text = customer.LastName;
                        customerEmailTextBox.Text = customer.Email;
                        customerPhoneTextBox.Text = customer.Phone;
                        break;
                }
            }
            else
            {
                createButton.Text = "Добавить";
                createButton.Click += addButton;
                Text = "Добавить";
                createTypeComboBox.SelectedIndex = 0;
            }
        }

        private void createType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (createTypeComboBox.SelectedIndex)
            {
                case 0:
                    customerPanel.SendToBack();
                    employeePanel.SendToBack();
                    break;
                case 1:
                    projectPanel.SendToBack();
                    customerPanel.SendToBack();
                    break;
                case 2:
                    projectPanel.SendToBack();
                    employeePanel.SendToBack();
                    break;
            }
        }

        private void addButton(object sender, EventArgs e)
        {
            using (MySQLApplicationContext db = new MySQLApplicationContext())
            {
                switch (createTypeComboBox.SelectedIndex)
                {
                    case 0:
                        db.Projects.Add(new Project()
                        {
                            TeamId = Teams[projectTeamComboBox.SelectedIndex].Id,
                            OrderDate = projectOrderDatePicker.Value,
                            FinishDate = projectOrderDatePicker.Value.AddMonths(db.ProjectTypes.ToList()[projectTypeComboBox.SelectedIndex].Term),
                            ProjectStatusId = ProjectStatuses[projectStatusComboBox.SelectedIndex].Id,
                            ProjectTypeId = ProjectTypes[projectTypeComboBox.SelectedIndex].Id,
                            CustomerId = Customers[projectCustomerComboBox.SelectedIndex].Id
                        });
                        break;
                    case 1:
                        db.Employees.Add(new Employee()
                        {
                            TeamId = Teams[employeeTeamComboBox.SelectedIndex].Id,
                            PositionId = Positions[employeePositionComboBox.SelectedIndex].Id,
                            FirstName = employeeFirstNameTextBox.Text,
                            LastName = employeeLastNameTextBox.Text,
                            BirthDate = employeeBirthDatePicker.Value,
                            HomeAddress = employeeHomeAddressTextBox.Text,
                            Phone = employeePhoneTextBox.Text,
                            ApplyDate = employeeApplyDatePicker.Value
                        });
                        break;
                    case 2:
                        db.Customers.Add(new Customer()
                        {
                            FirstName = customerFirstNameTextBox.Text,
                            LastName = customerLastNameTextBox.Text,
                            Email = customerEmailTextBox.Text,
                            Phone = customerPhoneTextBox.Text
                        });
                        break;
                }
                db.SaveChanges();
            }
            Close();
        }

        private void editButton(object sender, EventArgs e)
        {
            using (MySQLApplicationContext db = new MySQLApplicationContext())
            {
                switch (createTypeComboBox.SelectedIndex)
                {
                    case 0:
                        Project project = db.Projects.Find(Id);
                        project.TeamId = Teams[projectTeamComboBox.SelectedIndex].Id;
                        project.OrderDate = projectOrderDatePicker.Value;
                        project.ProjectStatusId = ProjectStatuses[projectStatusComboBox.SelectedIndex].Id;
                        project.ProjectTypeId = ProjectTypes[projectTypeComboBox.SelectedIndex].Id;
                        project.CustomerId = Customers[projectCustomerComboBox.SelectedIndex].Id;
                        break;
                    case 1:
                        Employee employee = db.Employees.Find(Id);
                        employee.TeamId = Teams[employeeTeamComboBox.SelectedIndex].Id;
                        employee.PositionId = Positions[employeePositionComboBox.SelectedIndex].Id;
                        employee.FirstName = employeeFirstNameTextBox.Text;
                        employee.LastName = employeeLastNameTextBox.Text;
                        employee.BirthDate = employeeBirthDatePicker.Value;
                        employee.HomeAddress = employeeHomeAddressTextBox.Text;
                        employee.Phone = employeePhoneTextBox.Text;
                        employee.ApplyDate = employeeApplyDatePicker.Value;
                        break;
                    case 2:
                        Customer customer = db.Customers.Find(Id);
                        customer.FirstName = customerFirstNameTextBox.Text;
                        customer.LastName = customerLastNameTextBox.Text;
                        customer.Email = customerEmailTextBox.Text;
                        customer.Phone = customerPhoneTextBox.Text;
                        break;
                }
                db.SaveChanges();
            }
            Close();
        }
    }
}
