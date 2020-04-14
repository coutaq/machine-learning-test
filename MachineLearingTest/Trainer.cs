using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningTest
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while(progressBar1.Value<progressBar1.Maximum)
            {
                Thread.Sleep(100);
                this.backgroundWorker1.ReportProgress(0);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
                this.progressBar1.Value++;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar1.Value = this.progressBar1.Maximum;
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ModelBuilder.CreateModel));
            t.Start();
            this.backgroundWorker1.RunWorkerAsync();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ColorPicker().Show();
            this.Close();
        }
    }
}
