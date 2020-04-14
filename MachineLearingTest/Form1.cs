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
        private String info = "White, Hue, Saturation, Brightness\n";
        private int totalNums = 0;
        Trainer trainer;
        public Form1() 
        {
            InitializeComponent();
            newColor(); 
            trainer = new Trainer();
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

        private void buttonTry_Click(object sender, EventArgs e)
        {
            new ColorPicker().Show();
            this.Close();
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
             using (System.IO.StreamWriter file =
                 new System.IO.StreamWriter(Program.dataPath))
             {
                 file.Write(info);
            }
            trainer.Show();
            this.Close();
        }
    }
}
