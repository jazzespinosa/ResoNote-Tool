
namespace ResoNote_Tool_v2
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tboxResolution = new System.Windows.Forms.TextBox();
            this.cboxSource = new System.Windows.Forms.ComboBox();
            this.cboxCountry = new System.Windows.Forms.ComboBox();
            this.cboxApplication = new System.Windows.Forms.ComboBox();
            this.cboxPending = new System.Windows.Forms.ComboBox();
            this.cboxReason = new System.Windows.Forms.ComboBox();
            this.cboxPrivilege = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tboxBeneficiary = new System.Windows.Forms.TextBox();
            this.lblBeneficiary = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.cboxTemplate = new System.Windows.Forms.ComboBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.starTemplate = new System.Windows.Forms.Label();
            this.starSource = new System.Windows.Forms.Label();
            this.starApplication = new System.Windows.Forms.Label();
            this.starPending = new System.Windows.Forms.Label();
            this.starReason = new System.Windows.Forms.Label();
            this.starCountry = new System.Windows.Forms.Label();
            this.starPrivilege = new System.Windows.Forms.Label();
            this.starBeneficiary = new System.Windows.Forms.Label();
            this.tboxDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxResolution
            // 
            this.tboxResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxResolution.BackColor = System.Drawing.Color.White;
            this.tboxResolution.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.tboxResolution.Location = new System.Drawing.Point(17, 372);
            this.tboxResolution.Name = "tboxResolution";
            this.tboxResolution.Size = new System.Drawing.Size(383, 26);
            this.tboxResolution.TabIndex = 0;
            this.tboxResolution.Click += new System.EventHandler(this.tboxResolution_Click);
            this.tboxResolution.TextChanged += new System.EventHandler(this.tboxResolution_TextChanged);
            // 
            // cboxSource
            // 
            this.cboxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxSource.BackColor = System.Drawing.Color.White;
            this.cboxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSource.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cboxSource.FormattingEnabled = true;
            this.cboxSource.Location = new System.Drawing.Point(17, 136);
            this.cboxSource.Name = "cboxSource";
            this.cboxSource.Size = new System.Drawing.Size(229, 26);
            this.cboxSource.TabIndex = 2;
            this.cboxSource.SelectedIndexChanged += new System.EventHandler(this.cboxSource_SelectedIndexChanged);
            // 
            // cboxCountry
            // 
            this.cboxCountry.BackColor = System.Drawing.Color.White;
            this.cboxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCountry.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cboxCountry.FormattingEnabled = true;
            this.cboxCountry.Location = new System.Drawing.Point(271, 77);
            this.cboxCountry.Name = "cboxCountry";
            this.cboxCountry.Size = new System.Drawing.Size(129, 26);
            this.cboxCountry.TabIndex = 3;
            this.cboxCountry.SelectedIndexChanged += new System.EventHandler(this.cboxCountry_SelectedIndexChanged);
            // 
            // cboxApplication
            // 
            this.cboxApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxApplication.BackColor = System.Drawing.Color.White;
            this.cboxApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxApplication.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cboxApplication.FormattingEnabled = true;
            this.cboxApplication.Location = new System.Drawing.Point(17, 195);
            this.cboxApplication.Name = "cboxApplication";
            this.cboxApplication.Size = new System.Drawing.Size(229, 26);
            this.cboxApplication.TabIndex = 4;
            this.cboxApplication.SelectedIndexChanged += new System.EventHandler(this.cboxApplication_SelectedIndexChanged);
            // 
            // cboxPending
            // 
            this.cboxPending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxPending.BackColor = System.Drawing.Color.White;
            this.cboxPending.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPending.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cboxPending.FormattingEnabled = true;
            this.cboxPending.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cboxPending.Location = new System.Drawing.Point(17, 254);
            this.cboxPending.Name = "cboxPending";
            this.cboxPending.Size = new System.Drawing.Size(229, 26);
            this.cboxPending.TabIndex = 5;
            this.cboxPending.SelectedIndexChanged += new System.EventHandler(this.cboxPending_SelectedIndexChanged);
            // 
            // cboxReason
            // 
            this.cboxReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxReason.BackColor = System.Drawing.Color.White;
            this.cboxReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxReason.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cboxReason.FormattingEnabled = true;
            this.cboxReason.Location = new System.Drawing.Point(17, 313);
            this.cboxReason.Name = "cboxReason";
            this.cboxReason.Size = new System.Drawing.Size(229, 26);
            this.cboxReason.TabIndex = 6;
            this.cboxReason.SelectedIndexChanged += new System.EventHandler(this.cboxReason_SelectedIndexChanged);
            // 
            // cboxPrivilege
            // 
            this.cboxPrivilege.BackColor = System.Drawing.Color.White;
            this.cboxPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPrivilege.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cboxPrivilege.FormattingEnabled = true;
            this.cboxPrivilege.Items.AddRange(new object[] {
            "Privilege",
            "Non-Privilege"});
            this.cboxPrivilege.Location = new System.Drawing.Point(271, 136);
            this.cboxPrivilege.Name = "cboxPrivilege";
            this.cboxPrivilege.Size = new System.Drawing.Size(129, 26);
            this.cboxPrivilege.TabIndex = 7;
            this.cboxPrivilege.SelectedIndexChanged += new System.EventHandler(this.cboxPrivilege_SelectedIndexChanged);
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSource.AutoSize = true;
            this.lblSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSource.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSource.ForeColor = System.Drawing.Color.White;
            this.lblSource.Location = new System.Drawing.Point(17, 113);
            this.lblSource.Margin = new System.Windows.Forms.Padding(0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(54, 23);
            this.lblSource.TabIndex = 8;
            this.lblSource.Text = "Source";
            this.lblSource.UseCompatibleTextRendering = true;
            // 
            // lblApplication
            // 
            this.lblApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblApplication.AutoSize = true;
            this.lblApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblApplication.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblApplication.ForeColor = System.Drawing.Color.White;
            this.lblApplication.Location = new System.Drawing.Point(17, 172);
            this.lblApplication.Margin = new System.Windows.Forms.Padding(0);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(85, 23);
            this.lblApplication.TabIndex = 10;
            this.lblApplication.Text = "Application";
            this.lblApplication.UseCompatibleTextRendering = true;
            // 
            // lblPending
            // 
            this.lblPending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPending.AutoSize = true;
            this.lblPending.BackColor = System.Drawing.Color.Transparent;
            this.lblPending.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPending.ForeColor = System.Drawing.Color.White;
            this.lblPending.Location = new System.Drawing.Point(17, 231);
            this.lblPending.Margin = new System.Windows.Forms.Padding(0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(152, 23);
            this.lblPending.TabIndex = 11;
            this.lblPending.Text = "External Dependency";
            this.lblPending.UseCompatibleTextRendering = true;
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.BackColor = System.Drawing.Color.Transparent;
            this.lblPrivilege.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPrivilege.ForeColor = System.Drawing.Color.White;
            this.lblPrivilege.Location = new System.Drawing.Point(271, 113);
            this.lblPrivilege.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(115, 23);
            this.lblPrivilege.TabIndex = 12;
            this.lblPrivilege.Text = "Level of Access";
            this.lblPrivilege.UseCompatibleTextRendering = true;
            // 
            // lblReason
            // 
            this.lblReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReason.AutoSize = true;
            this.lblReason.BackColor = System.Drawing.Color.Transparent;
            this.lblReason.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblReason.ForeColor = System.Drawing.Color.White;
            this.lblReason.Location = new System.Drawing.Point(17, 290);
            this.lblReason.Margin = new System.Windows.Forms.Padding(0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(118, 23);
            this.lblReason.TabIndex = 13;
            this.lblReason.Text = "Pending Reason";
            this.lblReason.UseCompatibleTextRendering = true;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(271, 54);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 23);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country";
            this.lblCountry.UseCompatibleTextRendering = true;
            // 
            // lblResolution
            // 
            this.lblResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResolution.AutoSize = true;
            this.lblResolution.BackColor = System.Drawing.Color.Transparent;
            this.lblResolution.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.lblResolution.ForeColor = System.Drawing.Color.White;
            this.lblResolution.Location = new System.Drawing.Point(17, 348);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(181, 20);
            this.lblResolution.TabIndex = 15;
            this.lblResolution.Text = "SNOW Resolution Notes";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PowderBlue;
            this.btnClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(290, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 36);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tboxBeneficiary
            // 
            this.tboxBeneficiary.BackColor = System.Drawing.Color.White;
            this.tboxBeneficiary.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.tboxBeneficiary.Location = new System.Drawing.Point(271, 197);
            this.tboxBeneficiary.Name = "tboxBeneficiary";
            this.tboxBeneficiary.Size = new System.Drawing.Size(129, 26);
            this.tboxBeneficiary.TabIndex = 17;
            this.tboxBeneficiary.TextChanged += new System.EventHandler(this.tboxBeneficiary_TextChanged);
            // 
            // lblBeneficiary
            // 
            this.lblBeneficiary.AutoSize = true;
            this.lblBeneficiary.BackColor = System.Drawing.Color.Transparent;
            this.lblBeneficiary.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiary.ForeColor = System.Drawing.Color.White;
            this.lblBeneficiary.Location = new System.Drawing.Point(271, 172);
            this.lblBeneficiary.Margin = new System.Windows.Forms.Padding(0);
            this.lblBeneficiary.Name = "lblBeneficiary";
            this.lblBeneficiary.Size = new System.Drawing.Size(143, 23);
            this.lblBeneficiary.TabIndex = 18;
            this.lblBeneficiary.Text = "No. of Beneficiaries";
            this.lblBeneficiary.UseCompatibleTextRendering = true;
            // 
            // lblTemplate
            // 
            this.lblTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.BackColor = System.Drawing.Color.Transparent;
            this.lblTemplate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTemplate.ForeColor = System.Drawing.Color.White;
            this.lblTemplate.Location = new System.Drawing.Point(17, 54);
            this.lblTemplate.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(71, 23);
            this.lblTemplate.TabIndex = 20;
            this.lblTemplate.Text = "Template";
            this.lblTemplate.UseCompatibleTextRendering = true;
            // 
            // cboxTemplate
            // 
            this.cboxTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxTemplate.BackColor = System.Drawing.Color.White;
            this.cboxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTemplate.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cboxTemplate.FormattingEnabled = true;
            this.cboxTemplate.Location = new System.Drawing.Point(17, 77);
            this.cboxTemplate.Name = "cboxTemplate";
            this.cboxTemplate.Size = new System.Drawing.Size(229, 26);
            this.cboxTemplate.TabIndex = 21;
            this.cboxTemplate.SelectedIndexChanged += new System.EventHandler(this.cboxTemplate_SelectedIndexChanged);
            // 
            // tboxUsername
            // 
            this.tboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxUsername.BackColor = System.Drawing.Color.White;
            this.tboxUsername.Enabled = false;
            this.tboxUsername.Font = new System.Drawing.Font("Roboto", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tboxUsername.Location = new System.Drawing.Point(17, 14);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.ReadOnly = true;
            this.tboxUsername.Size = new System.Drawing.Size(383, 30);
            this.tboxUsername.TabIndex = 9;
            this.tboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(124)))), ((int)(((byte)(182)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 52);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // starTemplate
            // 
            this.starTemplate.AutoSize = true;
            this.starTemplate.BackColor = System.Drawing.Color.Transparent;
            this.starTemplate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starTemplate.ForeColor = System.Drawing.Color.Red;
            this.starTemplate.Location = new System.Drawing.Point(7, 54);
            this.starTemplate.Margin = new System.Windows.Forms.Padding(0);
            this.starTemplate.Name = "starTemplate";
            this.starTemplate.Size = new System.Drawing.Size(13, 23);
            this.starTemplate.TabIndex = 23;
            this.starTemplate.Text = "*";
            this.starTemplate.UseCompatibleTextRendering = true;
            this.starTemplate.Visible = false;
            // 
            // starSource
            // 
            this.starSource.AutoSize = true;
            this.starSource.BackColor = System.Drawing.Color.Transparent;
            this.starSource.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starSource.ForeColor = System.Drawing.Color.Red;
            this.starSource.Location = new System.Drawing.Point(7, 112);
            this.starSource.Margin = new System.Windows.Forms.Padding(0);
            this.starSource.Name = "starSource";
            this.starSource.Size = new System.Drawing.Size(13, 23);
            this.starSource.TabIndex = 24;
            this.starSource.Text = "*";
            this.starSource.UseCompatibleTextRendering = true;
            this.starSource.Visible = false;
            // 
            // starApplication
            // 
            this.starApplication.AutoSize = true;
            this.starApplication.BackColor = System.Drawing.Color.Transparent;
            this.starApplication.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starApplication.ForeColor = System.Drawing.Color.Red;
            this.starApplication.Location = new System.Drawing.Point(7, 172);
            this.starApplication.Margin = new System.Windows.Forms.Padding(0);
            this.starApplication.Name = "starApplication";
            this.starApplication.Size = new System.Drawing.Size(13, 23);
            this.starApplication.TabIndex = 25;
            this.starApplication.Text = "*";
            this.starApplication.UseCompatibleTextRendering = true;
            this.starApplication.Visible = false;
            // 
            // starPending
            // 
            this.starPending.AutoSize = true;
            this.starPending.BackColor = System.Drawing.Color.Transparent;
            this.starPending.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starPending.ForeColor = System.Drawing.Color.Red;
            this.starPending.Location = new System.Drawing.Point(7, 231);
            this.starPending.Margin = new System.Windows.Forms.Padding(0);
            this.starPending.Name = "starPending";
            this.starPending.Size = new System.Drawing.Size(13, 23);
            this.starPending.TabIndex = 26;
            this.starPending.Text = "*";
            this.starPending.UseCompatibleTextRendering = true;
            this.starPending.Visible = false;
            // 
            // starReason
            // 
            this.starReason.AutoSize = true;
            this.starReason.BackColor = System.Drawing.Color.Transparent;
            this.starReason.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starReason.ForeColor = System.Drawing.Color.Red;
            this.starReason.Location = new System.Drawing.Point(7, 290);
            this.starReason.Margin = new System.Windows.Forms.Padding(0);
            this.starReason.Name = "starReason";
            this.starReason.Size = new System.Drawing.Size(13, 23);
            this.starReason.TabIndex = 27;
            this.starReason.Text = "*";
            this.starReason.UseCompatibleTextRendering = true;
            this.starReason.Visible = false;
            // 
            // starCountry
            // 
            this.starCountry.AutoSize = true;
            this.starCountry.BackColor = System.Drawing.Color.Transparent;
            this.starCountry.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starCountry.ForeColor = System.Drawing.Color.Red;
            this.starCountry.Location = new System.Drawing.Point(262, 54);
            this.starCountry.Margin = new System.Windows.Forms.Padding(0);
            this.starCountry.Name = "starCountry";
            this.starCountry.Size = new System.Drawing.Size(13, 23);
            this.starCountry.TabIndex = 28;
            this.starCountry.Text = "*";
            this.starCountry.UseCompatibleTextRendering = true;
            this.starCountry.Visible = false;
            // 
            // starPrivilege
            // 
            this.starPrivilege.AutoSize = true;
            this.starPrivilege.BackColor = System.Drawing.Color.Transparent;
            this.starPrivilege.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starPrivilege.ForeColor = System.Drawing.Color.Red;
            this.starPrivilege.Location = new System.Drawing.Point(262, 112);
            this.starPrivilege.Margin = new System.Windows.Forms.Padding(0);
            this.starPrivilege.Name = "starPrivilege";
            this.starPrivilege.Size = new System.Drawing.Size(13, 23);
            this.starPrivilege.TabIndex = 29;
            this.starPrivilege.Text = "*";
            this.starPrivilege.UseCompatibleTextRendering = true;
            this.starPrivilege.Visible = false;
            // 
            // starBeneficiary
            // 
            this.starBeneficiary.AutoSize = true;
            this.starBeneficiary.BackColor = System.Drawing.Color.Transparent;
            this.starBeneficiary.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.starBeneficiary.ForeColor = System.Drawing.Color.Red;
            this.starBeneficiary.Location = new System.Drawing.Point(262, 172);
            this.starBeneficiary.Margin = new System.Windows.Forms.Padding(0);
            this.starBeneficiary.Name = "starBeneficiary";
            this.starBeneficiary.Size = new System.Drawing.Size(13, 23);
            this.starBeneficiary.TabIndex = 30;
            this.starBeneficiary.Text = "*";
            this.starBeneficiary.UseCompatibleTextRendering = true;
            this.starBeneficiary.Visible = false;
            // 
            // tboxDuration
            // 
            this.tboxDuration.BackColor = System.Drawing.Color.White;
            this.tboxDuration.Enabled = false;
            this.tboxDuration.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.tboxDuration.Location = new System.Drawing.Point(271, 254);
            this.tboxDuration.Name = "tboxDuration";
            this.tboxDuration.Size = new System.Drawing.Size(129, 26);
            this.tboxDuration.TabIndex = 31;
            this.tboxDuration.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblDuration.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(271, 231);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(67, 23);
            this.lblDuration.TabIndex = 32;
            this.lblDuration.Text = "End Date";
            this.lblDuration.UseCompatibleTextRendering = true;
            this.lblDuration.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.tboxDuration);
            this.Controls.Add(this.starReason);
            this.Controls.Add(this.starPending);
            this.Controls.Add(this.starApplication);
            this.Controls.Add(this.starSource);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.cboxTemplate);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.lblBeneficiary);
            this.Controls.Add(this.tboxBeneficiary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblPrivilege);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.cboxPrivilege);
            this.Controls.Add(this.cboxReason);
            this.Controls.Add(this.cboxPending);
            this.Controls.Add(this.cboxApplication);
            this.Controls.Add(this.cboxCountry);
            this.Controls.Add(this.cboxSource);
            this.Controls.Add(this.tboxResolution);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.starTemplate);
            this.Controls.Add(this.starBeneficiary);
            this.Controls.Add(this.starPrivilege);
            this.Controls.Add(this.starCountry);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Resolution Categorization Tool";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResolution;
        private System.Windows.Forms.ComboBox cboxSource;
        private System.Windows.Forms.ComboBox cboxCountry;
        private System.Windows.Forms.ComboBox cboxPending;
        private System.Windows.Forms.ComboBox cboxReason;
        private System.Windows.Forms.ComboBox cboxPrivilege;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tboxBeneficiary;
        private System.Windows.Forms.Label lblBeneficiary;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.ComboBox cboxTemplate;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label starTemplate;
        private System.Windows.Forms.Label starSource;
        private System.Windows.Forms.Label starApplication;
        private System.Windows.Forms.Label starPending;
        private System.Windows.Forms.Label starReason;
        private System.Windows.Forms.Label starCountry;
        private System.Windows.Forms.Label starPrivilege;
        private System.Windows.Forms.Label starBeneficiary;
        private System.Windows.Forms.ComboBox cboxApplication;
        private System.Windows.Forms.TextBox tboxDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label2;
    }
}

