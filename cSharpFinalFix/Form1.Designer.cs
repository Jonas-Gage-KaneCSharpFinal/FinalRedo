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
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxRedTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxBlueTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblScore.Font = new System.Drawing.Font("NASDAQER", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDraw.Font = new System.Drawing.Font("NASDAQER", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblCount.Font = new System.Drawing.Font("NASDAQER", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCount.Location = new System.Drawing.Point(105, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 33);
            this.lblCount.TabIndex = 6;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cSharpFinalFix.Properties.Resources.WarImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 469);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.ptcBoxBlueTeam);
            this.Controls.Add(this.ptcBoxRedTeam);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "War";
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxRedTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxBlueTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox ptcBoxRedTeam;
        private System.Windows.Forms.PictureBox ptcBoxBlueTeam;
        private System.Windows.Forms.Label lblCount;
    }
}

