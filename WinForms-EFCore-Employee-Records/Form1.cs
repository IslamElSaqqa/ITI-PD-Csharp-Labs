using WinForms_EFCore_Employee_Records.Context;
using WinForms_EFCore_Employee_Records.Models;

namespace WinForms_EFCore_Employee_Records
{
    public partial class Form1 : Form
    {
        CFDbContext Entity = new CFDbContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDept.Text))
                {
                    MessageBox.Show(
                        "Employee Name and Department are required!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (Entity.Employees.Any(e => e.EmployeeName == txtName.Text))
                {
                    MessageBox.Show(
                        "Employee Name already exists!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Employee Emp = new Employee()
                {
         
                    EmployeeName = txtName.Text,
                    DepartmentName = txtDept.Text
                };

                Entity.Employees.Add(Emp);
                Entity.SaveChanges();

                MessageBox.Show(
                    $"Employee Added Successfully! Generated ID = {Emp.EmployeeId}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtName.Text = txtDept.Text = "";

                btnDisplay_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        // Display Records
        // Display Records
        private void btnDisplay_Click(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (Entity.Employees.Any())
                foreach (var item in Entity.Employees)
                    listBox1.Items.Add(
                        item.EmployeeId + "\t" +
                        item.EmployeeName + "\t" +
                        item.DepartmentName);

            else
                MessageBox.Show(
                        "No Employees Found",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show(
                        "ID is required to update!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                int id = int.Parse(txtId.Text);

                var emp = Entity.Employees.Find(id);
                if (emp == null)
                {
                    MessageBox.Show(
                       "Id does not exists in database!",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );
                    return;
                }

                emp.EmployeeName = txtName.Text;
                emp.DepartmentName = txtDept.Text;

                Entity.SaveChanges();

                MessageBox.Show(
                       "Employee updated successfully",
                       "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                // Reset Fields
                txtId.Text = txtName.Text = txtDept.Text = "";

                // Refresh list
                btnDisplay_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show(
                        "ID is required to Delete!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                int id = int.Parse(txtId.Text);

                var emp = Entity.Employees.Find(id);
                if (emp == null)
                {
                    MessageBox.Show(
                       "Id does not exists in database!",
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );
                    return;
                }

                // Remove entity
                Entity.Employees.Remove(emp);

                // Save changes to database
                Entity.SaveChanges();

                MessageBox.Show(
                    "Employee deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Reset Fields
                txtId.Text = txtName.Text = txtDept.Text = "";

                // Refresh list
                btnDisplay_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }
        }
    }
}
