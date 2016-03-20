namespace Lunar_Lander
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picPlatform = new System.Windows.Forms.PictureBox();
            this.panelScore = new System.Windows.Forms.Panel();
            this.labelDx = new System.Windows.Forms.Label();
            this.labelDy = new System.Windows.Forms.Label();
            this.labelLanders = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.picLander = new System.Windows.Forms.PictureBox();
            this.myPics = new System.Windows.Forms.ImageList(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLander)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picPlatform
            // 
            this.picPlatform.Location = new System.Drawing.Point(298, 12);
            this.picPlatform.Name = "picPlatform";
            this.picPlatform.Size = new System.Drawing.Size(100, 50);
            this.picPlatform.TabIndex = 0;
            this.picPlatform.TabStop = false;
            // 
            // panelScore
            // 
            this.panelScore.Location = new System.Drawing.Point(539, 12);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(200, 100);
            this.panelScore.TabIndex = 1;
            // 
            // labelDx
            // 
            this.labelDx.AutoSize = true;
            this.labelDx.Location = new System.Drawing.Point(12, 99);
            this.labelDx.Name = "labelDx";
            this.labelDx.Size = new System.Drawing.Size(35, 13);
            this.labelDx.TabIndex = 2;
            this.labelDx.Text = "label1";
            // 
            // labelDy
            // 
            this.labelDy.AutoSize = true;
            this.labelDy.Location = new System.Drawing.Point(12, 120);
            this.labelDy.Name = "labelDy";
            this.labelDy.Size = new System.Drawing.Size(35, 13);
            this.labelDy.TabIndex = 3;
            this.labelDy.Text = "label1";
            // 
            // labelLanders
            // 
            this.labelLanders.AutoSize = true;
            this.labelLanders.Location = new System.Drawing.Point(12, 144);
            this.labelLanders.Name = "labelLanders";
            this.labelLanders.Size = new System.Drawing.Size(35, 13);
            this.labelLanders.TabIndex = 4;
            this.labelLanders.Text = "label1";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(12, 169);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(35, 13);
            this.labelFuel.TabIndex = 5;
            this.labelFuel.Text = "label1";
            // 
            // picLander
            // 
            this.picLander.Location = new System.Drawing.Point(172, 12);
            this.picLander.Name = "picLander";
            this.picLander.Size = new System.Drawing.Size(100, 50);
            this.picLander.TabIndex = 6;
            this.picLander.TabStop = false;
            // 
            // myPics
            // 
            this.myPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myPics.ImageStream")));
            this.myPics.TransparentColor = System.Drawing.Color.Transparent;
            this.myPics.Images.SetKeyName(0, "LanderWithNoFlames.png");
            this.myPics.Images.SetKeyName(1, "LanderWithFlames.png");
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 194);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 474);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.picLander);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelLanders);
            this.Controls.Add(this.labelDy);
            this.Controls.Add(this.labelDx);
            this.Controls.Add(this.panelScore);
            this.Controls.Add(this.picPlatform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lunar Lander";
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLander)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picPlatform;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Label labelDx;
        private System.Windows.Forms.Label labelDy;
        private System.Windows.Forms.Label labelLanders;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.PictureBox picLander;
        private System.Windows.Forms.ImageList myPics;
        private System.Windows.Forms.Label labelScore;
    }
}

