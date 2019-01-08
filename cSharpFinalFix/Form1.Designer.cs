namespace cSharpFinalFix
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
            this.lblScore = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.ptcBoxRedTeam = new System.Windows.Forms.PictureBox();
            this.ptcBoxBlueTeam = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.pbRobotCard = new System.Windows.Forms.PictureBox();
            this.pbHumanCard = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxRedTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxBlueTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobotCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumanCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(86, 33);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score";
            // 
            // btnDraw
            // 
            this.btnDraw.BackgroundImage = global::cSharpFinalFix.Properties.Resources.swords_312440_960_720;
            this.btnDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(220, 338);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(179, 94);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "DRAW";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // ptcBoxRedTeam
            // 
            this.ptcBoxRedTeam.Image = global::cSharpFinalFix.Properties.Resources.RedCardBack;
            this.ptcBoxRedTeam.Location = new System.Drawing.Point(104, 63);
            this.ptcBoxRedTeam.Name = "ptcBoxRedTeam";
            this.ptcBoxRedTeam.Size = new System.Drawing.Size(199, 269);
            this.ptcBoxRedTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcBoxRedTeam.TabIndex = 4;
            this.ptcBoxRedTeam.TabStop = false;
            // 
            // ptcBoxBlueTeam
            // 
            this.ptcBoxBlueTeam.Image = global::cSharpFinalFix.Properties.Resources.BlueCardBack;
            this.ptcBoxBlueTeam.Location = new System.Drawing.Point(323, 63);
            this.ptcBoxBlueTeam.Name = "ptcBoxBlueTeam";
            this.ptcBoxBlueTeam.Size = new System.Drawing.Size(199, 269);
            this.ptcBoxBlueTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcBoxBlueTeam.TabIndex = 5;
            this.ptcBoxBlueTeam.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCount.Location = new System.Drawing.Point(105, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 33);
            this.lblCount.TabIndex = 6;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRobotCard
            // 
            this.pbRobotCard.BackColor = System.Drawing.Color.White;
            this.pbRobotCard.Location = new System.Drawing.Point(324, 63);
            this.pbRobotCard.Name = "pbRobotCard";
            this.pbRobotCard.Size = new System.Drawing.Size(198, 269);
            this.pbRobotCard.TabIndex = 8;
            this.pbRobotCard.TabStop = false;
            this.pbRobotCard.Visible = false;
            // 
            // pbHumanCard
            // 
            this.pbHumanCard.Location = new System.Drawing.Point(105, 63);
            this.pbHumanCard.Name = "pbHumanCard";
            this.pbHumanCard.Size = new System.Drawing.Size(198, 269);
            this.pbHumanCard.TabIndex = 7;
            this.pbHumanCard.TabStop = false;
            this.pbHumanCard.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(212, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 269);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(220, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 269);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(228, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 269);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(236, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(198, 269);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cSharpFinalFix.Properties.Resources.WarImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 469);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRobotCard);
            this.Controls.Add(this.pbHumanCard);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.ptcBoxBlueTeam);
            this.Controls.Add(this.ptcBoxRedTeam);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxRedTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxBlueTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRobotCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumanCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox ptcBoxRedTeam;
        private System.Windows.Forms.PictureBox ptcBoxBlueTeam;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pbRobotCard;
        private System.Windows.Forms.PictureBox pbHumanCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

