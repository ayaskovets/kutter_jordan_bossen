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
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblRedundancy = new System.Windows.Forms.Label();
            this.tbDensity = new System.Windows.Forms.TrackBar();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblSeed = new System.Windows.Forms.Label();
            this.lblRobustness = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRobustness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourcePicture)).BeginInit();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbMessage.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmHashDarling});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.tsmOpen.Size = new System.Drawing.Size(162, 22);
            this.tsmOpen.Text = "Открыть";
            this.tsmOpen.Click += new System.EventHandler(this.OpenSourceImageHandler);
            // 
            // tsmSaveAs
            // 
            this.tsmSaveAs.Name = "tsmSaveAs";
            this.tsmSaveAs.Size = new System.Drawing.Size(162, 22);
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
            this.txtMessage.Size = new System.Drawing.Size(356, 97);
            this.txtMessage.TabIndex = 2;
            // 
            // tbRobustness
            // 
            this.tbRobustness.LargeChange = 1000;
            this.tbRobustness.Location = new System.Drawing.Point(75, 70);
            this.tbRobustness.Maximum = 10000;
            this.tbRobustness.Name = "tbRobustness";
            this.tbRobustness.Size = new System.Drawing.Size(281, 45);
            this.tbRobustness.SmallChange = 100;
            this.tbRobustness.TabIndex = 3;
            this.tbRobustness.Value = 5000;
            // 
            // pbSourcePicture
            // 
            this.pbSourcePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSourcePicture.Location = new System.Drawing.Point(12, 27);
            this.pbSourcePicture.Name = "pbSourcePicture";
            this.pbSourcePicture.Size = new System.Drawing.Size(408, 411);
            this.pbSourcePicture.TabIndex = 5;
            this.pbSourcePicture.TabStop = false;
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.lblDensity);
            this.gbSettings.Controls.Add(this.lblRedundancy);
            this.gbSettings.Controls.Add(this.tbDensity);
            this.gbSettings.Controls.Add(this.numericUpDown2);
            this.gbSettings.Controls.Add(this.lblSeed);
            this.gbSettings.Controls.Add(this.lblRobustness);
            this.gbSettings.Controls.Add(this.numericUpDown1);
            this.gbSettings.Controls.Add(this.tbRobustness);
            this.gbSettings.Location = new System.Drawing.Point(426, 27);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(362, 151);
            this.gbSettings.TabIndex = 5;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
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
            this.lblRedundancy.AutoSize = true;
            this.lblRedundancy.Location = new System.Drawing.Point(172, 123);
            this.lblRedundancy.Name = "lblRedundancy";
            this.lblRedundancy.Size = new System.Drawing.Size(68, 13);
            this.lblRedundancy.TabIndex = 14;
            this.lblRedundancy.Text = "Redundancy";
            // 
            // tbDensity
            // 
            this.tbDensity.LargeChange = 1000;
            this.tbDensity.Location = new System.Drawing.Point(75, 19);
            this.tbDensity.Maximum = 10000;
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Size = new System.Drawing.Size(281, 45);
            this.tbDensity.SmallChange = 100;
            this.tbDensity.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(246, 121);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(113, 20);
            this.numericUpDown2.TabIndex = 13;
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(3, 123);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(32, 13);
            this.lblSeed.TabIndex = 11;
            this.lblSeed.Text = "Seed";
            // 
            // lblRobustness
            // 
            this.lblRobustness.AutoSize = true;
            this.lblRobustness.Location = new System.Drawing.Point(6, 70);
            this.lblRobustness.Name = "lblRobustness";
            this.lblRobustness.Size = new System.Drawing.Size(63, 13);
            this.lblRobustness.TabIndex = 8;
            this.lblRobustness.Text = "Robustness";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 121);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.txtMessage);
            this.gbMessage.Location = new System.Drawing.Point(426, 184);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(362, 116);
            this.gbMessage.TabIndex = 10;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Location = new System.Drawing.Point(426, 306);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(362, 132);
            this.gbLog.TabIndex = 15;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(356, 113);
            this.txtLog.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbLog);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.pbSourcePicture);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Label lblRobustness;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
    }
}

