﻿/**
 * Copyright (c) David-John Miller AKA Anoyomouse 2014
 *
 * See LICENCE in the project directory for licence information
 **/
namespace BadgeImageCreator
{
	partial class frmBadge
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Filer Name Here");
			this.cmdProcess = new System.Windows.Forms.Button();
			this.panMainImage = new System.Windows.Forms.Panel();
			this.pcFullImage = new AForge.Controls.PictureBox();
			this.pbInt = new AForge.Controls.PictureBox();
			this.pbDest = new AForge.Controls.PictureBox();
			this.pbSource = new AForge.Controls.PictureBox();
			this.hsbContrast = new System.Windows.Forms.HScrollBar();
			this.hsbBrightness = new System.Windows.Forms.HScrollBar();
			this.hsbSaturation = new System.Windows.Forms.HScrollBar();
			this.cmdOpen = new System.Windows.Forms.Button();
			this.ofdImage = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
			this.sfdResult = new System.Windows.Forms.SaveFileDialog();
			this.cmdPreviewWIF = new System.Windows.Forms.Button();
			this.ofdWifImage = new System.Windows.Forms.OpenFileDialog();
			this.lsvFilterStack = new System.Windows.Forms.ListView();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmdAddFilter = new System.Windows.Forms.Button();
			this.cmbFilters = new System.Windows.Forms.ComboBox();
			this.cmdDelFilter = new System.Windows.Forms.Button();
			this.cmdSaveWif = new System.Windows.Forms.Button();
			this.panSimple = new System.Windows.Forms.Panel();
			this.chkInvert = new System.Windows.Forms.CheckBox();
			this.cmdReset = new System.Windows.Forms.Button();
			this.panMainImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcFullImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
			this.panSimple.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdProcess
			// 
			this.cmdProcess.Location = new System.Drawing.Point(426, 278);
			this.cmdProcess.Name = "cmdProcess";
			this.cmdProcess.Size = new System.Drawing.Size(104, 23);
			this.cmdProcess.TabIndex = 2;
			this.cmdProcess.Text = "Process";
			this.cmdProcess.UseVisualStyleBackColor = true;
			this.cmdProcess.Click += new System.EventHandler(this.cmdProcess_Click);
			// 
			// panMainImage
			// 
			this.panMainImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panMainImage.AutoScroll = true;
			this.panMainImage.BackColor = System.Drawing.Color.Transparent;
			this.panMainImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panMainImage.Controls.Add(this.pcFullImage);
			this.panMainImage.Location = new System.Drawing.Point(10, 306);
			this.panMainImage.Name = "panMainImage";
			this.panMainImage.Size = new System.Drawing.Size(799, 411);
			this.panMainImage.TabIndex = 4;
			// 
			// pcFullImage
			// 
			this.pcFullImage.Cursor = System.Windows.Forms.Cursors.Default;
			this.pcFullImage.Image = null;
			this.pcFullImage.Location = new System.Drawing.Point(0, 0);
			this.pcFullImage.Name = "pcFullImage";
			this.pcFullImage.Size = new System.Drawing.Size(776, 650);
			this.pcFullImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pcFullImage.TabIndex = 3;
			this.pcFullImage.TabStop = false;
			this.pcFullImage.Paint += new System.Windows.Forms.PaintEventHandler(this.pcFullImage_Paint);
			this.pcFullImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pcFullImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pcFullImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// pbInt
			// 
			this.pbInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbInt.Image = null;
			this.pbInt.Location = new System.Drawing.Point(281, 12);
			this.pbInt.Name = "pbInt";
			this.pbInt.Size = new System.Drawing.Size(265, 177);
			this.pbInt.TabIndex = 3;
			this.pbInt.TabStop = false;
			// 
			// pbDest
			// 
			this.pbDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbDest.Image = null;
			this.pbDest.Location = new System.Drawing.Point(552, 12);
			this.pbDest.Name = "pbDest";
			this.pbDest.Size = new System.Drawing.Size(265, 177);
			this.pbDest.TabIndex = 3;
			this.pbDest.TabStop = false;
			this.pbDest.Click += new System.EventHandler(this.pbDest_Click);
			// 
			// pbSource
			// 
			this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbSource.Image = null;
			this.pbSource.Location = new System.Drawing.Point(10, 12);
			this.pbSource.Name = "pbSource";
			this.pbSource.Size = new System.Drawing.Size(265, 177);
			this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbSource.TabIndex = 3;
			this.pbSource.TabStop = false;
			// 
			// hsbContrast
			// 
			this.hsbContrast.Location = new System.Drawing.Point(102, 26);
			this.hsbContrast.Maximum = 127;
			this.hsbContrast.Minimum = -127;
			this.hsbContrast.Name = "hsbContrast";
			this.hsbContrast.Size = new System.Drawing.Size(157, 20);
			this.hsbContrast.TabIndex = 5;
			this.hsbContrast.ValueChanged += new System.EventHandler(this.RefreshImage);
			// 
			// hsbBrightness
			// 
			this.hsbBrightness.Location = new System.Drawing.Point(102, 46);
			this.hsbBrightness.Maximum = 255;
			this.hsbBrightness.Minimum = -255;
			this.hsbBrightness.Name = "hsbBrightness";
			this.hsbBrightness.Size = new System.Drawing.Size(157, 20);
			this.hsbBrightness.TabIndex = 6;
			this.hsbBrightness.ValueChanged += new System.EventHandler(this.RefreshImage);
			// 
			// hsbSaturation
			// 
			this.hsbSaturation.Location = new System.Drawing.Point(102, 66);
			this.hsbSaturation.Minimum = -100;
			this.hsbSaturation.Name = "hsbSaturation";
			this.hsbSaturation.Size = new System.Drawing.Size(157, 20);
			this.hsbSaturation.TabIndex = 6;
			this.hsbSaturation.ValueChanged += new System.EventHandler(this.RefreshImage);
			// 
			// cmdOpen
			// 
			this.cmdOpen.Location = new System.Drawing.Point(10, 195);
			this.cmdOpen.Name = "cmdOpen";
			this.cmdOpen.Size = new System.Drawing.Size(85, 30);
			this.cmdOpen.TabIndex = 9;
			this.cmdOpen.Text = "Open";
			this.cmdOpen.UseVisualStyleBackColor = true;
			this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
			// 
			// ofdImage
			// 
			this.ofdImage.DefaultExt = "png";
			this.ofdImage.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files|*.*";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Contrast";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Brightness";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Saturation";
			// 
			// cmbAlgorithm
			// 
			this.cmbAlgorithm.DisplayMember = "Name";
			this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAlgorithm.FormattingEnabled = true;
			this.cmbAlgorithm.Location = new System.Drawing.Point(13, 2);
			this.cmbAlgorithm.Name = "cmbAlgorithm";
			this.cmbAlgorithm.Size = new System.Drawing.Size(238, 21);
			this.cmbAlgorithm.TabIndex = 11;
			this.cmbAlgorithm.SelectionChangeCommitted += new System.EventHandler(this.cmbAlgorithm_SelectionChangeCommitted);
			// 
			// sfdResult
			// 
			this.sfdResult.DefaultExt = "PNG";
			// 
			// cmdPreviewWIF
			// 
			this.cmdPreviewWIF.Location = new System.Drawing.Point(10, 269);
			this.cmdPreviewWIF.Name = "cmdPreviewWIF";
			this.cmdPreviewWIF.Size = new System.Drawing.Size(85, 30);
			this.cmdPreviewWIF.TabIndex = 12;
			this.cmdPreviewWIF.Text = "Preview WIF";
			this.cmdPreviewWIF.UseVisualStyleBackColor = true;
			this.cmdPreviewWIF.Click += new System.EventHandler(this.cmdPreviewWIF_Click);
			// 
			// ofdWifImage
			// 
			this.ofdWifImage.DefaultExt = "wif";
			this.ofdWifImage.Filter = "Wyolum Image Files|*.wif|All files|*.*";
			this.ofdWifImage.Title = "Preview WIF Image";
			// 
			// lsvFilterStack
			// 
			this.lsvFilterStack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
			this.lsvFilterStack.FullRowSelect = true;
			this.lsvFilterStack.GridLines = true;
			this.lsvFilterStack.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.lsvFilterStack.Location = new System.Drawing.Point(101, 222);
			this.lsvFilterStack.MultiSelect = false;
			this.lsvFilterStack.Name = "lsvFilterStack";
			this.lsvFilterStack.Size = new System.Drawing.Size(319, 78);
			this.lsvFilterStack.TabIndex = 13;
			this.lsvFilterStack.UseCompatibleStateImageBehavior = false;
			this.lsvFilterStack.View = System.Windows.Forms.View.Details;
			this.lsvFilterStack.SelectedIndexChanged += new System.EventHandler(this.lsvFilterStack_SelectedIndexChanged);
			this.lsvFilterStack.DoubleClick += new System.EventHandler(this.lsvFilterStack_DoubleClick);
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 200;
			// 
			// cmdAddFilter
			// 
			this.cmdAddFilter.Location = new System.Drawing.Point(426, 222);
			this.cmdAddFilter.Name = "cmdAddFilter";
			this.cmdAddFilter.Size = new System.Drawing.Size(104, 23);
			this.cmdAddFilter.TabIndex = 9;
			this.cmdAddFilter.Text = "Add Filter";
			this.cmdAddFilter.UseVisualStyleBackColor = true;
			this.cmdAddFilter.Click += new System.EventHandler(this.cmdAddFilter_Click);
			// 
			// cmbFilters
			// 
			this.cmbFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbFilters.DisplayMember = "Name";
			this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFilters.FormattingEnabled = true;
			this.cmbFilters.Location = new System.Drawing.Point(101, 195);
			this.cmbFilters.Name = "cmbFilters";
			this.cmbFilters.Size = new System.Drawing.Size(319, 21);
			this.cmbFilters.TabIndex = 14;
			this.cmbFilters.SelectedIndexChanged += new System.EventHandler(this.cmbFilters_SelectedIndexChanged);
			// 
			// cmdDelFilter
			// 
			this.cmdDelFilter.Enabled = false;
			this.cmdDelFilter.Location = new System.Drawing.Point(426, 251);
			this.cmdDelFilter.Name = "cmdDelFilter";
			this.cmdDelFilter.Size = new System.Drawing.Size(104, 23);
			this.cmdDelFilter.TabIndex = 9;
			this.cmdDelFilter.Text = "Remove Filter";
			this.cmdDelFilter.UseVisualStyleBackColor = true;
			this.cmdDelFilter.Click += new System.EventHandler(this.cmdDelFilter_Click);
			// 
			// cmdSaveWif
			// 
			this.cmdSaveWif.Location = new System.Drawing.Point(10, 231);
			this.cmdSaveWif.Name = "cmdSaveWif";
			this.cmdSaveWif.Size = new System.Drawing.Size(85, 30);
			this.cmdSaveWif.TabIndex = 9;
			this.cmdSaveWif.Text = "Save Wif";
			this.cmdSaveWif.UseVisualStyleBackColor = true;
			this.cmdSaveWif.Click += new System.EventHandler(this.cmdSaveWif_Click);
			// 
			// panSimple
			// 
			this.panSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panSimple.Controls.Add(this.cmdReset);
			this.panSimple.Controls.Add(this.chkInvert);
			this.panSimple.Controls.Add(this.cmbAlgorithm);
			this.panSimple.Controls.Add(this.label3);
			this.panSimple.Controls.Add(this.label2);
			this.panSimple.Controls.Add(this.label1);
			this.panSimple.Controls.Add(this.hsbContrast);
			this.panSimple.Controls.Add(this.hsbBrightness);
			this.panSimple.Controls.Add(this.hsbSaturation);
			this.panSimple.Location = new System.Drawing.Point(551, 189);
			this.panSimple.Name = "panSimple";
			this.panSimple.Size = new System.Drawing.Size(265, 105);
			this.panSimple.TabIndex = 15;
			// 
			// chkInvert
			// 
			this.chkInvert.AutoSize = true;
			this.chkInvert.Location = new System.Drawing.Point(102, 85);
			this.chkInvert.Name = "chkInvert";
			this.chkInvert.Size = new System.Drawing.Size(53, 17);
			this.chkInvert.TabIndex = 12;
			this.chkInvert.Text = "Invert";
			this.chkInvert.UseVisualStyleBackColor = true;
			this.chkInvert.CheckedChanged += new System.EventHandler(this.chkInvert_CheckedChanged);
			// 
			// cmdReset
			// 
			this.cmdReset.Location = new System.Drawing.Point(179, 85);
			this.cmdReset.Name = "cmdReset";
			this.cmdReset.Size = new System.Drawing.Size(79, 20);
			this.cmdReset.TabIndex = 13;
			this.cmdReset.Text = "Reset";
			this.cmdReset.UseVisualStyleBackColor = true;
			this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
			// 
			// frmBadge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 727);
			this.Controls.Add(this.panSimple);
			this.Controls.Add(this.cmbFilters);
			this.Controls.Add(this.lsvFilterStack);
			this.Controls.Add(this.cmdPreviewWIF);
			this.Controls.Add(this.cmdDelFilter);
			this.Controls.Add(this.cmdAddFilter);
			this.Controls.Add(this.cmdSaveWif);
			this.Controls.Add(this.cmdOpen);
			this.Controls.Add(this.panMainImage);
			this.Controls.Add(this.pbInt);
			this.Controls.Add(this.pbDest);
			this.Controls.Add(this.pbSource);
			this.Controls.Add(this.cmdProcess);
			this.Name = "frmBadge";
			this.Text = "Badge Image Creator";
			this.Load += new System.EventHandler(this.frmBadgeCreator_Load);
			this.panMainImage.ResumeLayout(false);
			this.panMainImage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcFullImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbInt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
			this.panSimple.ResumeLayout(false);
			this.panSimple.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button cmdProcess;
		private AForge.Controls.PictureBox pbSource;
		private AForge.Controls.PictureBox pbDest;
		private AForge.Controls.PictureBox pbInt;
		private AForge.Controls.PictureBox pcFullImage;
		private System.Windows.Forms.Panel panMainImage;
		private System.Windows.Forms.HScrollBar hsbContrast;
		private System.Windows.Forms.HScrollBar hsbBrightness;
		private System.Windows.Forms.HScrollBar hsbSaturation;
		private System.Windows.Forms.Button cmdOpen;
		private System.Windows.Forms.OpenFileDialog ofdImage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbAlgorithm;
		private System.Windows.Forms.SaveFileDialog sfdResult;
		private System.Windows.Forms.Button cmdPreviewWIF;
		private System.Windows.Forms.OpenFileDialog ofdWifImage;
		private System.Windows.Forms.ListView lsvFilterStack;
		private System.Windows.Forms.Button cmdAddFilter;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ComboBox cmbFilters;
		private System.Windows.Forms.Button cmdDelFilter;
		private System.Windows.Forms.Button cmdSaveWif;
		private System.Windows.Forms.Panel panSimple;
		private System.Windows.Forms.CheckBox chkInvert;
		private System.Windows.Forms.Button cmdReset;
	}
}

