namespace WinForms_EFCore_Employee_Records
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
            listBox1 = new ListBox();
            lbld = new Label();
            lblName = new Label();
            lblDept = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDisplay = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDept = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(520, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(268, 284);
            listBox1.TabIndex = 0;
            // 
            // lbld
            // 
            lbld.AutoSize = true;
            lbld.Location = new Point(96, 145);
            lbld.Name = "lbld";
            lbld.Size = new Size(24, 20);
            lbld.TabIndex = 1;
            lbld.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(87, 189);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(78, 240);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(86, 20);
            lblDept.TabIndex = 3;
            lblDept.Text = "Dept Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(146, 294);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(263, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(384, 294);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 7;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(193, 141);
            txtId.Name = "txtId";
            txtId.Size = new Size(164, 27);
            txtId.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 186);
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 27);
            txtName.TabIndex = 9;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(193, 233);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(164, 27);
            txtDept.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDept);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnDisplay);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblDept);
            Controls.Add(lblName);
            Controls.Add(lbld);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "EFCore-Employee-Records";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lbld;
        private Label lblName;
        private Label lblDept;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDisplay;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDept;
    }
}
