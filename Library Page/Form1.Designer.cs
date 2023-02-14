namespace Library_Page
{
    partial class Library
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchByGenre = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picAd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(53, 275);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchByGenre
            // 
            this.txtSearchByGenre.Location = new System.Drawing.Point(40, 211);
            this.txtSearchByGenre.Name = "txtSearchByGenre";
            this.txtSearchByGenre.Size = new System.Drawing.Size(150, 31);
            this.txtSearchByGenre.TabIndex = 1;
            this.txtSearchByGenre.Text = "Search By Genre";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(617, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 75);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // picAd
            // 
            this.picAd.Location = new System.Drawing.Point(617, 114);
            this.picAd.Name = "picAd";
            this.picAd.Size = new System.Drawing.Size(150, 324);
            this.picAd.TabIndex = 3;
            this.picAd.TabStop = false;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picAd);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtSearchByGenre);
            this.Controls.Add(this.btnSearch);
            this.Name = "Library";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearchByGenre;
        private PictureBox picLogo;
        private PictureBox picAd;
    }
}