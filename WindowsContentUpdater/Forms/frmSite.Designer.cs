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
            this.flbInformation = new WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton();
            this.flbCredentials = new WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton();
            ((System.ComponentModel.ISupportInitialize)(this.scrSite)).BeginInit();
            this.scrSite.Panel1.SuspendLayout();
            this.scrSite.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrSite
            // 
            this.scrSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrSite.Location = new System.Drawing.Point(0, 0);
            this.scrSite.Name = "scrSite";
            // 
            // scrSite.Panel1
            // 
            this.scrSite.Panel1.Controls.Add(this.flmMenu);
            this.scrSite.Size = new System.Drawing.Size(1196, 736);
            this.scrSite.SplitterDistance = 398;
            this.scrSite.TabIndex = 0;
            // 
            // flmMenu
            // 
            this.flmMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flmMenu.Buttons.Add(this.flbInformation);
            this.flmMenu.Buttons.Add(this.flbCredentials);
            this.flmMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flmMenu.Location = new System.Drawing.Point(0, 0);
            this.flmMenu.Name = "flmMenu";
            this.flmMenu.Size = new System.Drawing.Size(398, 736);
            this.flmMenu.TabIndex = 2;
            // 
            // flbInformation
            // 
            this.flbInformation.BackColor = System.Drawing.SystemColors.Control;
            this.flbInformation.ButtonImage = global::WindowsContentUpdater.Properties.Resources.Help___01_48;
            this.flbInformation.ButtonText = "Information";
            this.flbInformation.Location = new System.Drawing.Point(11, 11);
            this.flbInformation.Name = "flbInformation";
            this.flbInformation.Size = new System.Drawing.Size(366, 108);
            this.flbInformation.TabIndex = 0;
            this.flbInformation.ButtonClicked += new System.EventHandler<System.EventArgs>(this.flbInformation_ButtonClicked);
            // 
            // flbCredentials
            // 
            this.flbCredentials.BackColor = System.Drawing.SystemColors.Control;
            this.flbCredentials.ButtonImage = global::WindowsContentUpdater.Properties.Resources.Login2_WF_48;
            this.flbCredentials.ButtonText = "Credentials";
            this.flbCredentials.Location = new System.Drawing.Point(11, 125);
            this.flbCredentials.Name = "flbCredentials";
            this.flbCredentials.Size = new System.Drawing.Size(366, 108);
            this.flbCredentials.TabIndex = 1;
            this.flbCredentials.ButtonClicked += new System.EventHandler<System.EventArgs>(this.flbCredentials_ButtonClicked);
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
        private WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton flbInformation;
        private WindowsContentUpdaterObjectLIbrary.Controls.FlowLayoutButtonMenuButton flbCredentials;
    }
}