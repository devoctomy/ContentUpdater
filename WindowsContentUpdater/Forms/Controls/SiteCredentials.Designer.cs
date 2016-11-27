namespace WindowsContentUpdater.Forms.Controls
{
    partial class SiteCredentials
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
            this.panCredentials = new System.Windows.Forms.Panel();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.picCredentials = new System.Windows.Forms.PictureBox();
            this.panSpacer = new System.Windows.Forms.Panel();
            this.lblAllCredentials = new System.Windows.Forms.Label();
            this.lbxAllCredentials = new System.Windows.Forms.ListBox();
            this.panCredentials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCredentials)).BeginInit();
            this.SuspendLayout();
            // 
            // panCredentials
            // 
            this.panCredentials.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panCredentials.Controls.Add(this.lblCredentials);
            this.panCredentials.Controls.Add(this.picCredentials);
            this.panCredentials.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCredentials.Location = new System.Drawing.Point(8, 8);
            this.panCredentials.Name = "panCredentials";
            this.panCredentials.Padding = new System.Windows.Forms.Padding(8);
            this.panCredentials.Size = new System.Drawing.Size(1188, 100);
            this.panCredentials.TabIndex = 3;
            // 
            // lblCredentials
            // 
            this.lblCredentials.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredentials.Location = new System.Drawing.Point(8, 8);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(432, 84);
            this.lblCredentials.TabIndex = 0;
            this.lblCredentials.Text = "Credentials";
            this.lblCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCredentials
            // 
            this.picCredentials.Dock = System.Windows.Forms.DockStyle.Right;
            this.picCredentials.Image = global::WindowsContentUpdater.Properties.Resources.Login2_WF_48;
            this.picCredentials.Location = new System.Drawing.Point(1132, 8);
            this.picCredentials.Name = "picCredentials";
            this.picCredentials.Size = new System.Drawing.Size(48, 84);
            this.picCredentials.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCredentials.TabIndex = 1;
            this.picCredentials.TabStop = false;
            // 
            // panSpacer
            // 
            this.panSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSpacer.Location = new System.Drawing.Point(8, 108);
            this.panSpacer.Name = "panSpacer";
            this.panSpacer.Size = new System.Drawing.Size(1188, 32);
            this.panSpacer.TabIndex = 6;
            // 
            // lblAllCredentials
            // 
            this.lblAllCredentials.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAllCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCredentials.Location = new System.Drawing.Point(8, 140);
            this.lblAllCredentials.Name = "lblAllCredentials";
            this.lblAllCredentials.Size = new System.Drawing.Size(1188, 45);
            this.lblAllCredentials.TabIndex = 7;
            this.lblAllCredentials.Text = "All Credentials";
            this.lblAllCredentials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxAllCredentials
            // 
            this.lbxAllCredentials.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxAllCredentials.FormattingEnabled = true;
            this.lbxAllCredentials.ItemHeight = 25;
            this.lbxAllCredentials.Location = new System.Drawing.Point(8, 185);
            this.lbxAllCredentials.Name = "lbxAllCredentials";
            this.lbxAllCredentials.Size = new System.Drawing.Size(1188, 204);
            this.lbxAllCredentials.TabIndex = 8;
            // 
            // SiteCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbxAllCredentials);
            this.Controls.Add(this.lblAllCredentials);
            this.Controls.Add(this.panSpacer);
            this.Controls.Add(this.panCredentials);
            this.Name = "SiteCredentials";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1204, 756);
            this.panCredentials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCredentials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCredentials;
        private System.Windows.Forms.Label lblCredentials;
        private System.Windows.Forms.PictureBox picCredentials;
        private System.Windows.Forms.Panel panSpacer;
        private System.Windows.Forms.Label lblAllCredentials;
        private System.Windows.Forms.ListBox lbxAllCredentials;
    }
}
