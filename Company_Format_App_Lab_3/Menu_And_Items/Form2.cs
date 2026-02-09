using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyFormatApp
{
    public partial class FormatDialog : Form
    {

        // Auto implemented Named Properties

        public Font SelectedFont { get; set; }
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SelectedColor { get; set; }
        public string OldTxtValue { get; set; }
        public string NewTxtValue { get; set; }




        public FormatDialog()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog1.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // font name and fontsize (Nested Ternary Expressions)
            string FontName = rbArial.Checked ? "Arial" :
                rbTimes.Checked ? "Times New Roman" : "Courier New";

            float FontSize = rb16.Checked ? 16.0f :
                rb20.Checked ? 20.0f : 24.0f;

            // selected font
            SelectedFont = new Font(FontName, FontSize);

            // setting new txt Value on btnClicked ok
            NewTxtValue = txtNew.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormatDialog_Load(object sender, EventArgs e)
        {
            // Text tab
            txtOld.Text = OldTxtValue;
            txtNew.Text = OldTxtValue;

            // Font name
            if (SelectedFont.Name == "Arial")
                rbArial.Checked = true;
            else if (SelectedFont.Name == "Times New Roman")
                rbTimes.Checked = true;
            else
                rbCourier.Checked = true;

            // Font size
            if (SelectedFont.Size == 16)
                rb16.Checked = true;
            else if (SelectedFont.Size == 20)
                rb20.Checked = true;
            else
                rb24.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
