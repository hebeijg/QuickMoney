namespace QuickMonery
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.QuickMoneryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快速收银ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuickMoneryMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "V 1.0.0.0";
            // 
            // QuickMoneryMenu
            // 
            this.QuickMoneryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.快速收银ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.重启软件ToolStripMenuItem});
            this.QuickMoneryMenu.Name = "contextMenuStrip1";
            this.QuickMoneryMenu.Size = new System.Drawing.Size(125, 92);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            this.系统设置ToolStripMenuItem.Click += new System.EventHandler(this.SystemSet_Click);
            // 
            // 快速收银ToolStripMenuItem
            // 
            this.快速收银ToolStripMenuItem.Name = "快速收银ToolStripMenuItem";
            this.快速收银ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.快速收银ToolStripMenuItem.Text = "快速收银";
            this.快速收银ToolStripMenuItem.Click += new System.EventHandler(this.QuickMonery_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // 重启软件ToolStripMenuItem
            // 
            this.重启软件ToolStripMenuItem.Name = "重启软件ToolStripMenuItem";
            this.重启软件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重启软件ToolStripMenuItem.Text = "重启软件";
            this.重启软件ToolStripMenuItem.Click += new System.EventHandler(this.Reset_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 91);
            this.ContextMenuStrip = this.QuickMoneryMenu;
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.QuickMoneryMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip QuickMoneryMenu;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快速收银ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启软件ToolStripMenuItem;
    }
}