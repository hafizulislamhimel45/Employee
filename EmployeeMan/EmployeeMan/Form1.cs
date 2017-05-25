using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeMan
{
    public partial class Form1 : Form
    {
        EmployeeDAO employeeDao = new EmployeeDAO();

        public Form1()
        {
            InitializeComponent();
            LoadEmployee();
        }


        private void LoadEmployee()
        {
            empinfo.DataSource = employeeDao.getCustomers().Tables[0];
        }

        private void create_Click(object sender, EventArgs e)
        {
            int iid = Convert.ToInt32(id.Text);

            int aage = Convert.ToInt32(age.Text);

            int ssalaey = Convert.ToInt32(salary.Text);

            String nname = name.Text;

            employeeDao.createEmployee(new EmployeeDTO(iid, aage, ssalaey, nname));

            LoadEmployee();
        }

        private void empinfo_SelectionChanged(object sender, EventArgs e)
        {
            if (empinfo.SelectedRows.Count == 1)
            {
                int idx = empinfo.SelectedRows[0].Index;
                id.Text = empinfo.Rows[idx].Cells[0].Value.ToString();
                age.Text = empinfo.Rows[idx].Cells[2].Value.ToString();
                salary.Text = empinfo.Rows[idx].Cells[3].Value.ToString();
                name.Text = empinfo.Rows[idx].Cells[1].Value.ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(id.Text);

            employeeDao.deleteEmployee(idd);

            LoadEmployee();

            id.Text = "";

            name.Text = "";

            age.Text = "";

            salary.Text = "";

        }

        private void empinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(id.Text);

            int sal = Convert.ToInt32(salary.Text);

            int ag = Convert.ToInt32(age.Text);

            employeeDao.updateEmployee(idd,name.Text,sal);

            LoadEmployee();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
