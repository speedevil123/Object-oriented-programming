
using System.Drawing.Drawing2D;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }

        bool BrushUsed = false;
        int brushSize = 5;
        int x_prev, y_prev;
        bool solidBrushUsed = false, hatchBrushHorizontalUsed = false, hatchBrushZigZagUsed = false;
        Color color;
        HatchStyle style = HatchStyle.Horizontal;
        SolidBrush solidbrush = new SolidBrush(Color.Black);
        HatchBrush hatchbrush;
        Image image;

        int figureSize = 30;
        bool squareCheck = false, ellipseCheck = false;
        int figureX, figureY;
        Pen figurePen = new Pen(Color.Black, 3f);


        bool penUsed = true;
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);

            graphics = Graphics.FromImage(map);

            figurePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            figurePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }

            public void ResetPoints()
            {
                index = 0;
            }

            public int GetCountPoints()
            {
                return index;
            }

            public Point[] GetPoints()
            {
                return points;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            x_prev = e.X;
            y_prev = e.Y;
            arrayPoints.ResetPoints();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            if (squareCheck)
            {
                graphics.DrawRectangle(figurePen, e.X - (figureSize / 2), e.Y - (figureSize / 2), figureSize, figureSize);
                pictureBox1.Image = map;
                squareCheck = false;
            }
            if (ellipseCheck)
            {
                graphics.DrawEllipse(figurePen, e.X - (figureSize / 2), e.Y - (figureSize / 2), figureSize, figureSize);
                pictureBox1.Image = map;
                ellipseCheck = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }
            arrayPoints.SetPoint(e.X, e.Y);

            if (BrushUsed)
            {
                int distance = Math.Max(Math.Abs(e.X - x_prev), Math.Abs(e.Y - y_prev));
                for (int i = 0; i < distance; i++)
                {
                    float t = (float)i / distance;
                    int x = (int)(x_prev * (1 - t) + e.X * t);
                    int y = (int)(y_prev * (1 - t) + e.Y * t);
                    if (solidBrushUsed)
                        graphics.FillEllipse(solidbrush, x - (brushSize / 2), y - (brushSize / 2), brushSize, brushSize);
                    else
                        graphics.FillEllipse(hatchbrush, x - (brushSize / 2), y - (brushSize / 2), brushSize, brushSize);
                }
                pictureBox1.Image = map;
                x_prev = e.X;
                y_prev = e.Y;
            }
            if (penUsed && arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            color = ((Button)sender).BackColor;

            solidbrush.Color = color;
            pen.Color = color;
            figurePen.Color = color;

            hatchbrush = new HatchBrush(style, color);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;

                hatchbrush = new HatchBrush(style, color);
                pen.Color = color;
                ((Button)sender).BackColor = color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            figureSize = trackBar1.Value + 30;
            brushSize = trackBar1.Value - 20;
            pen.Width = trackBar1.Value - 25f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                graphics.Clear(pictureBox1.BackColor);
                pictureBox1.Image = map;

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                graphics.DrawImage(pictureBox1.Image, 0, 0);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            squareCheck = true;
            ellipseCheck = false;
            BrushUsed = false;
            penUsed = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BrushUsed = false;
            pen.DashStyle = DashStyle.Solid;

            squareCheck = false;
            ellipseCheck = false;
            penUsed = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BrushUsed = false;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            squareCheck = false;
            ellipseCheck = false;
            penUsed = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BrushUsed = false;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            squareCheck = false;
            ellipseCheck = false;
            penUsed = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BrushUsed = false;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

            squareCheck = false;
            ellipseCheck = false;
            penUsed = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            BrushUsed = true;
            //solid
            solidBrushUsed = true;
            hatchBrushHorizontalUsed = false;
            hatchBrushZigZagUsed = false;

            squareCheck = false;
            ellipseCheck = false;
            penUsed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            BrushUsed = true;
            solidBrushUsed = false;
            style = HatchStyle.Horizontal;
            hatchbrush = new HatchBrush(style, color);

            squareCheck = false;
            ellipseCheck = false;
            penUsed = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BrushUsed = true;
            solidBrushUsed = false;
            style = HatchStyle.ZigZag;
            hatchbrush = new HatchBrush(style, color);

            squareCheck = false;
            ellipseCheck = false;
            penUsed = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            squareCheck = false;
            ellipseCheck = true;
            BrushUsed = false;
            penUsed = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Paint");
        }
    }
}