namespace WindowsContentUpdater.Forms.Controls
{
    partial class SiteInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInformation = new System.Windows.Forms.Label();
            this.panInformation = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panSpacer = new System.Windows.Forms.Panel();
            this.panInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(8, 8);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(432, 84);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "Information";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panInformation
            // 
            this.panInformation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panInformation.Controls.Add(this.lblInformation);
            this.panInformation.Controls.Add(this.picIcon);
            this.panInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInformation.Location = new System.Drawing.Point(8, 8);
            this.panInformation.Name = "panInformation";
            this.panInformation.Padding = new System.Windows.Forms.Padding(8);
            this.panInformation.Size = new System.Drawing.Size(1057, 100);
            this.panInformation.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 140);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1057, 45);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxTitle.Location = new System.Drawing.Point(8, 185);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(1057, 31);
            this.tbxTitle.TabIndex = 4;
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.picIcon.Image = global::WindowsContentUpdater.Properties.Resources.Help___01_48;
            this.picIcon.Location = new System.Drawing.Point(1001, 8);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(48, 84);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // panSpacer
            // 
            this.panSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpacer.Location = new System.Drawing.Point(8, 108);
            this.panSpacer.Name = "panSpacer";
            this.panSpacer.Size = new System.Drawing.Size(1057, 32);
            this.panSpacer.TabIndex = 5;
            // 
            // SiteInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panSpacer);
            this.Controls.Add(this.panInformation);
            this.Name = "SiteInformation";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1073, 774);
            this.panInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel panInformation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Panel panSpacer;
    }
}
