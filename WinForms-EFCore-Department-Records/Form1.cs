using EFCore_Example.Context;
using EFCore_Example.Models;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFCore_Example
{
    public partial class EmployeRecords : Form
    {
        CFDbContext Entity = new CFDbContext();
        public EmployeRecords()
        {
            InitializeComponent();
        }

        // Add Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Department Name is required!");
                return;
            }
            if (Entity.Departments.Any(d => d.DepartmentName == txtName.Text))
            {
                MessageBox.Show(
                    "Department name already exists!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Department dept = new Department
            {
                DepartmentName = txtName.Text
            };

            Entity.Departments.Add(dept);
            Entity.SaveChanges();

            MessageBox.Show(
                $"Department Added Successfully! New ID = {dept.DepartmentId}",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtName.Text = "";

            btnDisplay_Click(null, EventArgs.Empty);
        }
        // Display Records
        private void btnDisplay_Click(object? sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (Entity.Departments.Any())
                foreach (var item in Entity.Departments)
                    listBox1.Items.Add(item.DepartmentId + "\t" + item.DepartmentName);

            else
                MessageBox.Show(
                        "No Departments Found",
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

                var dept = Entity.Departments.Find(id);
                if (dept == null)
                {
                    MessageBox.Show(
                   "Id does not exists in database!",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
                    return;
                }

                dept.DepartmentName = txtName.Text;
                Entity.SaveChanges();

                MessageBox.Show(
                       "Deparment Name is updated successfully",
                       "Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                // Reset Fields
                txtId.Text = txtName.Text = "";
                
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
            try { 
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

            var dept = Entity.Departments.Find(id);
            if (dept == null)
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
            Entity.Departments.Remove(dept);

            //Save changes to database
            Entity.SaveChanges();

            MessageBox.Show(
                "Department deleted successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Reset Fields
            txtId.Text = txtName.Text = "";

            // Refresh list
            btnDisplay_Click(null, EventArgs.Empty);

        }  catch (Exception ex)
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
