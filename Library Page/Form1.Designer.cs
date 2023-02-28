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
            btnSearch = new Button();
            txtSearchByGenre = new TextBox();
            picLogo = new PictureBox();
            picAd = new PictureBox();
            lblResultBox = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAd).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(53, 275);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchByGenre
            // 
            txtSearchByGenre.Location = new Point(40, 211);
            txtSearchByGenre.Name = "txtSearchByGenre";
            txtSearchByGenre.Size = new Size(150, 31);
            txtSearchByGenre.TabIndex = 1;
            txtSearchByGenre.Text = "Search By Genre";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(617, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 75);
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // picAd
            // 
            picAd.Location = new Point(617, 114);
            picAd.Name = "picAd";
            picAd.Size = new Size(150, 324);
            picAd.TabIndex = 3;
            picAd.TabStop = false;
            // 
            // lblResultBox
            // 
            lblResultBox.AutoSize = true;
            lblResultBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultBox.Location = new Point(256, 188);
            lblResultBox.Name = "lblResultBox";
            lblResultBox.Size = new Size(130, 54);
            lblResultBox.TabIndex = 4;
            lblResultBox.Text = "label1";
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultBox);
            Controls.Add(picAd);
            Controls.Add(picLogo);
            Controls.Add(txtSearchByGenre);
            Controls.Add(btnSearch);
            Name = "Library";
            Text = "Library";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearchByGenre;
        private PictureBox picLogo;
        private PictureBox picAd;
        private Label lblResultBox;
    }
}