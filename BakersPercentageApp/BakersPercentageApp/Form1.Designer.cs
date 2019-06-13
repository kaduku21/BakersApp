namespace BakersPercentageApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFlourWeight = new System.Windows.Forms.TextBox();
            this.txtWaterPercentage = new System.Windows.Forms.TextBox();
            this.txtSaltPercentage = new System.Windows.Forms.TextBox();
            this.txtStarterPercentage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFlourResult = new System.Windows.Forms.TextBox();
            this.txtWaterResult = new System.Windows.Forms.TextBox();
            this.txtSaltResult = new System.Windows.Forms.TextBox();
            this.txtStarterResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight of Flour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desired Percentage of Water:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desired Percentage of Salt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yeast or Starter Percentage:";
            // 
            // txtFlourWeight
            // 
            this.txtFlourWeight.Location = new System.Drawing.Point(225, 28);
            this.txtFlourWeight.Name = "txtFlourWeight";
            this.txtFlourWeight.Size = new System.Drawing.Size(100, 20);
            this.txtFlourWeight.TabIndex = 1;
            // 
            // txtWaterPercentage
            // 
            this.txtWaterPercentage.Location = new System.Drawing.Point(225, 59);
            this.txtWaterPercentage.Name = "txtWaterPercentage";
            this.txtWaterPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtWaterPercentage.TabIndex = 2;
            // 
            // txtSaltPercentage
            // 
            this.txtSaltPercentage.Location = new System.Drawing.Point(225, 90);
            this.txtSaltPercentage.Name = "txtSaltPercentage";
            this.txtSaltPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtSaltPercentage.TabIndex = 3;
            // 
            // txtStarterPercentage
            // 
            this.txtStarterPercentage.Location = new System.Drawing.Point(225, 121);
            this.txtStarterPercentage.Name = "txtStarterPercentage";
            this.txtStarterPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtStarterPercentage.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(220, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 29);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(352, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weight of Flour:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Weight of Water:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weight of Salt:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Yeast or Starter Weight:";
            // 
            // txtFlourResult
            // 
            this.txtFlourResult.Location = new System.Drawing.Point(525, 28);
            this.txtFlourResult.Name = "txtFlourResult";
            this.txtFlourResult.ReadOnly = true;
            this.txtFlourResult.Size = new System.Drawing.Size(100, 20);
            this.txtFlourResult.TabIndex = 1;
            this.txtFlourResult.TabStop = false;
            // 
            // txtWaterResult
            // 
            this.txtWaterResult.Location = new System.Drawing.Point(525, 59);
            this.txtWaterResult.Name = "txtWaterResult";
            this.txtWaterResult.ReadOnly = true;
            this.txtWaterResult.Size = new System.Drawing.Size(100, 20);
            this.txtWaterResult.TabIndex = 1;
            this.txtWaterResult.TabStop = false;
            // 
            // txtSaltResult
            // 
            this.txtSaltResult.Location = new System.Drawing.Point(525, 90);
            this.txtSaltResult.Name = "txtSaltResult";
            this.txtSaltResult.ReadOnly = true;
            this.txtSaltResult.Size = new System.Drawing.Size(100, 20);
            this.txtSaltResult.TabIndex = 1;
            this.txtSaltResult.TabStop = false;
            // 
            // txtStarterResult
            // 
            this.txtStarterResult.Location = new System.Drawing.Point(525, 121);
            this.txtStarterResult.Name = "txtStarterResult";
            this.txtStarterResult.ReadOnly = true;
            this.txtStarterResult.Size = new System.Drawing.Size(100, 20);
            this.txtStarterResult.TabIndex = 1;
            this.txtStarterResult.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(672, 208);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStarterResult);
            this.Controls.Add(this.txtStarterPercentage);
            this.Controls.Add(this.txtSaltResult);
            this.Controls.Add(this.txtSaltPercentage);
            this.Controls.Add(this.txtWaterResult);
            this.Controls.Add(this.txtWaterPercentage);
            this.Controls.Add(this.txtFlourResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFlourWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Baker\'s Percentage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFlourWeight;
        private System.Windows.Forms.TextBox txtWaterPercentage;
        private System.Windows.Forms.TextBox txtSaltPercentage;
        private System.Windows.Forms.TextBox txtStarterPercentage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFlourResult;
        private System.Windows.Forms.TextBox txtWaterResult;
        private System.Windows.Forms.TextBox txtSaltResult;
        private System.Windows.Forms.TextBox txtStarterResult;
    }
}

