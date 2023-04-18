namespace SuperBingao
{
    partial class Form3
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
            this.ImageLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageLogo
            // 
            this.ImageLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageLogo.ImageLocation = "C:\\SuperBingao\\Imagens\\logo.png";
            this.ImageLogo.Location = new System.Drawing.Point(0, 0);
            this.ImageLogo.Name = "ImageLogo";
            this.ImageLogo.Size = new System.Drawing.Size(838, 611);
            this.ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageLogo.TabIndex = 8;
            this.ImageLogo.TabStop = false;
            this.ImageLogo.WaitOnLoad = true;
            this.ImageLogo.Click += new System.EventHandler(this.ImageLogo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperBingao.Properties.Resources.bola211x211;
            this.ClientSize = new System.Drawing.Size(838, 611);
            this.Controls.Add(this.ImageLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox ImageLogo;
    }
}