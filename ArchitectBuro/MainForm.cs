using ArchitectBuroDataAccess;
using ArchitectBuroDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
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
                projects.DataSource = projectList;
                employees.DataSource = db.Employees.ToList();
                customers.DataSource = db.Customers.ToList();
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    employeePanel.SendToBack();
                    customerPanel.SendToBack();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void projects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow item in projects.SelectedRows)
                {
                    projectList.RemoveAt(item.Index);
                    projects.DataSource = null;
                    projects.DataSource = projectList;
                    projects.ClearSelection();
                }
            }
        }
    }
}
