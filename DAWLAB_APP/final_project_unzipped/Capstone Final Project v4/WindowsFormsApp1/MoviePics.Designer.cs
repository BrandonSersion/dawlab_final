namespace WindowsFormsApp1
{
    partial class MoviePics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviePics));
            this.prefButton = new System.Windows.Forms.Button();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.movieInfoLabel = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.voteLabel = new System.Windows.Forms.Label();
            this.voteComboBox = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moviePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // prefButton
            // 
            this.prefButton.BackColor = System.Drawing.SystemColors.Control;
            this.prefButton.Font = new System.Drawing.Font("Century Gothic", 7.875F);
            this.prefButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prefButton.Location = new System.Drawing.Point(450, 23);
            this.prefButton.Margin = new System.Windows.Forms.Padding(6);
            this.prefButton.Name = "prefButton";
            this.prefButton.Size = new System.Drawing.Size(218, 44);
            this.prefButton.TabIndex = 3;
            this.prefButton.Text = "Set Preferences";
            this.prefButton.UseVisualStyleBackColor = false;
            this.prefButton.Click += new System.EventHandler(this.prefButton_Click);
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.movieNameLabel.Location = new System.Drawing.Point(440, 115);
            this.movieNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(158, 55);
            this.movieNameLabel.TabIndex = 6;
            this.movieNameLabel.Text = "label2";
            // 
            // movieInfoLabel
            // 
            this.movieInfoLabel.AutoSize = true;
            this.movieInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.movieInfoLabel.Location = new System.Drawing.Point(442, 194);
            this.movieInfoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.movieInfoLabel.MaximumSize = new System.Drawing.Size(600, 577);
            this.movieInfoLabel.Name = "movieInfoLabel";
            this.movieInfoLabel.Size = new System.Drawing.Size(102, 37);
            this.movieInfoLabel.TabIndex = 7;
            this.movieInfoLabel.Text = "label3";
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.SystemColors.Control;
            this.skipButton.Font = new System.Drawing.Font("Century Gothic", 7.875F);
            this.skipButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skipButton.Location = new System.Drawing.Point(680, 23);
            this.skipButton.Margin = new System.Windows.Forms.Padding(6);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(194, 44);
            this.skipButton.TabIndex = 8;
            this.skipButton.Text = "Not Interested";
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.BackColor = System.Drawing.SystemColors.Control;
            this.randomButton.Font = new System.Drawing.Font("Century Gothic", 7.875F);
            this.randomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.randomButton.Location = new System.Drawing.Point(886, 23);
            this.randomButton.Margin = new System.Windows.Forms.Padding(6);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(198, 44);
            this.randomButton.TabIndex = 9;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = false;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.Control;
            this.playButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playButton.Location = new System.Drawing.Point(530, 502);
            this.playButton.Margin = new System.Windows.Forms.Padding(6);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(220, 44);
            this.playButton.TabIndex = 10;
            this.playButton.Text = "Play Now";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // voteLabel
            // 
            this.voteLabel.AutoSize = true;
            this.voteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.voteLabel.Location = new System.Drawing.Point(762, 508);
            this.voteLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.voteLabel.Name = "voteLabel";
            this.voteLabel.Size = new System.Drawing.Size(345, 29);
            this.voteLabel.TabIndex = 11;
            this.voteLabel.Text = "Already Watched?  Rate Movie:";
            // 
            // voteComboBox
            // 
            this.voteComboBox.FormattingEnabled = true;
            this.voteComboBox.Location = new System.Drawing.Point(1126, 502);
            this.voteComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.voteComboBox.Name = "voteComboBox";
            this.voteComboBox.Size = new System.Drawing.Size(94, 33);
            this.voteComboBox.TabIndex = 12;
            this.voteComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 7.875F);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeButton.Location = new System.Drawing.Point(1096, 23);
            this.closeButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(198, 42);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoLabel.Location = new System.Drawing.Point(586, 573);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(267, 48);
            this.logoLabel.TabIndex = 15;
            this.logoLabel.Text = "Powered By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Dawlab_classic_with_background;
            this.pictureBox1.Location = new System.Drawing.Point(886, 569);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // moviePicBox
            // 
            this.moviePicBox.Location = new System.Drawing.Point(48, 115);
            this.moviePicBox.Margin = new System.Windows.Forms.Padding(6);
            this.moviePicBox.Name = "moviePicBox";
            this.moviePicBox.Size = new System.Drawing.Size(366, 431);
            this.moviePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePicBox.TabIndex = 0;
            this.moviePicBox.TabStop = false;
            // 
            // MoviePics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1328, 648);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.voteComboBox);
            this.Controls.Add(this.voteLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.movieInfoLabel);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.prefButton);
            this.Controls.Add(this.moviePicBox);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MoviePics";
            this.Text = "Zetflix";
            this.Load += new System.EventHandler(this.MoviePics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moviePicBox;
        private System.Windows.Forms.Button prefButton;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.Label movieInfoLabel;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label voteLabel;
        private System.Windows.Forms.ComboBox voteComboBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logoLabel;
    }
}