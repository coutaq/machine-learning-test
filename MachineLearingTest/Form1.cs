using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningTest
{
    public partial class Form1 : Form
    {
        List<HSBColor> blacks = new List<HSBColor>();
        List<HSBColor> whites = new List<HSBColor>();
        public Form1()
        {
            InitializeComponent();
            newColor();
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            Color buttonColor = buttonBlack.BackColor;
            blacks.Add(new HSBColor(buttonColor.GetHue(), buttonColor.GetSaturation(), buttonColor.GetBrightness()));
            newColor();
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            Color buttonColor = buttonWhite.BackColor;
            whites.Add(new HSBColor(buttonColor.GetHue(), buttonColor.GetSaturation(), buttonColor.GetBrightness()));
            newColor();
        }

        private void newColor()
        {
            Random r = new Random();
            Color newColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            buttonWhite.BackColor = newColor;
            buttonWhite.FlatAppearance.MouseOverBackColor = newColor;
            buttonBlack.BackColor = newColor;
            buttonBlack.FlatAppearance.MouseOverBackColor = newColor;
        }

    }
}
