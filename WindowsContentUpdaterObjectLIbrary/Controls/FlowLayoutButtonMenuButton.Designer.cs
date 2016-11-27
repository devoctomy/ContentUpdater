namespace WindowsContentUpdaterObjectLIbrary.Controls
{
    partial class FlowLayoutButtonMenuButton
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
            this.butButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butButton
            // 
            this.butButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butButton.Image = global::WindowsContentUpdaterObjectLIbrary.Properties.Resources.Pictures_WF_48_black;
            this.butButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butButton.Location = new System.Drawing.Point(0, 0);
            this.butButton.Name = "butButton";
            this.butButton.Padding = new System.Windows.Forms.Padding(16);
            this.butButton.Size = new System.Drawing.Size(251, 108);
            this.butButton.TabIndex = 0;
            this.butButton.Text = "{ButtonText}";
            this.butButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butButton.UseVisualStyleBackColor = true;
            this.butButton.Click += new System.EventHandler(this.butButton_Click);
            // 
            // FlowLayoutButtonMenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butButton);
            this.Name = "FlowLayoutButtonMenuButton";
            this.Size = new System.Drawing.Size(251, 108);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butButton;
    }
}
