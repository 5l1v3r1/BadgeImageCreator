﻿namespace BadgeImageCreator
{
    partial class frmFilterSettings
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
            this.pbDest = new AForge.Controls.PictureBox();
            this.pbSource = new AForge.Controls.PictureBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDest
            // 
            this.pbDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDest.Image = null;
            this.pbDest.Location = new System.Drawing.Point(283, 12);
            this.pbDest.Name = "pbDest";
            this.pbDest.Size = new System.Drawing.Size(265, 177);
            this.pbDest.TabIndex = 4;
            this.pbDest.TabStop = false;
            // 
            // pbSource
            // 
            this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSource.Image = null;
            this.pbSource.Location = new System.Drawing.Point(12, 12);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(265, 177);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSource.TabIndex = 5;
            this.pbSource.TabStop = false;
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Location = new System.Drawing.Point(12, 195);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(536, 77);
            this.grpSettings.TabIndex = 6;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(441, 278);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(107, 34);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdApply
            // 
            this.cmdApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdApply.Location = new System.Drawing.Point(328, 278);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(107, 34);
            this.cmdApply.TabIndex = 7;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            // 
            // frmFilterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 324);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.pbDest);
            this.Controls.Add(this.pbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFilterSettings";
            this.Text = "Filter Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pbDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.PictureBox pbDest;
        private AForge.Controls.PictureBox pbSource;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdApply;
    }
}