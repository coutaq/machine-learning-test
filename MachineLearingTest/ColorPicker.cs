using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningTestML.Model;

namespace MachineLearingTest
{
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        private void colorEditor1_ColorChanged(object sender, EventArgs e)
        {
            this.text.BackColor = colorEditor1.Color;
            MlContext mlContext = new MlContext();
            var predEngine = mlContext.Model.CreatePredictionEngine<SentimentIssue, SentimentPrediction>(trainedModel);
            var resultprediction = predEngine.Predict(sampleStatement);
        }
    }
}
