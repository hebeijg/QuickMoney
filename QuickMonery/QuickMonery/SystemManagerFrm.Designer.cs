namespace QuickMonery
{
    partial class SystemManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemManagerFrm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.palLeftPrint = new System.Windows.Forms.Panel();
            this.ptbLeftPrint = new System.Windows.Forms.PictureBox();
            this.lblLeftPrint = new System.Windows.Forms.Label();
            this.palLeftData = new System.Windows.Forms.Panel();
            this.ptbLeftData = new System.Windows.Forms.PictureBox();
            this.lblLeftData = new System.Windows.Forms.Label();
            this.palLeftkeyboard = new System.Windows.Forms.Panel();
            this.ptbLeftkeyboard = new System.Windows.Forms.PictureBox();
            this.lblLeftkeyboard = new System.Windows.Forms.Label();
            this.palLeftAbout = new System.Windows.Forms.Panel();
            this.ptbLeftAbout = new System.Windows.Forms.PictureBox();
            this.lblLeftAbout = new System.Windows.Forms.Label();
            this.lblExitSettings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCtTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flpLeft.SuspendLayout();
            this.palLeftPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftPrint)).BeginInit();
            this.palLeftData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftData)).BeginInit();
            this.palLeftkeyboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftkeyboard)).BeginInit();
            this.palLeftAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftAbout)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 19);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "设置";
            // 
            // flpLeft
            // 
            this.flpLeft.Controls.Add(this.palLeftPrint);
            this.flpLeft.Controls.Add(this.palLeftData);
            this.flpLeft.Controls.Add(this.palLeftkeyboard);
            this.flpLeft.Controls.Add(this.palLeftAbout);
            this.flpLeft.Location = new System.Drawing.Point(0, 56);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(200, 277);
            this.flpLeft.TabIndex = 3;
            // 
            // palLeftPrint
            // 
            this.palLeftPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.palLeftPrint.Controls.Add(this.ptbLeftPrint);
            this.palLeftPrint.Controls.Add(this.lblLeftPrint);
            this.palLeftPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.palLeftPrint.Location = new System.Drawing.Point(0, 0);
            this.palLeftPrint.Margin = new System.Windows.Forms.Padding(0);
            this.palLeftPrint.Name = "palLeftPrint";
            this.palLeftPrint.Size = new System.Drawing.Size(200, 48);
            this.palLeftPrint.TabIndex = 0;
            // 
            // ptbLeftPrint
            // 
            this.ptbLeftPrint.Image = ((System.Drawing.Image)(resources.GetObject("ptbLeftPrint.Image")));
            this.ptbLeftPrint.Location = new System.Drawing.Point(27, 14);
            this.ptbLeftPrint.Name = "ptbLeftPrint";
            this.ptbLeftPrint.Size = new System.Drawing.Size(20, 20);
            this.ptbLeftPrint.TabIndex = 1;
            this.ptbLeftPrint.TabStop = false;
            // 
            // lblLeftPrint
            // 
            this.lblLeftPrint.AutoSize = true;
            this.lblLeftPrint.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLeftPrint.Font = new System.Drawing.Font("黑体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeftPrint.ForeColor = System.Drawing.Color.White;
            this.lblLeftPrint.Location = new System.Drawing.Point(60, 17);
            this.lblLeftPrint.Name = "lblLeftPrint";
            this.lblLeftPrint.Size = new System.Drawing.Size(58, 15);
            this.lblLeftPrint.TabIndex = 0;
            this.lblLeftPrint.Tag = "0";
            this.lblLeftPrint.Text = "打印机";
            this.lblLeftPrint.Click += new System.EventHandler(this.lblSwitchMenu_Click);
            // 
            // palLeftData
            // 
            this.palLeftData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.palLeftData.Controls.Add(this.ptbLeftData);
            this.palLeftData.Controls.Add(this.lblLeftData);
            this.palLeftData.Cursor = System.Windows.Forms.Cursors.Default;
            this.palLeftData.Location = new System.Drawing.Point(0, 48);
            this.palLeftData.Margin = new System.Windows.Forms.Padding(0);
            this.palLeftData.Name = "palLeftData";
            this.palLeftData.Size = new System.Drawing.Size(200, 48);
            this.palLeftData.TabIndex = 1;
            // 
            // ptbLeftData
            // 
            this.ptbLeftData.Image = ((System.Drawing.Image)(resources.GetObject("ptbLeftData.Image")));
            this.ptbLeftData.Location = new System.Drawing.Point(27, 14);
            this.ptbLeftData.Name = "ptbLeftData";
            this.ptbLeftData.Size = new System.Drawing.Size(20, 20);
            this.ptbLeftData.TabIndex = 3;
            this.ptbLeftData.TabStop = false;
            // 
            // lblLeftData
            // 
            this.lblLeftData.AutoSize = true;
            this.lblLeftData.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLeftData.Font = new System.Drawing.Font("黑体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeftData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.lblLeftData.Location = new System.Drawing.Point(60, 17);
            this.lblLeftData.Name = "lblLeftData";
            this.lblLeftData.Size = new System.Drawing.Size(75, 15);
            this.lblLeftData.TabIndex = 2;
            this.lblLeftData.Tag = "1";
            this.lblLeftData.Text = "日志管理";
            this.lblLeftData.Click += new System.EventHandler(this.lblSwitchMenu_Click);
            // 
            // palLeftkeyboard
            // 
            this.palLeftkeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.palLeftkeyboard.Controls.Add(this.ptbLeftkeyboard);
            this.palLeftkeyboard.Controls.Add(this.lblLeftkeyboard);
            this.palLeftkeyboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.palLeftkeyboard.Location = new System.Drawing.Point(0, 96);
            this.palLeftkeyboard.Margin = new System.Windows.Forms.Padding(0);
            this.palLeftkeyboard.Name = "palLeftkeyboard";
            this.palLeftkeyboard.Size = new System.Drawing.Size(200, 48);
            this.palLeftkeyboard.TabIndex = 4;
            // 
            // ptbLeftkeyboard
            // 
            this.ptbLeftkeyboard.Image = ((System.Drawing.Image)(resources.GetObject("ptbLeftkeyboard.Image")));
            this.ptbLeftkeyboard.Location = new System.Drawing.Point(27, 14);
            this.ptbLeftkeyboard.Name = "ptbLeftkeyboard";
            this.ptbLeftkeyboard.Size = new System.Drawing.Size(20, 20);
            this.ptbLeftkeyboard.TabIndex = 3;
            this.ptbLeftkeyboard.TabStop = false;
            // 
            // lblLeftkeyboard
            // 
            this.lblLeftkeyboard.AutoSize = true;
            this.lblLeftkeyboard.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftkeyboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLeftkeyboard.Font = new System.Drawing.Font("黑体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeftkeyboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.lblLeftkeyboard.Location = new System.Drawing.Point(60, 17);
            this.lblLeftkeyboard.Name = "lblLeftkeyboard";
            this.lblLeftkeyboard.Size = new System.Drawing.Size(58, 15);
            this.lblLeftkeyboard.TabIndex = 2;
            this.lblLeftkeyboard.Tag = "2";
            this.lblLeftkeyboard.Text = "快捷键";
            this.lblLeftkeyboard.Click += new System.EventHandler(this.lblSwitchMenu_Click);
            // 
            // palLeftAbout
            // 
            this.palLeftAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.palLeftAbout.Controls.Add(this.ptbLeftAbout);
            this.palLeftAbout.Controls.Add(this.lblLeftAbout);
            this.palLeftAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.palLeftAbout.Location = new System.Drawing.Point(0, 144);
            this.palLeftAbout.Margin = new System.Windows.Forms.Padding(0);
            this.palLeftAbout.Name = "palLeftAbout";
            this.palLeftAbout.Size = new System.Drawing.Size(200, 48);
            this.palLeftAbout.TabIndex = 5;
            // 
            // ptbLeftAbout
            // 
            this.ptbLeftAbout.Image = ((System.Drawing.Image)(resources.GetObject("ptbLeftAbout.Image")));
            this.ptbLeftAbout.Location = new System.Drawing.Point(27, 14);
            this.ptbLeftAbout.Name = "ptbLeftAbout";
            this.ptbLeftAbout.Size = new System.Drawing.Size(20, 20);
            this.ptbLeftAbout.TabIndex = 3;
            this.ptbLeftAbout.TabStop = false;
            // 
            // lblLeftAbout
            // 
            this.lblLeftAbout.AutoSize = true;
            this.lblLeftAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLeftAbout.Font = new System.Drawing.Font("黑体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeftAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.lblLeftAbout.Location = new System.Drawing.Point(60, 17);
            this.lblLeftAbout.Name = "lblLeftAbout";
            this.lblLeftAbout.Size = new System.Drawing.Size(41, 15);
            this.lblLeftAbout.TabIndex = 2;
            this.lblLeftAbout.Tag = "3";
            this.lblLeftAbout.Text = "关于";
            this.lblLeftAbout.Click += new System.EventHandler(this.lblSwitchMenu_Click);
            // 
            // lblExitSettings
            // 
            this.lblExitSettings.AutoSize = true;
            this.lblExitSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblExitSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExitSettings.Font = new System.Drawing.Font("黑体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExitSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lblExitSettings.Location = new System.Drawing.Point(43, 543);
            this.lblExitSettings.Name = "lblExitSettings";
            this.lblExitSettings.Size = new System.Drawing.Size(75, 15);
            this.lblExitSettings.TabIndex = 4;
            this.lblExitSettings.Text = "退出设置";
            this.lblExitSettings.Click += new System.EventHandler(this.lblExitSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblCtTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(200, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 610);
            this.panel1.TabIndex = 6;
            // 
            // lblCtTitle
            // 
            this.lblCtTitle.AutoSize = true;
            this.lblCtTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCtTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCtTitle.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCtTitle.Location = new System.Drawing.Point(65, 26);
            this.lblCtTitle.Name = "lblCtTitle";
            this.lblCtTitle.Size = new System.Drawing.Size(171, 21);
            this.lblCtTitle.TabIndex = 2;
            this.lblCtTitle.Tag = "0";
            this.lblCtTitle.Text = "打印机相关设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(44, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "l";
            // 
            // SystemManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExitSettings);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemManagerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemManagerFrm";
            this.flpLeft.ResumeLayout(false);
            this.palLeftPrint.ResumeLayout(false);
            this.palLeftPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftPrint)).EndInit();
            this.palLeftData.ResumeLayout(false);
            this.palLeftData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftData)).EndInit();
            this.palLeftkeyboard.ResumeLayout(false);
            this.palLeftkeyboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftkeyboard)).EndInit();
            this.palLeftAbout.ResumeLayout(false);
            this.palLeftAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeftAbout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.Panel palLeftPrint;
        private System.Windows.Forms.Label lblLeftPrint;
        private System.Windows.Forms.PictureBox ptbLeftPrint;
        private System.Windows.Forms.Panel palLeftData;
        private System.Windows.Forms.PictureBox ptbLeftData;
        private System.Windows.Forms.Label lblLeftData;
        private System.Windows.Forms.Panel palLeftkeyboard;
        private System.Windows.Forms.PictureBox ptbLeftkeyboard;
        private System.Windows.Forms.Label lblLeftkeyboard;
        private System.Windows.Forms.Panel palLeftAbout;
        private System.Windows.Forms.PictureBox ptbLeftAbout;
        private System.Windows.Forms.Label lblLeftAbout;
        private System.Windows.Forms.Label lblExitSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCtTitle;
        private System.Windows.Forms.Label label2;
    }
}