namespace ResoNote_Tool_v2
{
    partial class ucSamAccName
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
            this.tboxSamaccname = new System.Windows.Forms.TextBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxSamaccname
            // 
            this.tboxSamaccname.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.tboxSamaccname.Location = new System.Drawing.Point(165, 5);
            this.tboxSamaccname.Name = "tboxSamaccname";
            this.tboxSamaccname.Size = new System.Drawing.Size(118, 26);
            this.tboxSamaccname.TabIndex = 15;
            // 
            // lblApplication
            // 
            this.lblApplication.AutoSize = true;
            this.lblApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblApplication.Font = new System.Drawing.Font("Roboto", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblApplication.ForeColor = System.Drawing.Color.White;
            this.lblApplication.Location = new System.Drawing.Point(4, 9);
            this.lblApplication.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(163, 22);
            this.lblApplication.TabIndex = 14;
            this.lblApplication.Text = "User Samaccountname: ";
            this.lblApplication.UseCompatibleTextRendering = true;
            // 
            // testcontrol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.Controls.Add(this.tboxSamaccname);
            this.Controls.Add(this.lblApplication);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(290, 36);
            this.Name = "testcontrol";
            this.Size = new System.Drawing.Size(290, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxSamaccname;
        private System.Windows.Forms.Label lblApplication;
    }
}
