namespace cSharpFinalFix
{
    partial class Quit
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
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblAreYouSure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.BackgroundImage = global::cSharpFinalFix.Properties.Resources.Yes;
            this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYes.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold);
            this.btnYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYes.Location = new System.Drawing.Point(12, 99);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(244, 294);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackgroundImage = global::cSharpFinalFix.Properties.Resources.No;
            this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNo.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNo.Location = new System.Drawing.Point(366, 99);
            this.btnNo.Name = "btnNo";
            this.btnNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNo.Size = new System.Drawing.Size(244, 294);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblAreYouSure
            // 
            this.lblAreYouSure.BackColor = System.Drawing.Color.Transparent;
            this.lblAreYouSure.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAreYouSure.Font = new System.Drawing.Font("Bauhaus 93", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouSure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAreYouSure.Location = new System.Drawing.Point(40, 20);
            this.lblAreYouSure.Name = "lblAreYouSure";
            this.lblAreYouSure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAreYouSure.Size = new System.Drawing.Size(598, 66);
            this.lblAreYouSure.TabIndex = 2;
            this.lblAreYouSure.Text = "Are You Sure You Want To Quit?";
            // 
            // Quit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cSharpFinalFix.Properties.Resources.ImageToQuit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 469);
            this.Controls.Add(this.lblAreYouSure);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Name = "Quit";
            this.RightToLeftLayout = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblAreYouSure;
    }
}