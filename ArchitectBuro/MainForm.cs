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
                foreach (var item in Controls)
                {
                    if (item is ComboBox)
                    {
                        (item as ComboBox).Items.Clear();
                    }
                }
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

        public void RefreshDataGridView(object dataSource)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataSource;
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
            new AddForm().ShowDialog();
            UpdateData();
        }
    }
}
