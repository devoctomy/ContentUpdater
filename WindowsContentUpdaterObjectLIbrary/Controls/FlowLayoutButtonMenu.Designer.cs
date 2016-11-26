namespace WindowsContentUpdaterObjectLIbrary.Controls
{
    partial class FlowLayoutButtonMenu
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
            this.flpLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpLayout
            // 
            this.flpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpLayout.Location = new System.Drawing.Point(0, 0);
            this.flpLayout.Name = "flpLayout";
            this.flpLayout.Size = new System.Drawing.Size(593, 502);
            this.flpLayout.TabIndex = 0;
            // 
            // FlowLayoutButtonMenu
            // 
            this.Controls.Add(this.flpLayout);
            this.Name = "FlowLayoutButtonMenu";
            this.Size = new System.Drawing.Size(593, 502);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLayout;
    }
}
