using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsLab_Part2
{
    public partial class Form1 : Form
    {
        string companyName = "ABC Company";
        string annualRevenueTitle = "Annual Revenue";

        // X-axis (Years)
        string[] years =
        {
            "1988", "1989", "1990", "1991", "1992",
            "1993", "1994", "1995", "1996", "1997"
        };

        // Y-axis (Revenue)
        string[] revenue =
        {
            "150", "170", "180", "175", "200",
            "250", "210", "240", "280", "140"
        };

        Color textColor = Color.Black;
        Color lineColor = Color.Blue;

        Rectangle chartArea;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
            this.KeyPreview = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int y = 0;
            int x = this.Width - 100;

            // Titles
            y += DrawCenteredText(e.Graphics, companyName, 20, y);
            y += DrawCenteredText(e.Graphics, annualRevenueTitle, 18, y);

            // Year row
            for (int i = years.Length - 1; i >= 0; i--, x -= 70)
                DrawBox(e.Graphics, years[i], x, y, 70, 60);

            DrawBox(e.Graphics, "Year", x - 30, y, 100, 60);
            y += 60;

            // Revenue row
            x = this.Width - 100;
            for (int i = revenue.Length - 1; i >= 0; i--, x -= 70)
                DrawBox(e.Graphics, revenue[i], x, y, 70, 60);

            DrawBox(e.Graphics, "Revenue", x - 30, y, 100, 60);
            y += 60;

            // Axes
            Pen axisPen = new Pen(Color.Black, 1);
            axisPen.EndCap = LineCap.ArrowAnchor;

            Point origin = new Point(100, this.Height - 100);

            e.Graphics.DrawLine(axisPen, origin.X, origin.Y, origin.X + 1100, origin.Y);
            e.Graphics.DrawLine(axisPen, origin.X, origin.Y, origin.X, origin.Y - 900);

            // Define chart area
            chartArea = new Rectangle(origin.X, origin.Y - 900, 1100, 900);

            // Y-axis labels and grid
            Font yFont = new Font("Times New Roman", 14);
            for (int value = 140, cy = origin.Y - 50; value <= 300; value += 10, cy -= 50)
            {
                e.Graphics.DrawString(value.ToString(), yFont, Brushes.Black, origin.X - 60, cy - 12);
                e.Graphics.DrawLine(Pens.Black, origin.X - 8, cy, origin.X + 1005, cy);
            }

            // Red bars
            Pen barPen = new Pen(Color.Red, 5);

            for (int i = 0, cx = origin.X; i < revenue.Length; i++, cx += 100)
            {
                int value = int.Parse(revenue[i]);
                int barHeight = (value - 140 + 10) * 5;

                e.Graphics.DrawLine(barPen,
                    cx + 100,
                    origin.Y,
                    cx + 100,
                    origin.Y - barHeight);

                e.Graphics.DrawString(
                    years[i],
                    new Font("Times New Roman", 14),
                    Brushes.Black,
                    cx + 70,
                    origin.Y + 10);
            }

            // Line graph
            Pen linePen = new Pen(lineColor, 3);

            int prevX = origin.X + 100;
            int prevY = origin.Y - (int.Parse(revenue[0]) - 140 + 10) * 5;

            for (int i = 1; i < revenue.Length; i++)
            {
                int currX = origin.X + 100 + i * 100;
                int currY = origin.Y - (int.Parse(revenue[i]) - 140 + 10) * 5;

                e.Graphics.DrawLine(linePen, prevX, prevY, currX, currY);

                prevX = currX;
                prevY = currY;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Control && e.KeyCode == Keys.R)
                lineColor = Color.Red;
            else if (e.Control && e.KeyCode == Keys.G)
                lineColor = Color.Green;
            else if (e.Control && e.KeyCode == Keys.B)
                lineColor = Color.Blue;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button != MouseButtons.Left)
                return;

            if (!chartArea.Contains(e.Location))
                return;

            Point origin = new Point(100, this.Height - 100);

            for (int i = 0; i < revenue.Length; i++)
            {
                int px = origin.X + 100 + i * 100;
                int py = origin.Y - (int.Parse(revenue[i]) - 140 + 10) * 5;

                Rectangle hitBox = new Rectangle(px - 6, py - 6, 12, 12);

                if (hitBox.Contains(e.Location))
                {
                    MessageBox.Show(
                        $"Year: {years[i]}\nRevenue: {revenue[i]}",
                        "Revenue Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }
        }

        int DrawCenteredText(Graphics g, string text, int fontSize, int y)
        {
            Font font = new Font("Times New Roman", fontSize);
            Rectangle rect = new Rectangle(0, y, this.Width, fontSize * 2);

            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                FormatFlags = StringFormatFlags.NoWrap
            };

            g.DrawString(text, font, Brushes.Black, rect, format);
            return fontSize * 2;
        }

        void DrawBox(Graphics g, string text, int x, int y, int w, int h)
        {
            Pen pen = new Pen(Color.Black, 3);
            Font font = new Font("Times New Roman", 14);

            Rectangle rect = new Rectangle(x, y, w, h);

            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                FormatFlags = StringFormatFlags.NoWrap
            };

            g.DrawRectangle(pen, rect);
            g.DrawString(text, font, Brushes.Black, rect, format);
        }
    }
}
