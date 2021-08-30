namespace Proyecto_SAPC
{
    partial class SplashScreen
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
            this.pbSplashScreen = new ColorProgressBar.ColorProgressBar();
            this.picSplashScreen = new System.Windows.Forms.PictureBox();
            this.tSplashScreen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSplashScreen
            // 
            this.pbSplashScreen.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbSplashScreen.BorderColor = System.Drawing.Color.Black;
            this.pbSplashScreen.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.pbSplashScreen.Location = new System.Drawing.Point(12, 319);
            this.pbSplashScreen.Maximum = 100;
            this.pbSplashScreen.Minimum = 0;
            this.pbSplashScreen.Name = "pbSplashScreen";
            this.pbSplashScreen.Size = new System.Drawing.Size(610, 50);
            this.pbSplashScreen.Step = 10;
            this.pbSplashScreen.TabIndex = 1;
            this.pbSplashScreen.Value = 0;
            // 
            // picSplashScreen
            // 
            this.picSplashScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSplashScreen.Location = new System.Drawing.Point(12, 12);
            this.picSplashScreen.Name = "picSplashScreen";
            this.picSplashScreen.Size = new System.Drawing.Size(610, 293);
            this.picSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSplashScreen.TabIndex = 2;
            this.picSplashScreen.TabStop = false;
            // 
            // tSplashScreen
            // 
            this.tSplashScreen.Tick += new System.EventHandler(this.tSplashScreen_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.picSplashScreen);
            this.Controls.Add(this.pbSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SplashScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ColorProgressBar.ColorProgressBar pbSplashScreen;
        private System.Windows.Forms.PictureBox picSplashScreen;
        private System.Windows.Forms.Timer tSplashScreen;
    }
}