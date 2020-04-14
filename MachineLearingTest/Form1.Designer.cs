namespace MachineLearningTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.infoText = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonTry = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonWhite, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBlack, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 354);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonWhite
            // 
            this.buttonWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWhite.FlatAppearance.BorderSize = 0;
            this.buttonWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhite.Font = new System.Drawing.Font("Gotham Medium", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWhite.ForeColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(400, 3);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(391, 348);
            this.buttonWhite.TabIndex = 0;
            this.buttonWhite.Text = "WHITE";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBlack.FlatAppearance.BorderSize = 0;
            this.buttonBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlack.Font = new System.Drawing.Font("Gotham Medium", 70F);
            this.buttonBlack.ForeColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(3, 3);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(391, 348);
            this.buttonBlack.TabIndex = 1;
            this.buttonBlack.Text = "BLACK";
            this.buttonBlack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.infoText, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.total, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 84);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoText.Font = new System.Drawing.Font("Gotham Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoText.Location = new System.Drawing.Point(82, 0);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(549, 84);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "Which one looks better?";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total.Font = new System.Drawing.Font("Gotham Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.Control;
            this.total.Location = new System.Drawing.Point(3, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(73, 84);
            this.total.TabIndex = 1;
            this.total.Text = "0";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonTrain, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonTry, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(637, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(154, 78);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // buttonTrain
            // 
            this.buttonTrain.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrain.Font = new System.Drawing.Font("Gotham Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrain.ForeColor = System.Drawing.Color.White;
            this.buttonTrain.Location = new System.Drawing.Point(3, 3);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(71, 72);
            this.buttonTrain.TabIndex = 4;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = false;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonTry
            // 
            this.buttonTry.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonTry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTry.Font = new System.Drawing.Font("Gotham Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTry.ForeColor = System.Drawing.Color.White;
            this.buttonTry.Location = new System.Drawing.Point(80, 3);
            this.buttonTry.Name = "buttonTry";
            this.buttonTry.Size = new System.Drawing.Size(71, 72);
            this.buttonTry.TabIndex = 3;
            this.buttonTry.Text = "Try it out!";
            this.buttonTry.UseVisualStyleBackColor = false;
            this.buttonTry.Click += new System.EventHandler(this.buttonTry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Machine Learning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonTry;
        private System.Windows.Forms.Button buttonTrain;
    }
}

