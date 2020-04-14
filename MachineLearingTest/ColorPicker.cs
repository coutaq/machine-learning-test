using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;

namespace MachineLearningTest
{
    public partial class ColorPicker : Form
    {

        public ColorPicker()
        {
            InitializeComponent();
            
        }


        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {
            this.text.BackColor = colorWheel1.Color;
            var input = new ModelInput();
            input.Hue = colorWheel1.Color.GetHue();
            input.Brightness = colorWheel1.Color.GetBrightness();
            input.Saturation = colorWheel1.Color.GetSaturation();
            ModelOutput result = predEngine.Predict(input);

            if (result.Prediction)
                this.text.ForeColor = Color.White;
            else
                this.text.ForeColor = Color.Black;
        }
    }
}
