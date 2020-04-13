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

namespace MachineLearningTest
{
    public partial class Form1 : Form
    {
        private String info;
        private int totalNums = 0;
        public Form1() 
        {
            InitializeComponent();
            newColor();
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            Color buttonColor = buttonBlack.BackColor;
            info += buttonColor.GetHue()+"\t"+buttonColor.GetSaturation()+"\t"+buttonColor.GetBrightness()+"\t"+"0\n";
            totalNums++;
            total.Text = totalNums.ToString();
            newColor();
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            Color buttonColor = buttonWhite.BackColor;
            info += buttonColor.GetHue() + "\t" + buttonColor.GetSaturation() + "\t" + buttonColor.GetBrightness() + "\t" + "1\n";
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
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@".\info.tsv"))
            {
                file.Write(info);
            }
        }
    }
}
