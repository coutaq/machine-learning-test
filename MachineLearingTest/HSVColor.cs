using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningTest
{
    public class HSBColor
    {
        private float hue;
        private float saturation;
        private float brightness;

        public HSBColor()
        {

        }

        public HSBColor(float _hue, float _saturation, float _brightness)
        {
            this.hue = _hue;
            this.saturation = _saturation;
            this.brightness = _brightness;
        }
    }
}
