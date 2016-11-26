namespace WindowsContentUpdater.Forms
{
    partial class frmSite
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
            this.scrSite = new System.Windows.Forms.SplitContainer();
            this.flmMenu = new WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenu();
            this.mbnInformation = new WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton();
            this.mbnCredentials = new WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton();
            this.flowLayoutButtonMenuButton1 = new WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton();
            ((System.ComponentModel.ISupportInitialize)(this.scrSite)).BeginInit();
            this.scrSite.Panel1.SuspendLayout();
            this.scrSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrSite
            // 
            this.scrSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scrSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrSite.Location = new System.Drawing.Point(0, 0);
            this.scrSite.Name = "scrSite";
            // 
            // scrSite.Panel1
            // 
            this.scrSite.Panel1.Controls.Add(this.flmMenu);
            // 
            // scrSite.Panel2
            // 
            this.scrSite.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.scrSite.Size = new System.Drawing.Size(1196, 736);
            this.scrSite.SplitterDistance = 416;
            this.scrSite.SplitterWidth = 8;
            this.scrSite.TabIndex = 0;
            // 
            // flmMenu
            // 
            this.flmMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flmMenu.Buttons.Add(this.mbnInformation);
            this.flmMenu.Buttons.Add(this.mbnCredentials);
            this.flmMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flmMenu.Location = new System.Drawing.Point(0, 0);
            this.flmMenu.Name = "flmMenu";
            this.flmMenu.Size = new System.Drawing.Size(414, 734);
            this.flmMenu.TabIndex = 0;
            this.flmMenu.Load += new System.EventHandler(this.flmMenu_Load);
            // 
            // mbnInformation
            // 
            this.mbnInformation.BackColor = System.Drawing.SystemColors.Control;
            this.mbnInformation.ButtonImage = global::WindowsContentUpdater.Properties.Resources.Help___01_48;
            this.mbnInformation.ButtonText = "Information";
            this.mbnInformation.Location = new System.Drawing.Point(11, 11);
            this.mbnInformation.Name = "mbnInformation";
            this.mbnInformation.Size = new System.Drawing.Size(382, 108);
            this.mbnInformation.TabIndex = 0;
            // 
            // mbnCredentials
            // 
            this.mbnCredentials.BackColor = System.Drawing.SystemColors.Control;
            this.mbnCredentials.ButtonImage = global::WindowsContentUpdater.Properties.Resources.Login2_WF_48;
            this.mbnCredentials.ButtonText = "Credentials";
            this.mbnCredentials.Location = new System.Drawing.Point(11, 125);
            this.mbnCredentials.Name = "mbnCredentials";
            this.mbnCredentials.Size = new System.Drawing.Size(382, 108);
            this.mbnCredentials.TabIndex = 1;
            // 
            // flowLayoutButtonMenuButton1
            // 
            this.flowLayoutButtonMenuButton1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutButtonMenuButton1.ButtonImage = global::WindowsContentUpdater.Properties.Resources.Help___01_48;
            this.flowLayoutButtonMenuButton1.ButtonText = "Information";
            this.flowLayoutButtonMenuButton1.Location = new System.Drawing.Point(11, 11);
            this.flowLayoutButtonMenuButton1.Name = "flowLayoutButtonMenuButton1";
            this.flowLayoutButtonMenuButton1.Size = new System.Drawing.Size(382, 108);
            this.flowLayoutButtonMenuButton1.TabIndex = 0;
            // 
            // frmSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 736);
            this.Controls.Add(this.scrSite);
            this.Name = "frmSite";
            this.Text = "Site - {SiteName}";
            this.scrSite.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scrSite)).EndInit();
            this.scrSite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scrSite;
        private WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenu flmMenu;
        private WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton mbnInformation;
        private WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton mbnCredentials;
        private WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton flowLayoutButtonMenuButton1;
    }
}