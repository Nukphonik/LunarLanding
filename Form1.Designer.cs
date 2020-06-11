namespace LunarLanding
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
            this.labelLx = new System.Windows.Forms.Label();
            this.labelDy = new System.Windows.Forms.Label();
            this.labelShips = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.picLander = new System.Windows.Forms.PictureBox();
            this.MyPics = new System.Windows.Forms.ImageList(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLander)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // picPlatform
            // 
            this.picPlatform.Location = new System.Drawing.Point(688, 13);
            this.picPlatform.Name = "picPlatform";
            this.picPlatform.Size = new System.Drawing.Size(100, 50);
            this.picPlatform.TabIndex = 0;
            this.picPlatform.TabStop = false;
            this.picPlatform.Click += new System.EventHandler(this.PicPlatform_Click);
            // 
            // panelScore
            // 
            this.panelScore.Location = new System.Drawing.Point(107, 13);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(509, 306);
            this.panelScore.TabIndex = 1;
            this.panelScore.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelScore_Paint);
            // 
            // labelLx
            // 
            this.labelLx.AutoSize = true;
            this.labelLx.Location = new System.Drawing.Point(12, 26);
            this.labelLx.Name = "labelLx";
            this.labelLx.Size = new System.Drawing.Size(42, 13);
            this.labelLx.TabIndex = 2;
            this.labelLx.Text = "Label 1";
            // 
            // labelDy
            // 
            this.labelDy.AutoSize = true;
            this.labelDy.Location = new System.Drawing.Point(12, 50);
            this.labelDy.Name = "labelDy";
            this.labelDy.Size = new System.Drawing.Size(0, 13);
            this.labelDy.TabIndex = 3;
            this.labelDy.Click += new System.EventHandler(this.LabelDy_Click);
            // 
            // labelShips
            // 
            this.labelShips.AutoSize = true;
            this.labelShips.Location = new System.Drawing.Point(12, 72);
            this.labelShips.Name = "labelShips";
            this.labelShips.Size = new System.Drawing.Size(42, 13);
            this.labelShips.TabIndex = 4;
            this.labelShips.Text = "Label 3";
            this.labelShips.Click += new System.EventHandler(this.LabelShips_Click);
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(12, 98);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(42, 13);
            this.labelFuel.TabIndex = 5;
            this.labelFuel.Text = "Label 4";
            this.labelFuel.Click += new System.EventHandler(this.LabelFuel_Click);
            // 
            // picLander
            // 
            this.picLander.Location = new System.Drawing.Point(636, 205);
            this.picLander.Name = "picLander";
            this.picLander.Size = new System.Drawing.Size(100, 50);
            this.picLander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLander.TabIndex = 6;
            this.picLander.TabStop = false;
            this.picLander.Click += new System.EventHandler(this.PicLander_Click);
            // 
            // MyPics
            // 
            this.MyPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyPics.ImageStream")));
            this.MyPics.TransparentColor = System.Drawing.Color.Transparent;
            this.MyPics.Images.SetKeyName(0, "DarthShip.png");
            this.MyPics.Images.SetKeyName(1, "DarthRight.png");
            this.MyPics.Images.SetKeyName(2, "DarthLeft.png");
            this.MyPics.Images.SetKeyName(3, "DarthUp.png");
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 120);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(42, 13);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "Label 5";
            this.labelScore.Click += new System.EventHandler(this.LabelScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelShips);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelLx);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelDy);
            this.Controls.Add(this.picLander);
            this.Controls.Add(this.panelScore);
            this.Controls.Add(this.picPlatform);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLander)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picPlatform;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Label labelLx;
        private System.Windows.Forms.Label labelDy;
        private System.Windows.Forms.Label labelShips;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.PictureBox picLander;
        private System.Windows.Forms.ImageList MyPics;
        private System.Windows.Forms.Label labelScore;
    }
}

