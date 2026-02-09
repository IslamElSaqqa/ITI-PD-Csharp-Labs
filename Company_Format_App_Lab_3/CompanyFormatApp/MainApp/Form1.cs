namespace CompanyFormatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatDialog dlg = new FormatDialog();

            // pass current values to dialog
            dlg.SelectedFont = lblCompany.Font;
            dlg.SelectedColor = lblCompany.ForeColor;
            dlg.OldTxtValue = lblCompany.Text;

            // show dialog and apply changes only if OK
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lblCompany.Font = dlg.SelectedFont;
                lblCompany.ForeColor = dlg.SelectedColor;
                lblCompany.Text = dlg.NewTxtValue;
            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
