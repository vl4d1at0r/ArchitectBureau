using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ArchitectBureauDataAccess;
using ArchitectBureauDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace ArchitectBureau
{
    public sealed partial class AddForm : Form
    {
        private readonly List<Team> _teams;
        private readonly List<Customer> _customers;
        private readonly List<ProjectStatus> _projectStatuses;
        private readonly List<ProjectType> _projectTypes;
        private readonly List<Position> _positions;
        private readonly int _id;
        private readonly Point _formPosition;
        public object[] ReturnValues;

        public AddForm(Point position, bool edit = false, int editIndex = 0, object element = null)
        {
            InitializeComponent();
            _formPosition = position;
            using (MySqlApplicationContext db = new MySqlApplicationContext())
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

                _teams = db.Teams.ToList();
                _customers = db.Customers.ToList();
                _projectStatuses = db.ProjectStatuses.ToList();
                _projectTypes = db.ProjectTypes.ToList();
                _positions = db.Positions.ToList();
            }

            if (edit)
            {
                createButton.Text = @"Изменить";
                createButton.Click += EditButton;
                Text = @"Изменить";
                createTypeComboBox.SelectedIndex = editIndex;
                createTypeComboBox.Enabled = false;
                switch (editIndex)
                {
                    case 0:
                        if (element is Project project)
                        {
                            _id = project.Id;
                            projectTeamComboBox.SelectedItem = project.Team.Name;
                            projectOrderDatePicker.Value = project.OrderDate;
                            projectStatusComboBox.SelectedItem = project.ProjectStatus.Name;
                            projectTypeComboBox.SelectedItem = project.ProjectType.Name;
                            projectCustomerComboBox.SelectedItem =
                                project.Customer.FirstName + " " + project.Customer.LastName;
                        }

                        break;
                    case 1:
                        if (element is Employee employee)
                        {
                            _id = employee.Id;
                            employeeTeamComboBox.SelectedItem = employee.Team.Name;
                            employeePositionComboBox.SelectedItem = employee.Position.Name;
                            employeeFirstNameTextBox.Text = employee.FirstName;
                            employeeLastNameTextBox.Text = employee.LastName;
                            employeeBirthDatePicker.Value = employee.BirthDate;
                            employeeHomeAddressTextBox.Text = employee.HomeAddress;
                            employeePhoneTextBox.Text = employee.Phone;
                            employeeApplyDatePicker.Value = employee.ApplyDate;
                        }

                        break;
                    case 2:
                        if (element is Customer customer)
                        {
                            _id = customer.Id;
                            customerFirstNameTextBox.Text = customer.FirstName;
                            customerLastNameTextBox.Text = customer.LastName;
                            customerEmailTextBox.Text = customer.Email;
                            customerPhoneTextBox.Text = customer.Phone;
                        }

                        break;
                }
            }
            else
            {
                createButton.Text = @"Добавить";
                createButton.Click += AddButton;
                Text = @"Добавить";
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

        private void AddButton(object sender, EventArgs e)
        {
            using (MySqlApplicationContext db = new MySqlApplicationContext())
            {
                switch (createTypeComboBox.SelectedIndex)
                {
                    case 0:
                        Project project = new Project()
                        {
                            TeamId = _teams[projectTeamComboBox.SelectedIndex].Id,
                            OrderDate = projectOrderDatePicker.Value,
                            FinishDate =
                                projectOrderDatePicker.Value.AddMonths(
                                    _projectTypes[projectTypeComboBox.SelectedIndex].Term),
                            ProjectStatusId = _projectStatuses[projectStatusComboBox.SelectedIndex].Id,
                            ProjectTypeId = _projectTypes[projectTypeComboBox.SelectedIndex].Id,
                            CustomerId = _customers[projectCustomerComboBox.SelectedIndex].Id
                        };
                        db.Projects.Add(project);
                        db.SaveChanges();
                        project = db.Projects
                            .Include(item => item.Team)
                            .Include(item => item.ProjectStatus)
                            .Include(item => item.ProjectType)
                            .Include(item => item.Customer)
                            .First(item => item.Id == project.Id);
                        ReturnValues = new object[]
                        {
                            project.Id,
                            project.Team.Name,
                            project.OrderDate.ToString("dd.MM.yyyy"),
                            project.FinishDate.ToString("dd.MM.yyyy"),
                            project.ProjectStatus.Name,
                            project.ProjectType.Name,
                            project.Customer.FirstName + " " + project.Customer.LastName
                        };
                        break;
                    case 1:
                        Employee employee = new Employee()
                        {
                            TeamId = _teams[employeeTeamComboBox.SelectedIndex].Id,
                            PositionId = _positions[employeePositionComboBox.SelectedIndex].Id,
                            FirstName = employeeFirstNameTextBox.Text,
                            LastName = employeeLastNameTextBox.Text,
                            BirthDate = employeeBirthDatePicker.Value,
                            HomeAddress = employeeHomeAddressTextBox.Text,
                            Phone = employeePhoneTextBox.Text,
                            ApplyDate = employeeApplyDatePicker.Value
                        };
                        db.Employees.Add(employee);
                        db.SaveChanges();
                        employee = db.Employees
                            .Include(item => item.Team)
                            .Include(item => item.Position)
                            .First(item => item.Id == employee.Id);
                        ReturnValues = new object[]
                        {
                            employee.Id,
                            employee.Team.Name,
                            employee.Position.Name,
                            employee.FirstName + " " + employee.LastName,
                            employee.BirthDate.ToString("dd.MM.yyyy"),
                            employee.HomeAddress,
                            employee.Phone,
                            employee.ApplyDate.ToString("dd.MM.yyyy")
                        };
                        break;
                    case 2:
                        Customer customer = new Customer()
                        {
                            FirstName = customerFirstNameTextBox.Text,
                            LastName = customerLastNameTextBox.Text,
                            Email = customerEmailTextBox.Text,
                            Phone = customerPhoneTextBox.Text
                        };
                        db.Customers.Add(customer);
                        db.SaveChanges();
                        ReturnValues = new object[]
                        {
                            customer.Id,
                            customer.FirstName + " " + customer.LastName,
                            customer.Email,
                            customer.Phone
                        };
                        break;
                }
            }

            Close();
        }

        private void EditButton(object sender, EventArgs e)
        {
            using (MySqlApplicationContext db = new MySqlApplicationContext())
            {
                switch (createTypeComboBox.SelectedIndex)
                {
                    case 0:
                        Project project = db.Projects.First(item => item.Id == _id);
                        project.Team = _teams[projectTeamComboBox.SelectedIndex];
                        project.ProjectStatus = _projectStatuses[projectStatusComboBox.SelectedIndex];
                        project.ProjectType = _projectTypes[projectTypeComboBox.SelectedIndex];
                        project.Customer = _customers[projectCustomerComboBox.SelectedIndex];
                        project.OrderDate = projectOrderDatePicker.Value;
                        project.FinishDate =
                            project.OrderDate.AddMonths(_projectTypes[projectTypeComboBox.SelectedIndex].Term);
                        ReturnValues = new object[]
                        {
                            project.Id,
                            project.Team.Name,
                            project.OrderDate.ToString("dd.MM.yyyy"),
                            project.FinishDate.ToString("dd.MM.yyyy"),
                            project.ProjectStatus.Name,
                            project.ProjectType.Name,
                            project.Customer.FirstName + " " + project.Customer.LastName
                        };
                        break;
                    case 1:
                        Employee employee = db.Employees.First(item => item.Id == _id);
                        employee.Team = _teams[employeeTeamComboBox.SelectedIndex];
                        employee.Position = _positions[employeePositionComboBox.SelectedIndex];
                        employee.FirstName = employeeFirstNameTextBox.Text;
                        employee.LastName = employeeLastNameTextBox.Text;
                        employee.BirthDate = employeeBirthDatePicker.Value;
                        employee.HomeAddress = employeeHomeAddressTextBox.Text;
                        employee.Phone = employeePhoneTextBox.Text;
                        employee.ApplyDate = employeeApplyDatePicker.Value;
                        ReturnValues = new object[]
                        {
                            employee.Id,
                            employee.Team.Name,
                            employee.Position.Name,
                            employee.FirstName + " " + employee.LastName,
                            employee.BirthDate.ToString("dd.MM.yyyy"),
                            employee.HomeAddress,
                            employee.Phone,
                            employee.ApplyDate.ToString("dd.MM.yyyy")
                        };
                        break;
                    case 2:
                        Customer customer = db.Customers.First(item => item.Id == _id);
                        customer.FirstName = customerFirstNameTextBox.Text;
                        customer.LastName = customerLastNameTextBox.Text;
                        customer.Email = customerEmailTextBox.Text;
                        customer.Phone = customerPhoneTextBox.Text;
                        ReturnValues = new object[]
                        {
                            customer.Id,
                            customer.FirstName + " " + customer.LastName,
                            customer.Email,
                            customer.Phone
                        };
                        break;
                }

                db.SaveChanges();
            }

            Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            Location = _formPosition;
        }
    }
}