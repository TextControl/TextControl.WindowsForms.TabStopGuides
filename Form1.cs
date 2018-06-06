using System;
using System.Drawing;
using System.Windows.Forms;

namespace TabStop_Guides
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textControl1.RulerBar = rulerBar2;
            textControl1.VerticalRulerBar = rulerBar1;
            textControl1.Load(
                "Demo.rtf",
                TXTextControl.StreamType.RichTextFormat, 
                new TXTextControl.LoadSettings {
                    ApplicationFieldFormat = TXTextControl.ApplicationFieldFormat.MSWord
                });
        }

        private void rulerBar2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textControl1.CreateGraphics().DrawLine(
                    Pens.Black,
                    e.X, 
                    0, 
                    e.X , 
                    textControl1.Height
                    );
            }
        }

        private void rulerBar2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textControl1.Refresh();
            }
        }

        private void rulerBar2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                textControl1.Refresh();
                textControl1.CreateGraphics().DrawLine(
                    Pens.Black, 
                    e.X , 
                    0, 
                    e.X, 
                    textControl1.Height
                    );
            }
        }
    }
}
