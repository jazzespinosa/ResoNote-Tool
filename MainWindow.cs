using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ResoNote_Tool_v2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //get computer username
            string user = Environment.UserName;
            tboxUsername.Text = "Welcome " + user + "!";

            //initialize path
            string initialPath = Environment.CurrentDirectory;
            string targetPath = "";

            //check items for the dropdowns
            string pathCountry = initialPath + @"\config\Country.txt";
            targetPath = pathCountry;
            checkPath(targetPath);
            string[] dataListCountry = File.ReadAllLines(pathCountry);
            cboxCountry.DataSource = dataListCountry;

            string pathSource = initialPath + @"\config\Source.txt";
            targetPath = pathSource;
            checkPath(targetPath);
            string[] dataListSource = File.ReadAllLines(pathSource);
            cboxSource.DataSource = dataListSource;

            string pathTemplate = initialPath + @"\config\Template.txt";
            targetPath = pathTemplate;
            checkPath(targetPath);
            string[] dataListTemplate = File.ReadAllLines(pathTemplate);
            cboxTemplate.DataSource = dataListTemplate;

            string pathApp = initialPath + @"\config\Application.txt";
            targetPath = pathApp;
            checkPath(targetPath);
            string[] dataListApp = File.ReadAllLines(pathApp);
            cboxApplication.Items.AddRange(dataListApp);

            string pathReason = initialPath + @"\config\Reason.txt";
            targetPath = pathReason;
            checkPath(targetPath);
            string[] dataListReason = File.ReadAllLines(pathReason);
            cboxReason.Items.AddRange(dataListReason);

            //clear all dropdowns
            cboxApplication.SelectedItem = "AU Shared Folder";
            cboxPending.SelectedItem = "TRUE";
            cboxPrivilege.SelectedItem = "Non-Privilege";
            Clear();
        }

        //check if list files exists
        void checkPath(string pathCheck)
        {
            string path = pathCheck;

            if (!File.Exists(path))
            {
                string pathFileName = path.Split('\\').Last();
                MessageBox.Show("File " + pathFileName + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //set to default clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cboxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCountry.SelectedItem == null)
            {
                starCountry.Visible = true;
            }
            else
            {
                starCountry.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        private void cboxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSource.SelectedItem == null)
            {
                starSource.Visible = true;
            }
            else
            {
                starSource.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        private void cboxApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxApplication.SelectedItem == null)
            {
                starApplication.Visible = true;
                lblDuration.Visible = false;
                tboxDuration.Visible = false;
            }
            else
            {
                starApplication.Visible = false;
            }

            if (cboxApplication.Text == "AU Local Admin Rights")
            {
                lblDuration.Visible = true;
                tboxDuration.Visible = true;

                DurationWindow duration = new DurationWindow(this);
                duration.ShowDialog();
            }
            else
            {
                tboxDuration.Text = null;
                lblDuration.Visible = false;
                tboxDuration.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        public void PassValue(string strValue)
        {
            tboxDuration.Text = strValue;
        }

        public void ifNotLocalAdmin(string selection)
        {
            label2.Text = selection;
            if (selection == "N")
            {
                cboxApplication.SelectedItem = "AU Local Admin Rights";
            }
            else if (selection == "Y")
            {
                cboxApplication.SelectedItem = null;
                tboxDuration.Text = null;
            }
        }

        private void cboxPending_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPending.Text == "FALSE")
            {
                cboxReason.Items.Add("Not Applicable");
                cboxReason.SelectedItem = "Not Applicable";
                cboxReason.Enabled = false;
            }
            else
            {
                cboxReason.Items.Remove("Not Applicable");
                cboxReason.SelectedItem = null;
                cboxReason.Enabled = true;
                starReason.Visible = true;
            }

            if (cboxPending.SelectedItem == null)
            {
                starPending.Visible = true;
            }
            else
            {
                starPending.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        private void cboxReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxReason.SelectedItem == null)
            {
                starReason.Visible = true;
            }
            else
            {
                starReason.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        private void cboxPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPrivilege.SelectedItem == null)
            {
                starPrivilege.Visible = true;
            }
            else
            {
                starPrivilege.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        private void cboxTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTemplate.SelectedItem == null)
            {
                starTemplate.Visible = true;
            }
            else
            {
                starTemplate.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        private void tboxBeneficiary_TextChanged(object sender, EventArgs e)
        {
            if (tboxBeneficiary.Text.Length < 1)
            {
                starBeneficiary.Visible = true;
            }
            else
            {
                starBeneficiary.Visible = false;
            }

            UpdateReso();
            ifComplete();
        }

        //validate reso notes
        private void tboxResolution_TextChanged(object sender, EventArgs e)
        {
            ifComplete();
        }

        //highlight reso notes and copy
        private void tboxResolution_Click(object sender, EventArgs e)
        {
            selectResoNotes();
        }

        //focus on reso notes field when app selected
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            selectResoNotes();
        }

        //update reso notes field
        void UpdateReso()
        {
            tboxResolution.Text = null;
            //if (tboxDuration.Text != "")
            //{
            //    if (tboxDuration.Text == "Temp" || tboxDuration.Text == "Permanent")
            //    {
            //        tboxResolution.Text = cboxTemplate.Text + "_" + cboxCountry.Text + ";" + cboxSource.Text + ";" + cboxApplication.Text + ";" + cboxPending.Text + ";" + cboxReason.Text + ";" + tboxBeneficiary.Text + ";" + cboxPrivilege.Text;
            //    }
            //    else
            //        tboxResolution.Text = cboxTemplate.Text + "_" + cboxCountry.Text + ";" + cboxSource.Text + ";" + cboxApplication.Text + ";" + cboxPending.Text + ";" + cboxReason.Text + ";" + tboxBeneficiary.Text + ";" + cboxPrivilege.Text + "_" + tboxDuration.Text;
            //}
            //else
            tboxResolution.Text = cboxTemplate.Text + "_" + cboxCountry.Text + ";" + cboxSource.Text + ";" + cboxApplication.Text + ";" + cboxPending.Text + ";" + cboxReason.Text + ";" + tboxBeneficiary.Text + ";" + cboxPrivilege.Text;
        }

        //clear all fields
        void Clear()
        {
            cboxCountry.SelectedItem = null;
            cboxSource.SelectedItem = null;
            cboxApplication.SelectedItem = null;
            cboxPending.SelectedItem = null;
            cboxReason.SelectedItem = null;
            cboxPrivilege.SelectedItem = null;
            cboxTemplate.SelectedItem = null;
            tboxBeneficiary.Text = "1";
            tboxDuration.Text = null;
            tboxDuration.Text.Trim();

            tboxResolution.Text = null;
        }

        //check if all fields are populated
        void ifComplete()
        {
            if (cboxCountry.SelectedItem == null || cboxSource.SelectedItem == null || cboxApplication.SelectedItem == null || cboxPending.SelectedItem == null || cboxReason.SelectedItem == null || cboxPrivilege.SelectedItem == null || tboxBeneficiary.Text.Length < 1 || cboxTemplate.SelectedItem == null)
            {
                tboxResolution.Text = null;
            }
        }

        //automatic copy reso notes on focus
        void selectResoNotes()
        {
            tboxResolution.SelectAll();
            tboxResolution.Focus();

            if (tboxResolution.Text.Length > 0)
            {
                tboxResolution.Copy();
            }
        }

    }
}
