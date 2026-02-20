namespace Employees_ADO_SQL_Connection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv = new DataGridView();
            lblId = new Label();
            txtId = new TextBox();
            txtDept = new TextBox();
            lblDept = new Label();
            btnDisplay = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            lblName = new Label();
            txtName = new TextBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(422, 34);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(366, 271);
            dgv.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(27, 54);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(122, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(166, 27);
            txtId.TabIndex = 2;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(122, 140);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(166, 27);
            txtDept.TabIndex = 6;
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(27, 147);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(89, 20);
            lblDept.TabIndex = 5;
            lblDept.Text = "Department";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(12, 206);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 7;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(122, 206);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(222, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(322, 206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(91, 262);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(27, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 27);
            txtName.TabIndex = 4;
            // 
            // btnRefresh_Click
            // 
            btnRefresh.Location = new Point(210, 262);
            btnRefresh.Name = "btnRefresh_Click";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(btnDisplay);
            Controls.Add(txtDept);
            Controls.Add(lblDept);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "ADO.NET - Disconnected Mode";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtDept;
        private Label lblDept;
        private Button btnDisplay;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Label lblName;
        private TextBox txtName;
        private Button btnRefresh;
    }
}

