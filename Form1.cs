using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointerAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare variables
        int x;
        int y;
        //This button code will run the commands
        private void btnRun_Click(object sender, EventArgs e)
        {
            int p1, p2;
            //You can move the pen from these points by changing their value
            p1 = 150;
            p2 = 150;
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
            //Call method to draw on points
            drawTo(p1,p2);
         
        }
       void clear()
        {
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            panel4.Controls.Clear();
        }
        //This is the method. 
        void Commands(PaintEventArgs e)
        {

            //Use Graphics class to create graphics in the panel
            Graphics g = panel1.CreateGraphics();
            //Choose pen color
            Pen p = new Pen(Color.Black);
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            if (txtCommand.Text == "triangle" || txtCommand.Text == "Triangle" || txtCommand.Text == "TRIANGLE")
            {
                //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                // Create solid brush.
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                g = e.Graphics;

                //first have to define an array of points.
                Point[] pnt = new Point[3];
                //Initialize Point array elements
                pnt[0].X = 150;
                pnt[0].Y = 150;

                pnt[1].X = 150;
                pnt[1].Y = 200;

                pnt[2].X = 50;
                pnt[2].Y = 120;
                //Draw the triangle
                g.DrawPolygon(p, pnt);
                //Fill the triangle
                g.FillPolygon(blueBrush, pnt);
            }
            //This code used to draw circle within the panel
            else if (txtCommand.Text == "circle" || txtCommand.Text == "Circle" || txtCommand.Text == "CIRCLE")
            { //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill circle
                SolidBrush sb = new SolidBrush(Color.Red);
                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to draw rectangle within the panel
            else if (txtCommand.Text == "rectangle" || txtCommand.Text == "Rectangle" || txtCommand.Text == "RECTANGLE")
            {//Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill Rectable
                SolidBrush sb = new SolidBrush(Color.Blue);
                //Draw Rectangle
                g.DrawRectangle(p, x - 50, y - 50, 100, 100);
                //Fill the rectangle
                g.FillRectangle(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to drawing area
            else if (txtCommand.Text == "clear" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                //Clear the panel
                panel1.Controls.Clear();
            }
            else if (txtCommand.Text == "pen draw" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                Pen p1 = new Pen(Color.Red, 10);
                p.StartCap = LineCap.RoundAnchor;

                p.EndCap = LineCap.Square;

                g.DrawLine(p, 50, 100, 400, 100);
            }
        }

        void LoopCommands1(PaintEventArgs e)
        {
            //Use Graphics class to create graphics in the panel
            Graphics g = panel2.CreateGraphics();
            //Choose pen color
            Pen p = new Pen(Color.Black);
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            if (txtCommand.Text == "triangle" || txtCommand.Text == "Triangle" || txtCommand.Text == "TRIANGLE")
            {
                //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                // Create solid brush.
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                g = e.Graphics;

                //first have to define an array of points.
                Point[] pnt = new Point[3];
                //Initialize Point array elements
                pnt[0].X = 150;
                pnt[0].Y = 150;

                pnt[1].X = 150;
                pnt[1].Y = 200;

                pnt[2].X = 50;
                pnt[2].Y = 120;
                //Draw the triangle
                g.DrawPolygon(p, pnt);
                //Fill the triangle
                g.FillPolygon(blueBrush, pnt);
            }
            //This code used to draw circle within the panel
            else if (txtCommand.Text == "circle" || txtCommand.Text == "Circle" || txtCommand.Text == "CIRCLE")
            { //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill circle
                SolidBrush sb = new SolidBrush(Color.Red);
                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to draw rectangle within the panel
            else if (txtCommand.Text == "rectangle" || txtCommand.Text == "Rectangle" || txtCommand.Text == "RECTANGLE")
            {//Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill Rectable
                SolidBrush sb = new SolidBrush(Color.Blue);
                //Draw Rectangle
                g.DrawRectangle(p, x - 50, y - 50, 100, 100);
                //Fill the rectangle
                g.FillRectangle(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to drawing area
            else if (txtCommand.Text == "clear" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                //Clear the panel
                panel1.Controls.Clear();
            }
            else if (txtCommand.Text == "pen draw" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                Pen p1 = new Pen(Color.Red, 10);
                p.StartCap = LineCap.RoundAnchor;

                p.EndCap = LineCap.Square;

                g.DrawLine(p, 50, 100, 400, 100);
            }
        }
        void LoopCommands2(PaintEventArgs e)
        {
            //Use Graphics class to create graphics in the panel
            Graphics g = panel3.CreateGraphics();
            //Choose pen color
            Pen p = new Pen(Color.Black);
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            if (txtCommand.Text == "triangle" || txtCommand.Text == "Triangle" || txtCommand.Text == "TRIANGLE")
            {
                //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                // Create solid brush.
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                g = e.Graphics;

                //first have to define an array of points.
                Point[] pnt = new Point[3];
                //Initialize Point array elements
                pnt[0].X = 150;
                pnt[0].Y = 150;

                pnt[1].X = 150;
                pnt[1].Y = 200;

                pnt[2].X = 50;
                pnt[2].Y = 120;
                //Draw the triangle
                g.DrawPolygon(p, pnt);
                //Fill the triangle
                g.FillPolygon(blueBrush, pnt);
            }
            //This code used to draw circle within the panel
            else if (txtCommand.Text == "circle" || txtCommand.Text == "Circle" || txtCommand.Text == "CIRCLE")
            { //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill circle
                SolidBrush sb = new SolidBrush(Color.Red);
                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to draw rectangle within the panel
            else if (txtCommand.Text == "rectangle" || txtCommand.Text == "Rectangle" || txtCommand.Text == "RECTANGLE")
            {//Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill Rectable
                SolidBrush sb = new SolidBrush(Color.Blue);
                //Draw Rectangle
                g.DrawRectangle(p, x - 50, y - 50, 100, 100);
                //Fill the rectangle
                g.FillRectangle(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to drawing area
            else if (txtCommand.Text == "clear" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                //Clear the panel
                panel1.Controls.Clear();
            }
            else if (txtCommand.Text == "pen draw" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                Pen p1 = new Pen(Color.Red, 10);
                p.StartCap = LineCap.RoundAnchor;

                p.EndCap = LineCap.Square;

                g.DrawLine(p, 50, 100, 400, 100);
            }
        }
        void LoopCommands3(PaintEventArgs e)
        {
            //Use Graphics class to create graphics in the panel
            Graphics g = panel4.CreateGraphics();
            //Choose pen color
            Pen p = new Pen(Color.Black);
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            //This code used to draw triangle within the panel
            if (txtCommand.Text == "triangle" || txtCommand.Text == "Triangle" || txtCommand.Text == "TRIANGLE")
            {
                //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                // Create solid brush.
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                g = e.Graphics;

                //first have to define an array of points.
                Point[] pnt = new Point[3];
                //Initialize Point array elements
                pnt[0].X = 150;
                pnt[0].Y = 150;

                pnt[1].X = 150;
                pnt[1].Y = 200;

                pnt[2].X = 50;
                pnt[2].Y = 120;
                //Draw the triangle
                g.DrawPolygon(p, pnt);
                //Fill the triangle
                g.FillPolygon(blueBrush, pnt);
            }
            //This code used to draw circle within the panel
            else if (txtCommand.Text == "circle" || txtCommand.Text == "Circle" || txtCommand.Text == "CIRCLE")
            { //Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill circle
                SolidBrush sb = new SolidBrush(Color.Red);
                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to draw rectangle within the panel
            else if (txtCommand.Text == "rectangle" || txtCommand.Text == "Rectangle" || txtCommand.Text == "RECTANGLE")
            {//Append commands in the box
                richTextBox1.AppendText(">> drawTo(" + txtCommand.Text + ")");
                //Use SolidBrush class to draw and fill Rectable
                SolidBrush sb = new SolidBrush(Color.Blue);
                //Draw Rectangle
                g.DrawRectangle(p, x - 50, y - 50, 100, 100);
                //Fill the rectangle
                g.FillRectangle(sb, x - 50, y - 50, 100, 100);
            }
            //This code used to drawing area
            else if (txtCommand.Text == "clear" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                //Clear the panel
                panel1.Controls.Clear();
            }
            else if (txtCommand.Text == "pen draw" || txtCommand.Text == "Clear" || txtCommand.Text == "CLEAR")
            {
                Pen p1 = new Pen(Color.Red, 10);
                p.StartCap = LineCap.RoundAnchor;

                p.EndCap = LineCap.Square;

                g.DrawLine(p, 50, 100, 400, 100);
            }
        }
        public int drawTo(int a, int b)
        {

            //Use point class
            Point p = new Point(a, b);
            //Initialize x point
            x= p.X;
            //Initialize y point
            y = p.Y;
            //Invalidate the drawing area
            panel1.Invalidate();
            return 0;
        }
        //The following code will use to draw different shapes on the screen
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Commands(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<4;i++)
            {
                //Use point class
                Point p = new Point(150, 150);
                //Initialize x point
                x = p.X;
                //Initialize y point
                y = p.Y;
                //Invalidate the drawing area
             
                //Call method to draw on points
                //drawTo(150, 150);
            }
            panel1.Invalidate();
            panel3.Invalidate();
            panel2.Invalidate();
            panel4.Invalidate();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            LoopCommands2(e);
            Commands(e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LoopCommands1(e);
          
            Commands(e);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            LoopCommands3(e);
          
            Commands(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}

