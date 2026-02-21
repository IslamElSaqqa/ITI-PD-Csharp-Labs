namespace Connected_Model_ADO
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
            lblId = new Label();
            lblName = new Label();
            lblDept = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtDept = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnDisplay = new Button();
            btnConnect = new Button();
            btnDisconnect = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(525, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(242, 324);
            listBox1.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(89, 156);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(77, 204);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(62, 244);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(89, 20);
            lblDept.TabIndex = 3;
            lblDept.Text = "Department";
            // 
            // txtId
            // 
            txtId.Location = new Point(179, 153);
            txtId.Name = "txtId";
            txtId.Size = new Size(174, 27);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 197);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 5;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(179, 237);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(174, 27);
            txtDept.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(57, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Insert";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(166, 315);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(281, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(381, 315);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(197, 373);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(140, 29);
            btnDisplay.TabIndex = 11;
            btnDisplay.Text = "Display Records";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(89, 55);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 12;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(296, 55);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 13;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(596, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear Screen";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(btnDisplay);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDept);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblDept);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Connected_Model";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lblId;
        private Label lblName;
        private Label lblDept;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtDept;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnDisplay;
        private Button btnConnect;
        private Button btnDisconnect;
        private Button btnClear;
    }
}
