namespace KutterJordanBossenForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHashDarling = new System.Windows.Forms.ToolStripMenuItem();
            this.fdOpen = new System.Windows.Forms.OpenFileDialog();
            this.fdSave = new System.Windows.Forms.SaveFileDialog();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tbRobustness = new System.Windows.Forms.TrackBar();
            this.pbSourcePicture = new System.Windows.Forms.PictureBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.nudNeighbourhoodLength = new System.Windows.Forms.NumericUpDown();
            this.lblNeighbourhoodLength = new System.Windows.Forms.Label();
            this.tbNeighbourhoodLength = new System.Windows.Forms.TrackBar();
            this.nudDensity = new System.Windows.Forms.NumericUpDown();
            this.nudRobustness = new System.Windows.Forms.NumericUpDown();
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblRedundancy = new System.Windows.Forms.Label();
            this.tbDensity = new System.Windows.Forms.TrackBar();
            this.nudRedundancy = new System.Windows.Forms.NumericUpDown();
            this.lblSeed = new System.Windows.Forms.Label();
            this.lblRobustness = new System.Windows.Forms.Label();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.sContainerMain = new System.Windows.Forms.SplitContainer();
            this.sContainerInputs = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.nudMessageLength = new System.Windows.Forms.NumericUpDown();
            this.lblMessageLength = new System.Windows.Forms.Label();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRobustness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourcePicture)).BeginInit();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeighbourhoodLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNeighbourhoodLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRobustness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedundancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            this.gbMessage.SuspendLayout();
            this.gbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainerMain)).BeginInit();
            this.sContainerMain.Panel1.SuspendLayout();
            this.sContainerMain.Panel2.SuspendLayout();
            this.sContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainerInputs)).BeginInit();
            this.sContainerInputs.Panel1.SuspendLayout();
            this.sContainerInputs.Panel2.SuspendLayout();
            this.sContainerInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageLength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmHashDarling,
            this.decryptToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmSaveAs});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(48, 20);
            this.tsmFile.Text = "Файл";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmOpen.Text = "Открыть";
            this.tsmOpen.Click += new System.EventHandler(this.OpenSourceImageHandler);
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.Size = new System.Drawing.Size(180, 22);
            this.tsmSaveAs.Text = "Сохранить как...";
            this.tsmSaveAs.Click += new System.EventHandler(this.SaveSourceImageHandler);
            // 
            // tsmHashDarling
            // 
            this.tsmHashDarling.Name = "tsmHashDarling";
            this.tsmHashDarling.Size = new System.Drawing.Size(87, 20);
            this.tsmHashDarling.Text = "Hash Darling";
            this.tsmHashDarling.Click += new System.EventHandler(this.HashDarlingHandler);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(3, 16);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(422, 123);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // tbRobustness
            // 
            this.tbRobustness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRobustness.LargeChange = 1000;
            this.tbRobustness.Location = new System.Drawing.Point(146, 70);
            this.tbRobustness.Maximum = 10000;
            this.tbRobustness.Name = "tbRobustness";
            this.tbRobustness.Size = new System.Drawing.Size(277, 45);
            this.tbRobustness.SmallChange = 100;
            this.tbRobustness.TabIndex = 3;
            this.tbRobustness.Value = 5000;
            this.tbRobustness.Scroll += new System.EventHandler(this.tbRobustness_Scroll);
            // 
            // pbSourcePicture
            // 
            this.pbSourcePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSourcePicture.InitialImage = null;
            this.pbSourcePicture.Location = new System.Drawing.Point(0, 0);
            this.pbSourcePicture.Name = "pbSourcePicture";
            this.pbSourcePicture.Size = new System.Drawing.Size(661, 582);
            this.pbSourcePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSourcePicture.TabIndex = 5;
            this.pbSourcePicture.TabStop = false;
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.lblMessageLength);
            this.gbSettings.Controls.Add(this.nudMessageLength);
            this.gbSettings.Controls.Add(this.nudNeighbourhoodLength);
            this.gbSettings.Controls.Add(this.lblNeighbourhoodLength);
            this.gbSettings.Controls.Add(this.tbNeighbourhoodLength);
            this.gbSettings.Controls.Add(this.nudDensity);
            this.gbSettings.Controls.Add(this.nudRobustness);
            this.gbSettings.Controls.Add(this.lblDensity);
            this.gbSettings.Controls.Add(this.lblRedundancy);
            this.gbSettings.Controls.Add(this.tbDensity);
            this.gbSettings.Controls.Add(this.nudRedundancy);
            this.gbSettings.Controls.Add(this.lblSeed);
            this.gbSettings.Controls.Add(this.lblRobustness);
            this.gbSettings.Controls.Add(this.nudSeed);
            this.gbSettings.Controls.Add(this.tbRobustness);
            this.gbSettings.Location = new System.Drawing.Point(3, 3);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(430, 197);
            this.gbSettings.TabIndex = 5;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // nudNeighbourhoodLength
            // 
            this.nudNeighbourhoodLength.Location = new System.Drawing.Point(75, 130);
            this.nudNeighbourhoodLength.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNeighbourhoodLength.Name = "nudNeighbourhoodLength";
            this.nudNeighbourhoodLength.Size = new System.Drawing.Size(65, 20);
            this.nudNeighbourhoodLength.TabIndex = 19;
            this.nudNeighbourhoodLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNeighbourhoodLength.ValueChanged += new System.EventHandler(this.nudNeighbourhoodLength_ValueChanged);
            // 
            // lblNeighbourhoodLength
            // 
            this.lblNeighbourhoodLength.AutoSize = true;
            this.lblNeighbourhoodLength.Location = new System.Drawing.Point(9, 132);
            this.lblNeighbourhoodLength.Name = "lblNeighbourhoodLength";
            this.lblNeighbourhoodLength.Size = new System.Drawing.Size(60, 13);
            this.lblNeighbourhoodLength.TabIndex = 18;
            this.lblNeighbourhoodLength.Text = "nbh_length";
            // 
            // tbNeighbourhoodLength
            // 
            this.tbNeighbourhoodLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNeighbourhoodLength.LargeChange = 2;
            this.tbNeighbourhoodLength.Location = new System.Drawing.Point(146, 121);
            this.tbNeighbourhoodLength.Maximum = 4;
            this.tbNeighbourhoodLength.Name = "tbNeighbourhoodLength";
            this.tbNeighbourhoodLength.Size = new System.Drawing.Size(277, 45);
            this.tbNeighbourhoodLength.TabIndex = 17;
            this.tbNeighbourhoodLength.Value = 1;
            this.tbNeighbourhoodLength.Scroll += new System.EventHandler(this.tbNeighbourhoodLength_Scroll);
            // 
            // nudDensity
            // 
            this.nudDensity.DecimalPlaces = 4;
            this.nudDensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudDensity.Location = new System.Drawing.Point(75, 28);
            this.nudDensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDensity.Name = "nudDensity";
            this.nudDensity.Size = new System.Drawing.Size(65, 20);
            this.nudDensity.TabIndex = 16;
            this.nudDensity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDensity.ValueChanged += new System.EventHandler(this.nudDensity_ValueChanged);
            // 
            // nudRobustness
            // 
            this.nudRobustness.DecimalPlaces = 4;
            this.nudRobustness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudRobustness.Location = new System.Drawing.Point(75, 79);
            this.nudRobustness.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRobustness.Name = "nudRobustness";
            this.nudRobustness.Size = new System.Drawing.Size(65, 20);
            this.nudRobustness.TabIndex = 15;
            this.nudRobustness.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudRobustness.ValueChanged += new System.EventHandler(this.nudRobustness_ValueChanged);
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(6, 30);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(42, 13);
            this.lblDensity.TabIndex = 10;
            this.lblDensity.Text = "Density";
            // 
            // lblRedundancy
            // 
            this.lblRedundancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRedundancy.AutoSize = true;
            this.lblRedundancy.Location = new System.Drawing.Point(284, 173);
            this.lblRedundancy.Name = "lblRedundancy";
            this.lblRedundancy.Size = new System.Drawing.Size(68, 13);
            this.lblRedundancy.TabIndex = 14;
            this.lblRedundancy.Text = "Redundancy";
            // 
            // tbDensity
            // 
            this.tbDensity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDensity.LargeChange = 1000;
            this.tbDensity.Location = new System.Drawing.Point(146, 19);
            this.tbDensity.Maximum = 10000;
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Size = new System.Drawing.Size(277, 45);
            this.tbDensity.SmallChange = 100;
            this.tbDensity.TabIndex = 9;
            this.tbDensity.Value = 5000;
            this.tbDensity.Scroll += new System.EventHandler(this.tbDensity_Scroll);
            // 
            // nudRedundancy
            // 
            this.nudRedundancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRedundancy.Location = new System.Drawing.Point(358, 171);
            this.nudRedundancy.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRedundancy.Name = "nudRedundancy";
            this.nudRedundancy.Size = new System.Drawing.Size(65, 20);
            this.nudRedundancy.TabIndex = 13;
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(168, 173);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(32, 13);
            this.lblSeed.TabIndex = 11;
            this.lblSeed.Text = "Seed";
            // 
            // lblRobustness
            // 
            this.lblRobustness.AutoSize = true;
            this.lblRobustness.Location = new System.Drawing.Point(6, 81);
            this.lblRobustness.Name = "lblRobustness";
            this.lblRobustness.Size = new System.Drawing.Size(63, 13);
            this.lblRobustness.TabIndex = 8;
            this.lblRobustness.Text = "Robustness";
            // 
            // nudSeed
            // 
            this.nudSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSeed.Location = new System.Drawing.Point(206, 171);
            this.nudSeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(65, 20);
            this.nudSeed.TabIndex = 8;
            // 
            // gbMessage
            // 
            this.gbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMessage.Controls.Add(this.txtMessage);
            this.gbMessage.Location = new System.Drawing.Point(0, 3);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(0);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(428, 142);
            this.gbMessage.TabIndex = 10;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(0, 0);
            this.gbLog.Margin = new System.Windows.Forms.Padding(0);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(428, 226);
            this.gbLog.TabIndex = 15;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(422, 207);
            this.txtLog.TabIndex = 2;
            // 
            // sContainerMain
            // 
            this.sContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainerMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sContainerMain.Location = new System.Drawing.Point(0, 24);
            this.sContainerMain.Name = "sContainerMain";
            // 
            // sContainerMain.Panel1
            // 
            this.sContainerMain.Panel1.Controls.Add(this.pbSourcePicture);
            // 
            // sContainerMain.Panel2
            // 
            this.sContainerMain.Panel2.Controls.Add(this.sContainerInputs);
            this.sContainerMain.Panel2.Controls.Add(this.gbSettings);
            this.sContainerMain.Panel2MinSize = 440;
            this.sContainerMain.Size = new System.Drawing.Size(1108, 584);
            this.sContainerMain.SplitterDistance = 663;
            this.sContainerMain.TabIndex = 16;
            // 
            // sContainerInputs
            // 
            this.sContainerInputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sContainerInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sContainerInputs.Location = new System.Drawing.Point(3, 203);
            this.sContainerInputs.Margin = new System.Windows.Forms.Padding(0);
            this.sContainerInputs.Name = "sContainerInputs";
            this.sContainerInputs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sContainerInputs.Panel1
            // 
            this.sContainerInputs.Panel1.Controls.Add(this.gbMessage);
            this.sContainerInputs.Panel1MinSize = 100;
            // 
            // sContainerInputs.Panel2
            // 
            this.sContainerInputs.Panel2.Controls.Add(this.gbLog);
            this.sContainerInputs.Panel2MinSize = 100;
            this.sContainerInputs.Size = new System.Drawing.Size(436, 379);
            this.sContainerInputs.SplitterDistance = 147;
            this.sContainerInputs.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(150, 100);
            this.splitContainer2.TabIndex = 0;
            // 
            // nudMessageLength
            // 
            this.nudMessageLength.Location = new System.Drawing.Point(97, 171);
            this.nudMessageLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMessageLength.Name = "nudMessageLength";
            this.nudMessageLength.Size = new System.Drawing.Size(65, 20);
            this.nudMessageLength.TabIndex = 20;
            // 
            // lblMessageLength
            // 
            this.lblMessageLength.AutoSize = true;
            this.lblMessageLength.Location = new System.Drawing.Point(9, 173);
            this.lblMessageLength.Name = "lblMessageLength";
            this.lblMessageLength.Size = new System.Drawing.Size(82, 13);
            this.lblMessageLength.TabIndex = 21;
            this.lblMessageLength.Text = "Message length";
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 608);
            this.Controls.Add(this.sContainerMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRobustness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourcePicture)).EndInit();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNeighbourhoodLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNeighbourhoodLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRobustness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedundancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.sContainerMain.Panel1.ResumeLayout(false);
            this.sContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainerMain)).EndInit();
            this.sContainerMain.ResumeLayout(false);
            this.sContainerInputs.Panel1.ResumeLayout(false);
            this.sContainerInputs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainerInputs)).EndInit();
            this.sContainerInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMessageLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmHashDarling;
        private System.Windows.Forms.OpenFileDialog fdOpen;
        private System.Windows.Forms.SaveFileDialog fdSave;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TrackBar tbRobustness;
        private System.Windows.Forms.PictureBox pbSourcePicture;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label lblRedundancy;
        private System.Windows.Forms.TrackBar tbDensity;
        private System.Windows.Forms.NumericUpDown nudRedundancy;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Label lblRobustness;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.SplitContainer sContainerMain;
        private System.Windows.Forms.NumericUpDown nudDensity;
        private System.Windows.Forms.NumericUpDown nudRobustness;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer sContainerInputs;
        private System.Windows.Forms.NumericUpDown nudNeighbourhoodLength;
        private System.Windows.Forms.Label lblNeighbourhoodLength;
        private System.Windows.Forms.TrackBar tbNeighbourhoodLength;
        private System.Windows.Forms.Label lblMessageLength;
        private System.Windows.Forms.NumericUpDown nudMessageLength;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
    }
}

