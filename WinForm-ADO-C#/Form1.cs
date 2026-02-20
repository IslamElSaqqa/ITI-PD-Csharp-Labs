using Microsoft.Data.SqlClient;
using System.Data;

namespace Employees_ADO_SQL_Connection
{
    public partial class Form1 : Form
    {
        SqlConnection m_Connection;
        SqlDataAdapter m_Adapter;

        SqlCommand SelectCmd;
        SqlCommand InsertCmd;
        SqlCommand UpdateCmd;
        SqlCommand DeleteCmd;

        DataSet m_DataSet;

        public Form1()
        {
            InitializeComponent();

            // Connection
            m_Connection = new SqlConnection();
            m_Connection.ConnectionString =
                "Data Source=.\\SQLEXPRESS;Initial Catalog=ITI_WINForms;Integrated Security=True;TrustServerCertificate=True";

            m_Adapter = new SqlDataAdapter();
            m_DataSet = new DataSet();

            // SELECT
            SelectCmd = new SqlCommand();
            SelectCmd.Connection = m_Connection;
            SelectCmd.CommandText = "SELECT * FROM Employee";
            m_Adapter.SelectCommand = SelectCmd;

            // INSERT
            InsertCmd = new SqlCommand();
            InsertCmd.Connection = m_Connection;
            InsertCmd.CommandText =
                "INSERT INTO Employee (ID, Name, Dept_name) VALUES (@Id,@Name,@Dept_name)";
            InsertCmd.Parameters.Add("@Id", SqlDbType.Int, 0, "ID");
            InsertCmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            InsertCmd.Parameters.Add("@Dept_name", SqlDbType.NVarChar, 100, "Dept_name");
            m_Adapter.InsertCommand = InsertCmd;

            // UPDATE
            UpdateCmd = new SqlCommand();
            UpdateCmd.Connection = m_Connection;
            UpdateCmd.CommandText =
                "UPDATE Employee SET Name=@Name, Dept_name=@Dept_name WHERE ID=@Id";
            UpdateCmd.Parameters.Add("@Id", SqlDbType.Int, 0, "ID");
            UpdateCmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
            UpdateCmd.Parameters.Add("@Dept_name", SqlDbType.NVarChar, 100, "Dept_name");
            m_Adapter.UpdateCommand = UpdateCmd;

            // DELETE
            DeleteCmd = new SqlCommand();
            DeleteCmd.Connection = m_Connection;
            DeleteCmd.CommandText = "DELETE FROM Employee WHERE ID=@Id";
            DeleteCmd.Parameters.Add("@Id", SqlDbType.Int, 0, "ID");
            m_Adapter.DeleteCommand = DeleteCmd;
        }

        // Display Button
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            m_DataSet.Clear();
            m_Adapter.Fill(m_DataSet, "Employee");
            m_DataSet.Tables["Employee"].PrimaryKey =
                new DataColumn[] { m_DataSet.Tables["Employee"].Columns["ID"] };
            dgv.DataSource = m_DataSet.Tables["Employee"];
        }

        // Insert Button
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter an ID to insert", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure employee table is loaded so we can check for duplicates
            if (m_DataSet == null)
                m_DataSet = new DataSet();

            if (!m_DataSet.Tables.Contains("Employee") || m_DataSet.Tables["Employee"].Rows.Count == 0)
            {
                m_DataSet.Clear();
                m_Adapter.Fill(m_DataSet, "Employee");
            }

            DataTable table = m_DataSet.Tables["Employee"];

            // Ensure primary key is set for Rows.Find
            if (table.PrimaryKey == null || table.PrimaryKey.Length == 0)
            {
                if (table.Columns.Contains("ID"))
                    table.PrimaryKey = new DataColumn[] { table.Columns["ID"] };
            }

            // Check for existing ID
            DataRow existing = table.Rows.Find(id);
            if (existing != null)
            {
                MessageBox.Show($"ID {id} already exists.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create and add new row
            DataRow row = table.NewRow();
            row["ID"] = id;
            row["Name"] = txtName.Text;
            row["Dept_name"] = txtDept.Text;
            table.Rows.Add(row);

            try
            {
                SaveChanges();
                MessageBox.Show($"ID {id} inserted successfully.", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to insert ID {id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter an ID to update", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (m_DataSet == null || !m_DataSet.Tables.Contains("Employee"))
            {
                MessageBox.Show("Employee data is not loaded. Click Display to load data.", "Data Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable table = m_DataSet.Tables["Employee"];
            DataRow row = table.Rows.Find(id);

            if (row == null)
            {
                MessageBox.Show($"ID {id} does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            row["Name"] = txtName.Text;
            row["Dept_name"] = txtDept.Text;

            try
            {
                SaveChanges();
                MessageBox.Show($"ID {id} updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update ID {id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter an ID to delete", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (m_DataSet == null || !m_DataSet.Tables.Contains("Employee"))
            {
                MessageBox.Show("Employee data is not loaded. Click Display to load data.", "Data Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable table = m_DataSet.Tables["Employee"];
            DataRow row = table.Rows.Find(id);

            if (row == null)
            {
                MessageBox.Show($"ID {id} does not exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            row.Delete();

            try
            {
                SaveChanges();
                MessageBox.Show($"ID {id} deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete ID {id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search Button 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
                return;

            if (!int.TryParse(txtId.Text, out int searchId))
            {
                MessageBox.Show("Please enter a valid numeric ID");
                return;
            }

            // Filter the DataGridView using DataView
            DataView dv = new DataView(m_DataSet.Tables["Employee"]);
            dv.RowFilter = $"ID = {searchId}";
            dgv.DataSource = dv;

            if (dv.Count > 0)
            {
                txtName.Text = dv[0]["Name"].ToString();
                txtDept.Text = dv[0]["Dept_name"].ToString();
            }
            else
            {
                txtName.Clear();
                txtDept.Clear();
                MessageBox.Show("No employee found with this ID");
            }
        }

        // Refresh Grid View
        private void RefreshGridView()
        {
            if (m_DataSet == null)
                m_DataSet = new DataSet();

            // If the table does not exist, create it by filling the DataSet.
            if (!m_DataSet.Tables.Contains("Employee"))
            {
                m_Adapter.Fill(m_DataSet, "Employee");
            }
            else
            {
                // Clear existing rows and refill to get the latest data from DB.
                DataTable table = m_DataSet.Tables["Employee"];
                table.Clear();
                m_Adapter.Fill(m_DataSet, "Employee");

                // Ensure primary key is set
                // so Rows. Find works.
                if ((table.PrimaryKey == null || table.PrimaryKey.Length == 0) && table.Columns.Contains("ID"))
                    table.PrimaryKey = new DataColumn[] { table.Columns["ID"] };
            }

            // Rebinding and refreshing the grid.
            dgv.DataSource = null;
            dgv.DataSource = m_DataSet.Tables["Employee"];
            dgv.Refresh();
        }

        // Save Changes
        private void SaveChanges(bool refresh = true)
        {
            m_Adapter.Update(m_DataSet, "Employee");


            if (refresh)
                RefreshGridView();
        }

        // Button Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to refresh data: {ex.Message}", "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
