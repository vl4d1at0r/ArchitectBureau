using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchitectBureauDataAccess;
using ArchitectBureauDataAccess.Models;

namespace ArchitectBureau
{
    public partial class PriceForm : Form
    {
        public PriceForm()
        {
            InitializeComponent();
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            using (MySqlApplicationContext db = new MySqlApplicationContext())
            {
                dataGridView.ColumnCount = 4;
                dataGridView.Columns[0].Name = "ID";
                dataGridView.Columns[1].Name = "Название";
                dataGridView.Columns[2].Name = "Цена";
                dataGridView.Columns[3].Name = "Срок выполнения(в месяцах)";
                foreach (ProjectType item in db.ProjectTypes)
                {
                    dataGridView.Rows.Add(
                        item.Id,
                        item.Name,
                        item.Price,
                        item.Term
                        );
                }
            }
        }
    }
}
