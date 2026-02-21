using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Connected_Model_ADO
{
    public partial class Form1 : Form
    {
        // Connection Variables
        SqlConnection m_SqlConnection;
        SqlCommand m_SqlCommand;


        public Form1()
        {
            InitializeComponent();
            m_SqlConnection = new SqlConnection();
            m_SqlConnection.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=ITI_WINForms;Integrated Security=True; TrustServerCertificate=True";

            m_SqlCommand = new SqlCommand();
            m_SqlCommand.Connection = m_SqlConnection;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSearch.Enabled = false;
            btnDisplay.Enabled = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnClear.Enabled = false;
        }

        // Display all Data
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                string FetchedEmployees = "SELECT * FROM EMPLOYEE";
                m_SqlCommand.CommandText = FetchedEmployees;



                using (SqlDataReader reader = m_SqlCommand.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No Records in Database!");
                        return;
                    }

                    while (reader.Read())
                    {

                        string str = (int)reader[0] + "\t" + reader[1].ToString() + "  \t" + reader[2].ToString();
                        listBox1.Items.Add(str);

                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void ExecuteStatement(string query, string state)
        {

            m_SqlCommand.CommandText = query;

            int affectedRows = m_SqlCommand.ExecuteNonQuery();

            txtId.Text = txtName.Text = txtDept.Text = "";
            MessageBox.Show(affectedRows + " Rows " + state);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            m_SqlConnection.Open();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSearch.Enabled = true;
            btnDisplay.Enabled = true;
            btnClear.Enabled = true;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            m_SqlConnection.Close();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSearch.Enabled = false;
            btnDisplay.Enabled = false;
            btnClear.Enabled = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        // Insert Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string InsertedEmployees = "INSERT INTO Employee VALUES ("
                         + txtId.Text + ", '"
                         + txtName.Text + "', '"
                         + txtDept.Text + "')";
            //MessageBox.Show(str);

            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtDept.Text))
                {
                    MessageBox.Show("All fields are required!",
                        "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                        );
                    return;
                }

                string checkQuery = "SELECT COUNT(*) FROM Employee WHERE Id = @Id";
                m_SqlCommand.CommandText = checkQuery;
                m_SqlCommand.Parameters.Clear();
                m_SqlCommand.Parameters.AddWithValue("@Id", txtId.Text);

                int count = (int)m_SqlCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Duplicate ID",
                                       "Error",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error
                                   );
                    return;
                }

                ExecuteStatement(InsertedEmployees, "Inserted");
                MessageBox.Show(
                    "Employee added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Refresh display
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Please enter an ID to search.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                string selectQuery = "SELECT * FROM Employee WHERE Id = @Id";
                m_SqlCommand.CommandText = selectQuery;
                m_SqlCommand.Parameters.Clear();
                m_SqlCommand.Parameters.AddWithValue("@Id", txtId.Text);

                using (SqlDataReader reader = m_SqlCommand.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No record found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (reader.Read())
                    {
                        txtName.Text = reader[1]?.ToString() ?? "";
                        txtDept.Text = reader[2]?.ToString() ?? "";

                        string SearchedRecord = (int)reader[0] + "\t" + reader[1].ToString() + "\t" + reader[2].ToString();

                        listBox1.Items.Add(SearchedRecord);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtDept.Text))
                {
                    MessageBox.Show("All fields are required!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Check that record exists
                string checkQuery = "SELECT COUNT(*) FROM Employee WHERE Id = @Id";
                m_SqlCommand.CommandText = checkQuery;
                m_SqlCommand.Parameters.Clear();
                m_SqlCommand.Parameters.AddWithValue("@Id", txtId.Text);

                int count = (int)m_SqlCommand.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("No records found with the specified ID.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // update SQL parameters 
                m_SqlCommand.Parameters.Clear();
                m_SqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
                m_SqlCommand.Parameters.AddWithValue("@Dept_name", txtDept.Text);
                m_SqlCommand.Parameters.AddWithValue("@Id", txtId.Text);

                string updateQuery = "UPDATE Employee SET Name = @Name, Dept_name = @Dept_name WHERE Id = @Id";
                ExecuteStatement(updateQuery, "Updated");

                // Refresh display
                btnDisplay_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("ID is required to delete a record.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // Check for id -> Does it exist?
                string checkQuery = "SELECT COUNT(*) FROM Employee WHERE Id = @Id";
                m_SqlCommand.CommandText = checkQuery;
                m_SqlCommand.Parameters.Clear();
                m_SqlCommand.Parameters.AddWithValue("@Id", txtId.Text);

                int count = (int)m_SqlCommand.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("No record found with the specified ID.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                m_SqlCommand.Parameters.Clear();
                m_SqlCommand.Parameters.AddWithValue("@Id", txtId.Text);

                string deleteQuery = "DELETE FROM Employee WHERE Id = @Id";
                ExecuteStatement(deleteQuery, "Deleted");

                // Refresh display
                btnDisplay_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear only the Listbox
        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Refresh();
        }
    }
}
