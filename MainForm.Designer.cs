namespace InfoPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphicCardGPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operativeSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundCardaudioDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.Snow;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1867, 555);
            this.MainPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphicCardGPUToolStripMenuItem,
            this.hardDrivesToolStripMenuItem,
            this.processorsToolStripMenuItem,
            this.operativeSystemToolStripMenuItem,
            this.networkInterfaceToolStripMenuItem,
            this.soundCardaudioDevicesToolStripMenuItem,
            this.printersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1867, 37);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graphicCardGPUToolStripMenuItem
            // 
            this.graphicCardGPUToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicCardGPUToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.graphicCardGPUToolStripMenuItem.Name = "graphicCardGPUToolStripMenuItem";
            this.graphicCardGPUToolStripMenuItem.Size = new System.Drawing.Size(241, 33);
            this.graphicCardGPUToolStripMenuItem.Text = "Graphic card (GPU)";
            this.graphicCardGPUToolStripMenuItem.Click += new System.EventHandler(this.graphicCardGPUToolStripMenuItem_Click);
            // 
            // hardDrivesToolStripMenuItem
            // 
            this.hardDrivesToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardDrivesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.hardDrivesToolStripMenuItem.Name = "hardDrivesToolStripMenuItem";
            this.hardDrivesToolStripMenuItem.Size = new System.Drawing.Size(157, 33);
            this.hardDrivesToolStripMenuItem.Text = "Hard drives";
            this.hardDrivesToolStripMenuItem.Click += new System.EventHandler(this.hardDrivesToolStripMenuItem_Click);
            // 
            // processorsToolStripMenuItem
            // 
            this.processorsToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processorsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.processorsToolStripMenuItem.Name = "processorsToolStripMenuItem";
            this.processorsToolStripMenuItem.Size = new System.Drawing.Size(165, 33);
            this.processorsToolStripMenuItem.Text = "Processor(s)";
            this.processorsToolStripMenuItem.Click += new System.EventHandler(this.processorsToolStripMenuItem_Click);
            // 
            // operativeSystemToolStripMenuItem
            // 
            this.operativeSystemToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operativeSystemToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.operativeSystemToolStripMenuItem.Name = "operativeSystemToolStripMenuItem";
            this.operativeSystemToolStripMenuItem.Size = new System.Drawing.Size(225, 33);
            this.operativeSystemToolStripMenuItem.Text = "Operative system";
            this.operativeSystemToolStripMenuItem.Click += new System.EventHandler(this.operativeSystemToolStripMenuItem_Click);
            // 
            // networkInterfaceToolStripMenuItem
            // 
            this.networkInterfaceToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkInterfaceToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.networkInterfaceToolStripMenuItem.Name = "networkInterfaceToolStripMenuItem";
            this.networkInterfaceToolStripMenuItem.Size = new System.Drawing.Size(236, 33);
            this.networkInterfaceToolStripMenuItem.Text = "Network interface";
            this.networkInterfaceToolStripMenuItem.Click += new System.EventHandler(this.networkInterfaceToolStripMenuItem_Click);
            // 
            // soundCardaudioDevicesToolStripMenuItem
            // 
            this.soundCardaudioDevicesToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundCardaudioDevicesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.soundCardaudioDevicesToolStripMenuItem.Name = "soundCardaudioDevicesToolStripMenuItem";
            this.soundCardaudioDevicesToolStripMenuItem.Size = new System.Drawing.Size(332, 33);
            this.soundCardaudioDevicesToolStripMenuItem.Text = "Sound card (audio devices)";
            this.soundCardaudioDevicesToolStripMenuItem.Click += new System.EventHandler(this.soundCardaudioDevicesToolStripMenuItem_Click);
            // 
            // printersToolStripMenuItem
            // 
            this.printersToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printersToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.printersToolStripMenuItem.Name = "printersToolStripMenuItem";
            this.printersToolStripMenuItem.Size = new System.Drawing.Size(118, 33);
            this.printersToolStripMenuItem.Text = "Printers";
            this.printersToolStripMenuItem.Click += new System.EventHandler(this.printersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 592);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "InfoPC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphicCardGPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardDrivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operativeSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundCardaudioDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printersToolStripMenuItem;
    }
}