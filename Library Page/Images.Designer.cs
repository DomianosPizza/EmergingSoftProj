namespace Library_Page
{
    partial class Images
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
            this.btnImageSummon = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImageSummon
            // 
            this.btnImageSummon.Location = new System.Drawing.Point(355, 306);
            this.btnImageSummon.Name = "btnImageSummon";
            this.btnImageSummon.Size = new System.Drawing.Size(128, 34);
            this.btnImageSummon.TabIndex = 0;
            this.btnImageSummon.Text = "Push for Pet";
            this.btnImageSummon.UseVisualStyleBackColor = true;
            this.btnImageSummon.Click += new System.EventHandler(this.btnImageSummon_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(325, 74);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(190, 189);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnImageSummon);
            this.Name = "Images";
            this.Text = "Images";
            this.Load += new System.EventHandler(this.Images_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnImageSummon;
        private PictureBox picImage;
    }
}