//*******************************************************************************
// Copyright (C) 2021 Cognex Corporation
//
// Subject to Cognex Corporation's terms and conditions and license agreement,
// you are authorized to use and modify this sample source code in any way you find
// useful, provided the Software and/or the modified Software is used solely in
// conjunction with a Cognex Machine Vision System.  Furthermore you acknowledge
// and agree that Cognex has no warranty, obligations or liability for your use
// of the Software.
//*******************************************************************************

using Cognex.InSight.Web.Controls;

namespace WebAPISampleApp
{
  partial class MainForm
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
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.tbIpAddressWithPort = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJobMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHmiCellsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hmiCustomViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openHMIMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQueuedImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hmiSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cvsFilmstrip = new Cognex.InSight.Web.Controls.CvsFilmstrip();
            this.cvsCustomView = new Cognex.InSight.Web.Controls.CvsCustomView();
            this.cvsDisplay = new Cognex.InSight.Web.Controls.CvsDisplay();
            this.cvsSpreadsheet = new Cognex.InSight.Web.Controls.CvsSpreadsheet();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDisconnect.Location = new System.Drawing.Point(6, 44);
            this.btnConnectDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(92, 27);
            this.btnConnectDisconnect.TabIndex = 4;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.UseVisualStyleBackColor = true;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // tbIpAddressWithPort
            // 
            this.tbIpAddressWithPort.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpAddressWithPort.Location = new System.Drawing.Point(102, 47);
            this.tbIpAddressWithPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbIpAddressWithPort.Name = "tbIpAddressWithPort";
            this.tbIpAddressWithPort.Size = new System.Drawing.Size(96, 20);
            this.tbIpAddressWithPort.TabIndex = 5;
            this.tbIpAddressWithPort.Text = "127.0.0.1:80";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(202, 47);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(69, 20);
            this.tbUsername.TabIndex = 6;
            this.tbUsername.Text = "admin";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(274, 47);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(54, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address and port:";
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(837, 35);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(192, 18);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Not Connected";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMessages
            // 
            this.tbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessages.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessages.Location = new System.Drawing.Point(18, 1626);
            this.tbMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessages.Size = new System.Drawing.Size(1027, 23);
            this.tbMessages.TabIndex = 0;
            this.tbMessages.WordWrap = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.imageMenuItem,
            this.sensorMenuItem,
            this.systemMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip.TabIndex = 25;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadJobMenuItem,
            this.saveJobMenuItem,
            this.loadHmiCellsMenuItem,
            this.toolStripSeparator1,
            this.loadImageMenuItem,
            this.saveImageMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // loadJobMenuItem
            // 
            this.loadJobMenuItem.Name = "loadJobMenuItem";
            this.loadJobMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadJobMenuItem.Text = "Load Job...";
            this.loadJobMenuItem.Click += new System.EventHandler(this.loadJobMenuItem_Click);
            // 
            // saveJobMenuItem
            // 
            this.saveJobMenuItem.Name = "saveJobMenuItem";
            this.saveJobMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveJobMenuItem.Text = "Save Job...";
            this.saveJobMenuItem.Click += new System.EventHandler(this.saveJobMenuItem_Click);
            // 
            // loadHmiCellsMenuItem
            // 
            this.loadHmiCellsMenuItem.Name = "loadHmiCellsMenuItem";
            this.loadHmiCellsMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadHmiCellsMenuItem.Text = "Load HMI Cells...";
            this.loadHmiCellsMenuItem.Click += new System.EventHandler(this.loadHmiCellsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // loadImageMenuItem
            // 
            this.loadImageMenuItem.Name = "loadImageMenuItem";
            this.loadImageMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadImageMenuItem.Text = "Load Image...";
            this.loadImageMenuItem.Click += new System.EventHandler(this.loadImageMenuItem_Click);
            // 
            // saveImageMenuItem
            // 
            this.saveImageMenuItem.Name = "saveImageMenuItem";
            this.saveImageMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveImageMenuItem.Text = "Save Image...";
            this.saveImageMenuItem.Click += new System.EventHandler(this.saveImageMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmiCustomViewMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // hmiCustomViewMenuItem
            // 
            this.hmiCustomViewMenuItem.Name = "hmiCustomViewMenuItem";
            this.hmiCustomViewMenuItem.Size = new System.Drawing.Size(198, 22);
            this.hmiCustomViewMenuItem.Text = "Set HMI Custom View...";
            this.hmiCustomViewMenuItem.Click += new System.EventHandler(this.hmiCustomViewMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openHMIMenuItem,
            this.showCustomViewToolStripMenuItem,
            this.showSpreadsheetToolStripMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "View";
            // 
            // openHMIMenuItem
            // 
            this.openHMIMenuItem.Name = "openHMIMenuItem";
            this.openHMIMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openHMIMenuItem.Text = "Open HMI...";
            this.openHMIMenuItem.Click += new System.EventHandler(this.openHMIMenuItem_Click);
            // 
            // showCustomViewToolStripMenuItem
            // 
            this.showCustomViewToolStripMenuItem.Checked = true;
            this.showCustomViewToolStripMenuItem.CheckOnClick = true;
            this.showCustomViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCustomViewToolStripMenuItem.Name = "showCustomViewToolStripMenuItem";
            this.showCustomViewToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showCustomViewToolStripMenuItem.Text = "Show Custom View";
            this.showCustomViewToolStripMenuItem.Click += new System.EventHandler(this.showCustomViewToolStripMenuItem_Click);
            // 
            // showSpreadsheetToolStripMenuItem
            // 
            this.showSpreadsheetToolStripMenuItem.Checked = true;
            this.showSpreadsheetToolStripMenuItem.CheckOnClick = true;
            this.showSpreadsheetToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSpreadsheetToolStripMenuItem.Name = "showSpreadsheetToolStripMenuItem";
            this.showSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showSpreadsheetToolStripMenuItem.Text = "Show Spreadsheet";
            this.showSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.showSpreadsheetToolStripMenuItem_Click);
            // 
            // imageMenuItem
            // 
            this.imageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triggerMenuItem});
            this.imageMenuItem.Name = "imageMenuItem";
            this.imageMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageMenuItem.Text = "Image";
            // 
            // triggerMenuItem
            // 
            this.triggerMenuItem.Name = "triggerMenuItem";
            this.triggerMenuItem.Size = new System.Drawing.Size(110, 22);
            this.triggerMenuItem.Text = "Trigger";
            this.triggerMenuItem.Click += new System.EventHandler(this.triggerMenuItem_Click);
            // 
            // sensorMenuItem
            // 
            this.sensorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineMenuItem,
            this.liveModeMenuItem,
            this.saveQueuedImagesToolStripMenuItem});
            this.sensorMenuItem.Name = "sensorMenuItem";
            this.sensorMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sensorMenuItem.Text = "Sensor";
            // 
            // onlineMenuItem
            // 
            this.onlineMenuItem.Name = "onlineMenuItem";
            this.onlineMenuItem.Size = new System.Drawing.Size(211, 22);
            this.onlineMenuItem.Text = "Online";
            this.onlineMenuItem.Click += new System.EventHandler(this.onlineMenuItem_Click);
            // 
            // liveModeMenuItem
            // 
            this.liveModeMenuItem.Name = "liveModeMenuItem";
            this.liveModeMenuItem.Size = new System.Drawing.Size(211, 22);
            this.liveModeMenuItem.Text = "Live Mode";
            this.liveModeMenuItem.Click += new System.EventHandler(this.liveModeToolStripMenuItem_Click);
            // 
            // saveQueuedImagesToolStripMenuItem
            // 
            this.saveQueuedImagesToolStripMenuItem.Name = "saveQueuedImagesToolStripMenuItem";
            this.saveQueuedImagesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.saveQueuedImagesToolStripMenuItem.Text = "Get Queued Image URLs...";
            this.saveQueuedImagesToolStripMenuItem.Click += new System.EventHandler(this.getQueuedImageURLsToolStripMenuItem_Click);
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmiSettingsMenuItem});
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemMenuItem.Text = "System";
            // 
            // hmiSettingsMenuItem
            // 
            this.hmiSettingsMenuItem.Name = "hmiSettingsMenuItem";
            this.hmiSettingsMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hmiSettingsMenuItem.Text = "HMI Settings...";
            this.hmiSettingsMenuItem.Click += new System.EventHandler(this.hmiSettingsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutMenuItem.Text = "About camera...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 75);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cvsFilmstrip);
            this.splitContainer1.Panel1.Controls.Add(this.cvsCustomView);
            this.splitContainer1.Panel1.Controls.Add(this.cvsDisplay);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cvsSpreadsheet);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 545);
            this.splitContainer1.SplitterDistance = 624;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 26;
            // 
            // cvsFilmstrip
            // 
            this.cvsFilmstrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvsFilmstrip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsFilmstrip.BackColor = System.Drawing.SystemColors.Control;
            this.cvsFilmstrip.Location = new System.Drawing.Point(0, 495);
            this.cvsFilmstrip.Margin = new System.Windows.Forms.Padding(0);
            this.cvsFilmstrip.Name = "cvsFilmstrip";
            this.cvsFilmstrip.Size = new System.Drawing.Size(622, 50);
            this.cvsFilmstrip.TabIndex = 24;
            // 
            // cvsCustomView
            // 
            this.cvsCustomView.AllowDrop = true;
            this.cvsCustomView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsCustomView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cvsCustomView.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvsCustomView.Location = new System.Drawing.Point(37, 35);
            this.cvsCustomView.Margin = new System.Windows.Forms.Padding(0);
            this.cvsCustomView.Name = "cvsCustomView";
            this.cvsCustomView.Size = new System.Drawing.Size(125, 187);
            this.cvsCustomView.TabIndex = 25;
            // 
            // cvsDisplay
            // 
            this.cvsDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvsDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsDisplay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvsDisplay.Location = new System.Drawing.Point(0, 0);
            this.cvsDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.cvsDisplay.Name = "cvsDisplay";
            this.cvsDisplay.Size = new System.Drawing.Size(622, 495);
            this.cvsDisplay.TabIndex = 19;
            // 
            // cvsSpreadsheet
            // 
            this.cvsSpreadsheet.AllowDrop = true;
            this.cvsSpreadsheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvsSpreadsheet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cvsSpreadsheet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cvsSpreadsheet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvsSpreadsheet.Location = new System.Drawing.Point(0, 0);
            this.cvsSpreadsheet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cvsSpreadsheet.Name = "cvsSpreadsheet";
            this.cvsSpreadsheet.Size = new System.Drawing.Size(412, 545);
            this.cvsSpreadsheet.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1068, 609);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1036, 622);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbIpAddressWithPort);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Web API Sample App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnConnectDisconnect;
    private System.Windows.Forms.TextBox tbIpAddressWithPort;
    private System.Windows.Forms.TextBox tbUsername;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblState;
    private System.Windows.Forms.TextBox tbMessages;
    private Cognex.InSight.Web.Controls.CvsSpreadsheet cvsSpreadsheet;
    private Cognex.InSight.Web.Controls.CvsDisplay cvsDisplay;
    private Cognex.InSight.Web.Controls.CvsFilmstrip cvsFilmstrip;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadJobMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveJobMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem loadImageMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveImageMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hmiCustomViewMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openHMIMenuItem;
    private System.Windows.Forms.ToolStripMenuItem imageMenuItem;
    private System.Windows.Forms.ToolStripMenuItem triggerMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sensorMenuItem;
    private System.Windows.Forms.ToolStripMenuItem onlineMenuItem;
    private System.Windows.Forms.ToolStripMenuItem systemMenuItem;
    private System.Windows.Forms.ToolStripMenuItem hmiSettingsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
    private Cognex.InSight.Web.Controls.CvsCustomView cvsCustomView;
    private System.Windows.Forms.ToolStripMenuItem showCustomViewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadHmiCellsMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showSpreadsheetToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem liveModeMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveQueuedImagesToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
    }
}

