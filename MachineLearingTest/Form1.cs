using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningTestML.Model;

namespace MachineLearningTest
{
    public partial class Form1 : Form
    {
        private String info = "White, Hue, Saturation, Brightness\n";
        private int totalNums = 0;
        public Form1() 
        {
            InitializeComponent();
            newColor();
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            Color buttonColor = buttonBlack.BackColor;
            info += 0 + "," + buttonColor.GetHue() + "," + buttonColor.GetSaturation() + "," + buttonColor.GetBrightness() + "\n";
            totalNums++;
            total.Text = totalNums.ToString();
            newColor();
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            Color buttonColor = buttonWhite.BackColor;
            info += 1+","+buttonColor.GetHue() + "," + buttonColor.GetSaturation() + "," + buttonColor.GetBrightness() + "\n";
            totalNums++;
            total.Text = totalNums.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            /* using (System.IO.StreamWriter file =
                 new System.IO.StreamWriter(@".\info.csv"))
             {
                 file.Write(info);
             }*/
            // Add input data
            new MachineLearingTest.ColorPicker().Show();
            this.Close();
        }
    }
}
