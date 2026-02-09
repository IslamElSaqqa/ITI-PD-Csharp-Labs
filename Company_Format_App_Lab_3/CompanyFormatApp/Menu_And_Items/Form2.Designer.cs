namespace CompanyFormatApp
{
    partial class FormatDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rbCourier = new RadioButton();
            rbArial = new RadioButton();
            rbTimes = new RadioButton();
            tabPage2 = new TabPage();
            rb24 = new RadioButton();
            rb20 = new RadioButton();
            rb16 = new RadioButton();
            tabPage3 = new TabPage();
            btn_Color = new Button();
            tabPage4 = new TabPage();
            btnCancel = new Button();
            btnOk = new Button();
            label2 = new Label();
            txtNew = new TextBox();
            label1 = new Label();
            txtOld = new TextBox();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 400);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rbCourier);
            tabPage1.Controls.Add(rbArial);
            tabPage1.Controls.Add(rbTimes);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Font";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbCourier
            // 
            rbCourier.AutoSize = true;
            rbCourier.Location = new Point(18, 61);
            rbCourier.Name = "rbCourier";
            rbCourier.Size = new Size(112, 24);
            rbCourier.TabIndex = 2;
            rbCourier.TabStop = true;
            rbCourier.Text = "Courier New";
            rbCourier.UseVisualStyleBackColor = true;
            rbCourier.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rbArial
            // 
            rbArial.AutoSize = true;
            rbArial.Location = new Point(18, 31);
            rbArial.Name = "rbArial";
            rbArial.Size = new Size(61, 24);
            rbArial.TabIndex = 1;
            rbArial.TabStop = true;
            rbArial.Text = "Arial";
            rbArial.UseVisualStyleBackColor = true;
            // 
            // rbTimes
            // 
            rbTimes.AutoSize = true;
            rbTimes.Location = new Point(18, 3);
            rbTimes.Name = "rbTimes";
            rbTimes.Size = new Size(148, 24);
            rbTimes.TabIndex = 0;
            rbTimes.TabStop = true;
            rbTimes.Text = "Time New Roman";
            rbTimes.UseVisualStyleBackColor = true;
            rbTimes.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rb24);
            tabPage2.Controls.Add(rb20);
            tabPage2.Controls.Add(rb16);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Size";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb24
            // 
            rb24.AutoSize = true;
            rb24.Location = new Point(72, 76);
            rb24.Name = "rb24";
            rb24.Size = new Size(46, 24);
            rb24.TabIndex = 2;
            rb24.TabStop = true;
            rb24.Text = "24";
            rb24.UseVisualStyleBackColor = true;
            // 
            // rb20
            // 
            rb20.AutoSize = true;
            rb20.Location = new Point(72, 46);
            rb20.Name = "rb20";
            rb20.Size = new Size(46, 24);
            rb20.TabIndex = 1;
            rb20.TabStop = true;
            rb20.Text = "20";
            rb20.UseVisualStyleBackColor = true;
            // 
            // rb16
            // 
            rb16.AutoSize = true;
            rb16.Location = new Point(72, 16);
            rb16.Name = "rb16";
            rb16.Size = new Size(46, 24);
            rb16.TabIndex = 0;
            rb16.TabStop = true;
            rb16.Text = "16";
            rb16.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_Color);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(795, 367);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Color";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Color
            // 
            btn_Color.Location = new Point(123, 23);
            btn_Color.Name = "btn_Color";
            btn_Color.Size = new Size(135, 33);
            btn_Color.TabIndex = 0;
            btn_Color.Text = "Choose Color";
            btn_Color.UseVisualStyleBackColor = true;
            btn_Color.Click += btnColor_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnCancel);
            tabPage4.Controls.Add(btnOk);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(txtNew);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(txtOld);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(795, 367);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Text";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(525, 180);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(385, 180);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 36);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 103);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "New Value";
            // 
            // txtNew
            // 
            txtNew.Location = new Point(433, 100);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(196, 27);
            txtNew.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 56);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Old Value";
            label1.Click += label1_Click;
            // 
            // txtOld
            // 
            txtOld.Location = new Point(433, 53);
            txtOld.Name = "txtOld";
            txtOld.ReadOnly = true;
            txtOld.Size = new Size(200, 27);
            txtOld.TabIndex = 0;
            txtOld.Text = "TxtOld";
            txtOld.TextChanged += textBox1_TextChanged;
            // 
            // FormatDialog
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormatDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormatDialog";
            Load += FormatDialog_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private RadioButton rbCourier;
        private RadioButton rbArial;
        private RadioButton rbTimes;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton rb16;
        private RadioButton rb20;
        private RadioButton rb24;
        private Button btn_Color;
        private TextBox txtOld;
        private ColorDialog colorDialog1;
        private Label label1;
        private Label label2;
        private TextBox txtNew;
        private Button btnOk;
        private Button btnCancel;
    }
}