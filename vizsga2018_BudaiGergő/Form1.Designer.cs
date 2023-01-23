namespace vizsga2018_BudaiGergő
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
            this.buttonBal = new System.Windows.Forms.Button();
            this.buttonJobb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBal
            // 
            this.buttonBal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBal.BackgroundImage")));
            this.buttonBal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBal.Location = new System.Drawing.Point(369, 450);
            this.buttonBal.Name = "buttonBal";
            this.buttonBal.Size = new System.Drawing.Size(79, 57);
            this.buttonBal.TabIndex = 0;
            this.buttonBal.UseVisualStyleBackColor = true;
            this.buttonBal.Click += new System.EventHandler(this.buttonBal_Click);
            // 
            // buttonJobb
            // 
            this.buttonJobb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonJobb.BackgroundImage")));
            this.buttonJobb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonJobb.Location = new System.Drawing.Point(581, 450);
            this.buttonJobb.Name = "buttonJobb";
            this.buttonJobb.Size = new System.Drawing.Size(79, 57);
            this.buttonJobb.TabIndex = 1;
            this.buttonJobb.UseVisualStyleBackColor = true;
            this.buttonJobb.Click += new System.EventHandler(this.buttonJobb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 597);
            this.Controls.Add(this.buttonJobb);
            this.Controls.Add(this.buttonBal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBal;
        private System.Windows.Forms.Button buttonJobb;
    }
}

