namespace ResoNote_Tool_v2
{
    partial class DurationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurationWindow));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxPermanent = new System.Windows.Forms.CheckBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.checkBoxTemp = new System.Windows.Forms.CheckBox();
            this.dtPickerDuration = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(31, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(158, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxPermanent
            // 
            this.checkBoxPermanent.AutoSize = true;
            this.checkBoxPermanent.Font = new System.Drawing.Font("Roboto", 10.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxPermanent.ForeColor = System.Drawing.Color.White;
            this.checkBoxPermanent.Location = new System.Drawing.Point(151, 42);
            this.checkBoxPermanent.Name = "checkBoxPermanent";
            this.checkBoxPermanent.Size = new System.Drawing.Size(98, 22);
            this.checkBoxPermanent.TabIndex = 12;
            this.checkBoxPermanent.Text = "Permanent";
            this.checkBoxPermanent.UseVisualStyleBackColor = true;
            this.checkBoxPermanent.CheckedChanged += new System.EventHandler(this.checkBoxPermanent_CheckedChanged);
            // 
            // lblApplication
            // 
            this.lblApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblApplication.AutoSize = true;
            this.lblApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblApplication.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplication.ForeColor = System.Drawing.Color.White;
            this.lblApplication.Location = new System.Drawing.Point(18, 13);
            this.lblApplication.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(115, 23);
            this.lblApplication.TabIndex = 11;
            this.lblApplication.Text = "Select End Date";
            this.lblApplication.UseCompatibleTextRendering = true;
            // 
            // checkBoxTemp
            // 
            this.checkBoxTemp.AutoSize = true;
            this.checkBoxTemp.Font = new System.Drawing.Font("Roboto", 10.5F, System.Drawing.FontStyle.Bold);
            this.checkBoxTemp.ForeColor = System.Drawing.Color.White;
            this.checkBoxTemp.Location = new System.Drawing.Point(32, 42);
            this.checkBoxTemp.Name = "checkBoxTemp";
            this.checkBoxTemp.Size = new System.Drawing.Size(111, 22);
            this.checkBoxTemp.TabIndex = 14;
            this.checkBoxTemp.Text = "Temp (1 day)";
            this.checkBoxTemp.UseVisualStyleBackColor = true;
            this.checkBoxTemp.CheckedChanged += new System.EventHandler(this.checkBoxTemp_CheckedChanged);
            // 
            // dtPickerDuration
            // 
            this.dtPickerDuration.CustomFormat = "MM/dd/yyyy";
            this.dtPickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerDuration.Location = new System.Drawing.Point(135, 9);
            this.dtPickerDuration.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerDuration.Name = "dtPickerDuration";
            this.dtPickerDuration.Size = new System.Drawing.Size(129, 26);
            this.dtPickerDuration.TabIndex = 15;
            this.dtPickerDuration.Value = new System.DateTime(2022, 9, 15, 7, 52, 12, 0);
            this.dtPickerDuration.ValueChanged += new System.EventHandler(this.dtPickerDuration_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxPermanent);
            this.panel1.Controls.Add(this.dtPickerDuration);
            this.panel1.Controls.Add(this.checkBoxTemp);
            this.panel1.Controls.Add(this.lblApplication);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(290, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 70);
            this.panel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 120);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.MaximumSize = new System.Drawing.Size(290, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 45);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 20;
            // 
            // DurationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DurationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Duration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DurationWindow_FormClosing);
            this.Load += new System.EventHandler(this.DurationWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxPermanent;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.CheckBox checkBoxTemp;
        private System.Windows.Forms.DateTimePicker dtPickerDuration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}