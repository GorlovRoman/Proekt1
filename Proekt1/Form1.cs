﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Proekt1
{
    public partial class Form1 : Form
    {
         List<Shape> Shapes = new List<Shape>();
         Point ShapeStart;
         bool IsShapeStart = true;
         string curFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Convert.ToString(e.X) + " | " + Convert.ToString(e.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
             if (rb_cross.Checked) Shapes.Add(new Cross(e.X, e.Y));
             if (rb_line.Checked)
             {
                 if (!IsShapeStart) ShapeStart = e.Location;
                 else Shapes.Add(new Line(ShapeStart, e.Location));
                 IsShapeStart = !IsShapeStart;
             }
             if (rb_circle.Checked)
             {
                 if (IsShapeStart) ShapeStart = e.Location;
                 else Shapes.Add(new Circle(ShapeStart, e.Location));
                 IsShapeStart = !IsShapeStart;
             }
            this.Refresh();
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape f in Shapes)
            {
                f.DrawWith(e.Graphics);
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            IsShapeStart = !IsShapeStart;
        }

        private void AddShape(Shape s)
        {
            Shapes.Add(s);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                curFile = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(curFile);
                foreach (Shape p in this.Shapes)
                {
                    p.SaveTo(sw);
                }
                sw.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                curFile = openFileDialog1.FileName;
                Shapes.Clear();
                StreamReader sr = new StreamReader(curFile);
                while (!sr.EndOfStream)
                {
                    string type = sr.ReadLine();
                    switch (type)
                    {
                        case "Cross":
                            {
                                AddShape(new Cross(sr));
                                break;
                            }
                        case "Line":
                            {
                                AddShape(new Line(sr));
                                break;
                            }
                        case "Circle":
                            {
                                AddShape(new Circle(sr));
                                break;
                            }
                    }
                }
                sr.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }

}
